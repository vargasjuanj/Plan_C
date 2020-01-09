using MySqlX.XDevAPI;
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
    public partial class Raiz : Form
    {
        int retorno;
        public Raiz()
        {
            InitializeComponent();
        }

        private void Raiz_Load(object sender, EventArgs e)
        {
            
            try
            {
                Repository.llenarComboBox( comboBox1,"plan");
        
            }
            catch(Exception ee)
            {
                MessageBox.Show("Error de conexión");
            }
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           

        }

        private void btnImportar_Click(object sender, EventArgs e)
        {
            try
            {



                retorno = Repository.importar(comboBox1.SelectedItem.ToString());
              
                Repository.nombreBD = comboBox1.SelectedItem.ToString();
                Asiento work1 = new Crud.Asiento();
                work1.ShowDialog();
            }catch(Exception ee)
            {
                MessageBox.Show("Debe seleccionar algún plan, o no poseee planes activos");
            }
      
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
             retorno =1;
       
            if (txtEO.Text != "")
            {
               retorno= Repository.Crear(txtEO.Text);
                Repository.nombreBD = txtEO.Text + "_";
                if (retorno ==1)
                {
                    Asiento work1 = new Crud.Asiento();
                    work1.ShowDialog();
                }
                
            }

            else
            {

                lblMensaje.Text = "Debe ingresar un Nombre";   
                
            }
            comboBox1.Items.Clear();
            comboBox1.Text = "";
            
        }

        private void txtEO_TextChanged(object sender, EventArgs e)
        {
            lblMensaje.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            comboBox1.Items.Clear();
            comboBox1.Text = "";
            Raiz_Load(sender,e);
        }

       
    }
}
