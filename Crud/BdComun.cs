using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crud
{
   public class BdComun
    {
        public static MySqlConnection ObtenerConexion(string nombre="mysql")
        {

            MySqlConnection conectar = new MySqlConnection("server=127.0.0.1; database="+nombre+"; Uid=root; pwd=;");

            conectar.Open();

            return conectar;
        }
    }
}
