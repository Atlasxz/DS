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

        double v1, v2;
        string op = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            v1 = 0;
            v2 = 0;
            op = "";
            txtV1.Text = "";
            txtV2.Text = "";
            lblResultado.Text = "";
            txtV1.Focus();




        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnSoma_Click(object sender, EventArgs e)
        {
            op = "+";

        }

        private void BtnSub_Click(object sender, EventArgs e)
        {
            op = "-";
        }

        private void BtnDividir_Click(object sender, EventArgs e)
        {
            op = "/";

        }

        private void BtnVezes_Click(object sender, EventArgs e)
        {
            op = "*";

        }

        private void BtnPower_Click(object sender, EventArgs e)
        {
            op = "^";
        }

        private void TxtV1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (e.KeyChar == 08) return;

            //if (e.KeyChar < 48 || e.KeyChar > 57)
            //{
            //    e.KeyChar = (char)0;
            //}
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

        private void TxtV1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtV2_TextChanged(object sender, EventArgs e)
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

        private void PictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void LblSamYIsa_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void TxtV1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void BtnValidar_Click(object sender, EventArgs e)
        {

            if (txtV1.Text=="" ||
                txtV2.Text == "")
            {
                MessageBox.Show("Campo Vazio", "Atente-se");
                return;
            }
            v1 = Convert.ToDouble(txtV1.Text);
            v2 = Convert.ToDouble(txtV2.Text);
            Double resultado;

            try
            {

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
                    resultado = Math.Pow(v1,v2);
                    lblResultado.Text = resultado.ToString();
                }
            }catch (Exception erro)
            {
                lblResultado.Text = "O seguinte erro foi dado: \n" + erro;
            }
        }
    }
}
