using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrjIMC
{
    public partial class Form1 : Form
    {

        Double IMC, peso, altura;

        public Form1()
        {
            InitializeComponent();
        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();

            double counter;

            
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            lblClassi.Text = "";
            lblIMC.Text = "";
            txtAltura.Text = "";
            txtPeso.Text = "";
            IMC = 0.0;
            altura = 0.0;
            peso = 0.0;

            btnLimpar.Enabled = false;
            txtPeso.Focus();

        }

        private void TxtPeso_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (e.KeyChar == 08) return;

            //if (e.KeyChar < 48 || e.KeyChar > 57)
            //{
            //    e.KeyChar = (char)0;
            //}
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                altura = Convert.ToDouble(txtAltura.Text);
            peso = Convert.ToDouble(txtPeso.Text);


            if (txtAltura.Text == "" ||
               txtPeso.Text =="")
            {
                MessageBox.Show("Campo Vazio", "Atenção");
                return;
            }
            if(altura < 1 || altura > 3)
            {
                MessageBox.Show("Valor Excedente ou Menor", "Atenção");
                return;

            }
            if (peso < 30)
            {
                MessageBox.Show("Valor Menor do que o necessário", "Atenção");
                return;

            }

            
            btnCalcular.Enabled = true;
            btnCalcular.Focus();

            peso = Convert.ToDouble(txtPeso.Text);
            altura = Convert.ToDouble(txtAltura.Text);

            IMC = peso / (altura * altura);

            lblIMC.Text = IMC.ToString();

            }catch (Exception erro)
            {
                lblErro.Text = "Erro encontrado: \n" + erro;
                return;
            }


            if (IMC < 16)
            {
                lblClassi.Text = "Magreza grau III";
            }
            else if (IMC < 17)
            {
                lblClassi.Text = "Magreza grau II";
            }
            else if (IMC < 18.5)
            {
                lblClassi.Text = "Magreza grau I";
            }
            else if (IMC < 25)
            {
                lblClassi.Text = "Adequado";
                
            }
            else if (IMC < 30)
            {
                lblClassi.Text = "Pré-Obeso";
            }
            else if (IMC < 35)
            {
                lblClassi.Text = "Obesidade grau I";
            }
            else if (IMC < 40)
            {
                lblClassi.Text = "Obesidade grau II";
            }
            else if (IMC >= 40)
            {
                lblClassi.Text = "Obesidade grau III";
            }

            btnLimpar.Enabled = true;


        }
    }
}
