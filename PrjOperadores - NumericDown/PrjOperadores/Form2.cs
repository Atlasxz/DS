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
    public partial class Form2 : Form
    {

        double v1, v2;
        string op = "";

        public Form2()
        {
            InitializeComponent();
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            v1 = 0;
            v2 = 0;
            op = "";
            txtV1.Text = "0,00";
            txtV2.Text = "0,00";
            lblResultado.Text = "";
            txtV1.Focus();
        }
        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void BtnSoma_Click(object sender, EventArgs e)
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

                op = (sender as Button).Text;

                if (op == "+")
                {
                    resultado = v1 + v2;
                    lblResultado.Text = resultado.ToString("F2");
                }
                else if (op == "-")
                {
                    resultado = v1 - v2;
                    lblResultado.Text = resultado.ToString("F2");
                }
                else if (op == "/")
                {
                    resultado = v1 / v2;
                    lblResultado.Text = resultado.ToString("F2");
                }
                else if (op == "X")
                {
                    resultado = v1 * v2;
                    lblResultado.Text = resultado.ToString("F2");
                }
                else if (op == "Potência")
                {
                    resultado = Math.Pow(v1, v2);
                    lblResultado.Text = resultado.ToString("F2");
                }
            }
            catch (Exception erro)
            {
                lblResultado.Text = "O seguinte erro foi dado: \n" + erro;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void GroupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void LblResultado_Click(object sender, EventArgs e)
        {

        }


        private void TxtV1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("HH:mm:ss");
            lblDia.Text = DateTime.Now.ToString("dd/MM/yyyy");
            lblSemana.Text = DateTime.Now.ToString("dddd").ToUpper();


        }

    }
}
