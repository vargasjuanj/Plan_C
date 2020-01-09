using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crud
{
    public partial class Asiento : Form
    {
        int cont;
        static string fecha;
        static List<int> fechaRef = new List<int>();
        static List<int> fechaActual = new List<int>();

        static List<string> debe_haber = new List<string>();
        static List<string> cuenta = new List<string>();
        static List<double> valor = new List<double>();
        static int contPunto;

        public Asiento()
        {
            InitializeComponent();
        }
     
        private void Work_Load(object sender, EventArgs e)
        {
        
            deshabilitar();
            Repository.llenarComboBox(comboCuenta, "cuenta");
            comboCuenta.Text = "Caja";
            btnAgregarAsiento.Show();
            btnEliminar.Show();

        }

        private void btnAgregarAsiento_Click(object sender, EventArgs e)
        {
            habilitar();
            btnAgregarAsiento.Hide();
            btnEliminar.Hide();
            btnFinalizarAsiento.Show();
            btnRefresh.Show();
            btnFinalizarAsiento.Enabled = false;
        }
        public void habilitar()
        {

            lblCuenta.Show();
            comboCuenta.Show();
            btnRefresh.Show();
            btnAñadir.Show();

            lblFecha.Show();
            dtp1.Show();

            lblValor.Show();
            txtValor.Show();


            groupBox1.Show();

            btnCargar.Show();

   

            btnCancelar.Show();
            btnAgregarAsiento.Show();
            dtp2.Show();

         
        }
        public void deshabilitar()
        {

            lblCuenta.Hide();
            comboCuenta.Hide();
            btnRefresh.Hide();
            btnAñadir.Hide();

            lblFecha.Hide();
            dtp1.Hide();

            lblValor.Hide();
            txtValor.Hide();


            groupBox1.Hide();

            btnCargar.Hide();

            btnFinalizarAsiento.Hide();

            btnCancelar.Hide();

            lblOrden.Hide();
            txtOrden.Hide();
            btnBuscar.Hide();

            data.Hide();

            dtp2.Hide();
            lblBuscarFecha.Hide();


        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            deshabilitar();
            btnAgregarAsiento.Show();
            btnEliminar.Show();
            btnCancelar.Hide();
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            Cuenta cuenta = new Crud.Cuenta();
            cuenta.ShowDialog();

        }

        private void btnCorregir_Click(object sender, EventArgs e)
        {
            deshabilitar();
            btnAgregarAsiento.Hide();
            lblOrden.Show();
            txtOrden.Show();
            btnBuscar.Show();
            lblBuscarFecha.Show();
            dtp2.Show();
            data.Show();
         
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            fecha = dtp2.Value.Year + "/" + dtp2.Value.Month + "/" + dtp2.Value.Day;

            // data.DataSource = Repository.mostrarDiario();
            btnCancelar_Click(sender,e);
        }

        private void btnLibro_Click(object sender, EventArgs e)
        {
            Diario diario = new Crud.Diario();
            diario.ShowDialog();

        }

        private void btnMayor_Click(object sender, EventArgs e)
        {
            Mayor mayor = new Crud.Mayor();
            mayor.ShowDialog();
        }

        private void dtp1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void rdbHaber_CheckedChanged(object sender, EventArgs e)
        {

        }
        public bool fechaIncorrecta()
        {
           
                if (fechaActual[0] < fechaRef[0]) return true;
                else if (fechaActual[1] < fechaRef[1]) return true;
                else if (fechaActual[2] < fechaRef[2]) return true;
                return false;
                
                   
                
            
        }
        private void btnCargar_Click(object sender, EventArgs e)
        {
            if (cont == 1)
            {
                fechaRef.Add(dtp1.Value.Year);
                fechaRef.Add(dtp1.Value.Month);
                fechaRef.Add(dtp1.Value.Day);


            }

            fechaActual.Add(dtp1.Value.Year);
            fechaActual.Add(dtp1.Value.Month);
            fechaActual.Add(dtp1.Value.Day);
            if (cont > 0 && fechaIncorrecta())
            {
                MessageBox.Show("Las fechas deben ser cronólogicas");
                return;
            }

            bool op = false;

         
           try
            {
                cuenta.Add(comboCuenta.SelectedItem.ToString());
                valor.Add(Convert.ToDouble(txtValor.Text));
                if (rdbDebe.Checked) debe_haber.Add("D");
                else debe_haber.Add("H");

                op = Repository.comprobarAsiento(valor, debe_haber);
            }catch(Exception ee)
            {
                MessageBox.Show("Debe indicar un valor");
            }
            if (op) btnFinalizarAsiento.Enabled = true;
            else btnFinalizarAsiento.Enabled = false;
            txtValor.Text = "";
            contPunto = 0;
            
        }

        private void btnFinalizarAsiento_Click(object sender, EventArgs e)
        {
            cont++;
          

            fecha = dtp1.Value.Year + "/" + dtp1.Value.Month + "/" + dtp1.Value.Day;

            Repository.agregarAsiento(cuenta,fecha,valor,debe_haber);

            cuenta = new List<string>();
            valor = new List<double>();
            debe_haber = new List<string>();
            Work_Load(sender, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            comboCuenta.Items.Clear();
            Repository.llenarComboBox(comboCuenta, "cuenta");
        }

        private void txtValor_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
           
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }else if (contPunto==0 && (char)e.KeyChar=='.')
            {
                contPunto++;
                e.Handled = false;

            }else if (e.KeyChar == 02 || e.KeyChar == 03 || e.KeyChar == 08 || e.KeyChar == 127) //inicio, fin, backspace, superimir
            {

                e.Handled = false;
                if (!txtValor.Text.Contains(".")) contPunto = 0;
            }

            else
            {
                e.Handled = true;
            }
        }
    }
}
