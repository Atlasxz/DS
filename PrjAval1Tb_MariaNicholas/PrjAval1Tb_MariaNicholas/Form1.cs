using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrjAval1Tb_MariaNicholas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnVerificar_Click(object sender, EventArgs e)
        {

            //if (TxtB1.Text == "" ||
            //   TxtB2.Text == "" ||
            //   TxtB3.Text == "")
            //{
            //    MessageBox.Show("Campo vazio", "Atenção");
            //    return;
            //}

            if (TxtB1.Text == "8")
            {
                lblStatus1.Text = "CORRETO";
            }
            else
            {
                lblStatus1.Text = "ATENTE-SE";


            }
            if (TxtB2.Text == "2")
            {
                lblStatus2.Text = "CORRETO";

            }
            else
            {
                lblStatus2.Text = "ATENTE-SE";

            }
            if (TxtB3.Text == "5")
            {
                lblStatus3.Text = "CORRETO";

            }
            else
            {
                lblStatus3.Text = "ATENTE-SE";

            }

            if (TxtB1.Text == "8" &&
                     TxtB2.Text == "2" &&
                     TxtB3.Text == "5")
            {
                MessageBox.Show("Parabéns " + TxtNomeB.Text + "!! ^^", "Atividade Completa!!");
                //return;
            }

        }
        private void BtnLimpar_Click(object sender, EventArgs e)
        {

            if (lblStatus1.Text != "8")
            {
                lblStatus1.Text = "";
                TxtB1.Text = "";

                if (lblStatus2.Text != "2")
                {
                    lblStatus2.Text = "";
                    TxtB2.Text = "";
                }

                if (lblStatus3.Text != "5")
                {
                    lblStatus3.Text = "";
                    TxtB3.Text = "";
                }

                if (TxtB1.Text == "8" &&
                    TxtB2.Text == "2" &&
                    TxtB3.Text == "5")
                {
                    TxtNomeB.Text = "";
                    lblStatus1.Text = "";
                    TxtB1.Text = "";
                    lblStatus2.Text = "";
                    TxtB2.Text = "";
                    lblStatus3.Text = "";
                    TxtB3.Text = "";
                }
                TxtNomeB.Focus();

            }
        }
        private void BtnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
