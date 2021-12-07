using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Gasto_Combustível
{
    public partial class CalculaGasto : Form
    {
        public CalculaGasto()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            if (Application.OpenForms.Count == 0)
            {
                Application.Exit();
            }
            else
            {
                foreach (Form formAberto in Application.OpenForms)
                {
                    if (formAberto is Principal)
                    {
                        formAberto.Show();
                        break;
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string n;
            //nome
            n = tbNome.ToString();

            float d;
            //distância
            try
            {
                d = float.Parse(tbDistancia.Text);
            }
            catch (Exception exception)
            {
                MessageBox.Show("Erro!Digite um valor numérico!");
                d = 0;
                tbConsumo.Text = "";
            }

            float c;
            //consumo
            try
            {
                c = float.Parse(tbConsumo.Text);
            }
            catch (Exception exception)
            {
                MessageBox.Show("Erro!Digite um valor numérico!");
                c = 0;
                tbConsumo.Text = "";
            }

            float p;
            //preçogasolina
            try
            {
                p = float.Parse(tbPreco.Text);
            }
            catch (Exception exception)
            {
                MessageBox.Show("Erro!Digite um valor numérico!");
                p = 0;
                tbConsumo.Text = "";
            }

            float g = d / c * p;
            //gasto

            label8.Text = ("R$");

            GastoTotal.Text = g.ToString();
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            tbNome.Text = ("");
            tbDistancia.Text = ("");
            tbConsumo.Text = ("");
            tbPreco.Text = ("");
            GastoTotal.Text = ("");
        }
    }
}
