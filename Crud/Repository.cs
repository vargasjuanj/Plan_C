using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crud
{
    class Repository
    {

        public static string nombreBD;
   public static void agregarCuenta(string tipo, string descripcion)
        {
            try
            {
                MySqlCommand comando = null;
              
                    comando = new MySqlCommand(string.Format("Insert into  cuenta (descripcion,tipo) values     ('{0}','{1}')", descripcion,tipo), BdComun.ObtenerConexion(nombreBD));
                    comando.ExecuteNonQuery();
                MessageBox.Show("Agregada Correctamente");
            }
            catch(Exception ee)
            {
                MessageBox.Show("El nombre de la cuenta ya existe");
            }

        }
        public static void agregarAsiento(List<string> cuenta, string fecha, List<double> valor, List<string>debe_haber)
        {
            int numAsiento = cargarUltimoNumAsiento();
            numAsiento += 1;
            MySqlCommand comando = null;
      for (int i=0; i<debe_haber.Count; i++)
            {
                comando = new MySqlCommand(string.Format("Insert into  asiento (id_asiento,fecha,valor,debe_haber) values     ('{0}','{1}','{2}','{3}')", numAsiento.ToString(), fecha, valor[i], debe_haber[i]), BdComun.ObtenerConexion(nombreBD));
                comando.ExecuteNonQuery();
            }

           

           
        }

        private static int cargarUltimoNumAsiento()
        {
            int result = 0;
            MySqlCommand comando = new MySqlCommand(String.Format("SELECT id_asiento FROM asiento"),BdComun.ObtenerConexion(nombreBD));
            MySqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                result = Convert.ToInt32(reader.GetValue(0).ToString());
           
            }

            return result;
        }

        public static int Crear(string nombre)
        {
            int retorno = 0;
            nombre += "_";
            try
            {
                MySqlConnection conexion = BdComun.ObtenerConexion();
                MySqlCommand cmd = new MySqlCommand(string.Format("create database {0}", nombre), conexion);
                retorno = cmd.ExecuteNonQuery();
 
                cmd = new MySqlCommand(string.Format("USE {0}; CREATE TABLE cuenta (descripcion VARCHAR(30) NOT NULL, PRIMARY KEY(descripcion) ,tipo VARCHAR(2)NOT NULL); CREATE TABLE asiento(id_asiento INT NOT NULL, fecha DATE, valor INT, debe_haber VARCHAR(1) NOT NULL ); ", nombre), BdComun.ObtenerConexion(nombre));
               cmd.ExecuteNonQuery();
          
                cmd = new MySqlCommand(string.Format("Insert into  cuenta (Descripcion,Tipo) values     ('{0}','{1}');Insert into  cuenta (Descripcion,Tipo) values     ('{2}','{3}');Insert into  cuenta (Descripcion,Tipo) values     ('{4}','{5}');", "caja", "A","proveedor","P","capital","PN"), BdComun.ObtenerConexion(nombre));
               cmd.ExecuteNonQuery();
                cmd = new MySqlCommand(string.Format("Insert into  asiento (id_asiento) values     ('{0}')", "0"), BdComun.ObtenerConexion(nombre));
                cmd.ExecuteNonQuery();


                return retorno;
            }catch(Exception e)
            {
                MessageBox.Show("Base de datos existente o error de conexión");
                return retorno;
            }
          
        }
        public static int importar(string bd)
        {
            int retorno = 0;
            MySqlConnection conexion = BdComun.ObtenerConexion();
     
            MySqlCommand cmd = new MySqlCommand(string.Format("use {0}",bd), conexion);
            retorno = cmd.ExecuteNonQuery();
            return retorno;
        }
        
        public static List<string> Buscar(string id_asiento, string fecha)
        {
            List<string> _lista = new List<string>();
//Tener mucho cuidado colocar bien las mayusculas en los nombres de la tabla de la base de datos y a la hora de poner los queryes, todo debe coincidir.
            MySqlCommand _comando = new MySqlCommand(String.Format(
           "SELECT * from cuenta"), BdComun.ObtenerConexion(nombreBD)); //where descripcion ='{0}' or tipo='{1
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {

                string aux = "";
                aux += _reader.GetString(0);
          
                aux += _reader.GetString(1);
   


                _lista.Add(aux);
              
            }

            return _lista;
        }

        internal static bool comprobarAsiento(List<double> valor, List<string> debe_haber)
        {
      
            double debe = 0, haber = 0, aux = 0;

            for(int i=0; i<valor.Count; i++)
            {
                if (debe_haber[i].Equals("D")) debe += valor[i];
                else haber += valor[i];
            }

            aux = debe - haber;
            if (aux == 0) return true;
            else return false;
            
            
        }

       

        public static int Eliminar(int pId)
        {
            int retorno = 0;

            MySqlConnection conexion = BdComun.ObtenerConexion();
            MySqlCommand comando = new MySqlCommand(string.Format("Delete From clientes where IdCliente={0}", pId), conexion);

            retorno = comando.ExecuteNonQuery();
            conexion.Close();

            return retorno;

        }
       public static void llenarComboBox(ComboBox combo, string opcion)
        {
            MySqlConnection conexion = BdComun.ObtenerConexion();
            string aux = "";

            MySqlCommand comando = null;
            MySqlCommand comando2 = null;
            if (opcion.Equals("plan"))
            {
               comando = new MySqlCommand(string.Format("SHOW DATABASES"), conexion);

                MySqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    aux = reader.GetValue(0).ToString();
                    if (aux[aux.Length - 1].Equals('_'))
                        combo.Items.Add(aux);
                }
            }
            else if (opcion.Equals("cuenta"))
            {

                comando2 = new MySqlCommand(string.Format("use {0}",nombreBD), conexion);
                comando2.ExecuteNonQuery();

                comando = new MySqlCommand(string.Format("SELECT descripcion FROM cuenta"), conexion);
                MySqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    aux = reader.GetValue(0).ToString();
              
                        combo.Items.Add(aux);
                }
            }
            else
            {
                comando2 = new MySqlCommand(string.Format("use {0}", nombreBD), conexion);
                comando2.ExecuteNonQuery();
                comando = new MySqlCommand(string.Format("SELECT tipo FROM cuenta"), conexion);
                MySqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    aux = reader.GetValue(0).ToString();
                   
                    combo.Items.Add(aux);
                }
            }
   
           
    
            conexion.Close();
            
        }
        public static DataTable mostrarDiario(DataGridView datagrid)
        {
            string instruccion = "select * from asiento;";
            MySqlDataAdapter adp = new MySqlDataAdapter(instruccion, BdComun.ObtenerConexion(nombreBD));
            DataTable consulta = new DataTable();
            adp.Fill(consulta);
            return consulta;

        }

 
    }
}
