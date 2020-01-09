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
    public partial class Diario : Form
    {
        public Diario()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Diario_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource= Repository.mostrarDiario(dataGridView1);
        }
    }
}
