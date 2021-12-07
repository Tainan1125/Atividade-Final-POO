using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gasto_Combustível
{
    public partial class Principal : Form
    {

        public Principal()
        {
            InitializeComponent();
        }

        private void mnSobre_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new Sobre();
            form.Show();
        }

        private void mnCalculaGasto_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new CalculaGasto();
            form.Show();
        }
    }
}
