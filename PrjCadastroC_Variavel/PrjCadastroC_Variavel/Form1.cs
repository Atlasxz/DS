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

        byte idade1, idade2;
        

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
            
            if ((txtIdade1.Text=="")   || 
               (txtIdade2.Text == "") || 
               (txtNome1.Text=="")    ||
               (txtNome2.Text==""))
            {
                MessageBox.Show("Campo Vazio!!", "Atente-se Imprudente");
                return;
            }

            idade1 = Convert.ToByte(txtIdade1.Text);
            idade2 = Convert.ToByte(txtIdade2.Text);

            if (idade1 <= 0 || idade1 >= 110)
            {
                MessageBox.Show("Verifique o valor da idade!!!", "Atente-se Imprudente");
                return;
            }

            if (idade1 < idade2)
            {
                lblNomeMucilon.Text = txtNome1.Text;
                lblIdadeMucilon.Text = txtIdade1.Text;

            }
            else if (idade1==idade2)
            {
                lblNomeMucilon.Text = txtNome1.Text+", "+txtNome2.Text;
                lblIdadeMucilon.Text = "As idades são iguais: "+txtIdade1.Text+", "+txtIdade2.Text;
            }
            else
            {
                lblNomeMucilon.Text = txtNome2.Text;
                lblIdadeMucilon.Text = txtIdade2.Text;
            }

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

        private void Timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("HH:mm:ss");

        }
    }
}
