using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrjControleDiversos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void MonthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            lblHora.Text = DateTime.Now.ToString("HH:mm:ss");
            lblData.Text = DateTime.Now.ToString("dd/MM/yyyy");
            lblDia.Text = DateTime.Now.ToString("dddd").ToUpper();
            CboInstrucao.Items.Add("Ens. Fundamental Incompleto");
            CboInstrucao.Items.Add("Ens. Fundamental Completo");
            CboInstrucao.Items.Add("Ensino Médio Incompleto");
            CboInstrucao.Items.Add("Ensino Médio Completo");
            CboInstrucao.Items.Add("Ensino Superior Incompleto");
            CboInstrucao.Items.Add("Ensino Superior Completo");
            CboInstrucao.Items.Add("Pós Graduação");
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void CboInstrucao_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = (char)0;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            TxtNome.Text = "";
            DtpDataNascto.Text = DateTime.Now.ToString("dd/MM/yyyy");
            RdoRendaAte.Checked = true; CboInstrucao.Text = "Selecione...";
            ChkLer.Checked = false;
            ChkCaminhar.Checked = false;
            ChkViajar.Checked = false;
            ChkDancar.Checked = false;
            ChkNadar.Checked = false;
            ChkCantar.Checked = false;
            LstRespostas.Items.Clear();
            TxtNome.Focus();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            LstRespostas.Items.Clear();
            if (TxtNome.Text == "")
            {
                MessageBox.Show("Digite o nome!!", "Atenção");
                TxtNome.Focus();
                return;
            }
            LstRespostas.Items.Add(TxtNome.Text);
            //Verifica se dataNascimento >= DataAtual
            DateTime dataAtual = Convert.ToDateTime(lblData.Text);
            DateTime dataNascimento = Convert.ToDateTime(DtpDataNascto.Text);
            if (dataNascimento >= dataAtual)
            {
                MessageBox.Show("Data Nascimento incorreta!!!", "ATENÇÃO");
                DtpDataNascto.Focus();
                return;
            }
            LstRespostas.Items.Add(DtpDataNascto.Text); //ou --> .Value.Date);
                                                        //OBS: O evento keyPress do combo bloqueia a digitação de novas entradas
            if (CboInstrucao.Text == "Selecione...")
            {
                MessageBox.Show("Selecione o grau de instrução!!", "Atenção");
                CboInstrucao.Focus();
                return;
            }
            LstRespostas.Items.Add(CboInstrucao.Text);
            if (RdoRendaAte.Checked == true)
            {
                LstRespostas.Items.Add("Renda familiar até 5 salários mínimos");
            }
            else
            {
                LstRespostas.Items.Add("Renda familiar acima de 5 salários mínimos");
            }
            LstRespostas.Items.Add("Preferências Pessoais");
            if (ChkLer.Checked == true)
            {
                LstRespostas.Items.Add("Ler");
            }
            if (ChkCaminhar.Checked == true)
            {
                LstRespostas.Items.Add("Caminhar");
            }
            if (ChkViajar.Checked == true)
            {
                LstRespostas.Items.Add("Viajar");
            }
            if (ChkDancar.Checked == true)
            {
                LstRespostas.Items.Add("Dançar");
            }
            if (ChkNadar.Checked == true)
            {
                LstRespostas.Items.Add("Nadar");
            }
            if (ChkCantar.Checked == true)
            {
                LstRespostas.Items.Add("Cantar");
            }
        }

        private void GroupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void LblDia_Click(object sender, EventArgs e)
        {

        }

        private void LblData_Click(object sender, EventArgs e)
        {

        }

        private void LblHora_Click(object sender, EventArgs e)
        {

        }
    }
}
