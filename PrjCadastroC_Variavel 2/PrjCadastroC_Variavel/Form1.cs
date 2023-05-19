using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrjCadastroC_Variavel
{
    public partial class Exe005 : Form
    {

        byte idade1, idade2, idade3;
        string nome1, nome2, nome3;

        public Exe005()
        {
            InitializeComponent();
            

        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Label9_Click(object sender, EventArgs e)
        {

        }

        private void GroupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void BtnExibir_Click(object sender, EventArgs e)
        {
            
            if ((txtIdade1.Text=="")  || 
               (txtIdade2.Text == "") ||
               (txtIdade3.Text == "") ||
               (txtNome1.Text=="")    ||
               (txtNome2.Text=="")    ||
               (txtNome3.Text=="")
               )
            {
                MessageBox.Show("Campo Vazio!!", "Atente-se Imprudente");
                return;
            }

            idade1 = Convert.ToByte(txtIdade1.Text);
            idade2 = Convert.ToByte(txtIdade2.Text);
            idade3 = Convert.ToByte(txtIdade3.Text);
            nome1 = txtNome1.Text;
            nome2 = txtNome2.Text;
            nome3 = txtNome3.Text;




            if (idade1 <= 0 || idade1 >= 110 || 
                idade2 <= 0 || idade2 >=110 ||
                idade3 <= 0 || idade3 >110)
            {
                MessageBox.Show("Verifique o valor da idade!!!", "Atente-se Imprudente");
                return;
            }

            if (idade1 > idade2 && idade1 > idade3)
            {
                lblNomeMucilon.Text = nome1;
                lblIdadeMucilon.Text = nome1;

            }
            if (idade2 > idade1 && idade2 > idade3)
            {
                lblNomeMucilon.Text = nome2;
                lblIdadeMucilon.Text = nome2;

            }
            if (idade3 > idade2 && idade3 > idade1)
            {
                lblNomeMucilon.Text = nome3;
                lblIdadeMucilon.Text = nome3;

            }
            else if (idade1 == idade2 && idade1 == idade3)
            {
                lblNomeMucilon.Text = nome1+", "+nome2;
                lblIdadeMucilon.Text = "As idades são iguais, todos tem " + idade1 + " anos";
            }
           
            //Condicional de idades repetidas
            //if (idade1 == idade2)
            //{
            //    lblNomeMucilon.Text = nome1 + ", " + nome2;
            //    lblIdadeMucilon.Text = "As idades de"+nome1+"e "+nome2+" são iguais, porém "+nome3" + idade1 + " anos";
            //}
            //if(idade1 == idade3)
            //{


            //}
            //if(idade2 == idade1)
            //{

            //}
            //if(idade2 == idade3)
            //{

            //}
            //if(idade3 == idade1)
            //{

            //}
            //if (idade3 == idade2)
            //{

            //}
                
            

        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Exe005_Load(object sender, EventArgs e)
        {
            lblData.Text = DateTime.Now.ToString("dd/MM/yyyy");
            lblDia.Text = DateTime.Now.ToString("dddd").ToUpper();

            //hh (em caixa baixa) mostra o horário no formato de 12h
            lblHora.Text = DateTime.Now.ToString("HH:mm:ss");

        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            txtNome1.Text = "";
            txtNome2.Text = "";
            txtIdade1.Text = "";
            txtIdade2.Text = "";
            txtNome3.Text = "";
            txtIdade3.Text = "";
            idade1 = 0;
            idade2 = 0;
            idade3 = 0;


            lblNomeMucilon.Text = "";
            lblIdadeMucilon.Text = "";
            txtNome1.Focus();

        }

        private void TxtIdade1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 08) return;

            if(e.KeyChar < 48 || e.KeyChar > 57)
            {
                e.KeyChar = (char)0;
            }
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("HH:mm:ss");

        }
    }
}
