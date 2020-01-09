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
    public partial class Cuenta : Form
    {
        public Cuenta()
        {
            InitializeComponent();
        }

        private void Cuenta_Load(object sender, EventArgs e)
        {

            try
            {
                Repository.llenarComboBox(comboTipo, "tipo");

            }
            catch (Exception ee)
            {
              
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            
            if(textBox2.Text.Equals(""))
            {
                MessageBox.Show("Debe ingresar el nombre o descripción de la cuenta");
                return;
            }
            try
            {
                Repository.agregarCuenta(comboTipo.SelectedItem.ToString(), textBox2.Text);
                textBox2.Text = "";
            }
            catch(Exception ee)
            {
                MessageBox.Show("Seleccione un tipo");
            }
       
        }
    }
}
