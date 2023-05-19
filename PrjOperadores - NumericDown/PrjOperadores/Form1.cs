using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrjOperadores
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double v1, v2;
        string op = "";

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Label6_Click_1(object sender, EventArgs e)
        {
            Form2 FormNumberDown = new Form2();
            FormNumberDown.ShowDialog();
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            v1 = 0;
            v2 = 0;
            op = "";
            txtV1.Text = "";
            txtV2.Text = "";
            lblResultado.Text = "";
            txtV1.Focus();
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void BtnSoma_Click_1(object sender, EventArgs e)
        {
            op = "+";
        }

        private void BtnSub_Click_1(object sender, EventArgs e)
        {
            op = "-";
        }

        private void BtnDividir_Click_1(object sender, EventArgs e)
        {
            op = "/";
        }

        private void BtnVezes_Click_1(object sender, EventArgs e)
        {
            op = "*";
        }

        private void BtnPower_Click(object sender, EventArgs e)
        {
            op = "^";
        }

        private void BtnValidar_Click(object sender, EventArgs e)
        {
            if (txtV1.Text == "" ||
                txtV2.Text == "")
            {
                MessageBox.Show("Campo Vazio", "Atente-se");
                return;
            }

            try
            {
                v1 = Convert.ToDouble(txtV1.Text);
                v2 = Convert.ToDouble(txtV2.Text);
                Double resultado;

                if (op == "+")
                {
                    resultado = v1 + v2;
                    lblResultado.Text = resultado.ToString();
                }
                else if (op == "-")
                {
                    resultado = v1 - v2;
                    lblResultado.Text = resultado.ToString();
                }
                else if (op == "/")
                {
                    resultado = v1 / v2;
                    lblResultado.Text = resultado.ToString();
                }
                else if (op == "*")
                {
                    resultado = v1 * v2;
                    lblResultado.Text = resultado.ToString();
                }
                else if (op == "^")
                {
                    resultado = Math.Pow(v1, v2);
                    lblResultado.Text = resultado.ToString();
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("O seguinte erro foi dado: \n" + erro, "Erro Crasso");
                v1 = 0;
                v2 = 0;
            }
        }

    }
}
