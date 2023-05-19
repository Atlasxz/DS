using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrjHotel
{
    public partial class Form1 : Form
    {
        int totalDias;

        double valorDiaria,
            totalValorDiarias,
            valorDesconto,
            subTotal,
            totalServiços,
            totalPagar;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("HH:mm:ss");
            lblSemana.Text = DateTime.Now.ToString("dddd").ToUpper();
            mskSaida.Text = DateTime.Now.ToString("dd/MM/yyyy");
            rdoPagamentoVista.Checked = true;
            rdoTipoSimples.Checked = true;
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("HH:mm:ss");

        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime dataEntrada = Convert.ToDateTime(mskEntrada.Text);
                DateTime dataSaida = Convert.ToDateTime(mskSaida.Text);

                if (dataEntrada >= dataSaida)
                {
                    //MessageBox.Show("Atenção", "Insira um data válida");
                    throw new Exception("Atenção Insira um data válida");
                }
                //else
                // {
                totalDias = ((dataSaida).Subtract(dataEntrada)).Days;
                lblDias.Text = totalDias.ToString();

                if (rdoTipoSimples.Checked == true)
                {
                    valorDiaria = 150;
                }
                else
                {
                    valorDiaria = 280;
                }

                totalValorDiarias = totalDias * valorDiaria;


                if (cboServico1.Checked == false &&
                   cboServico2.Checked == false &&
                   cboServico3.Checked == false &&
                   cboServico4.Checked == false)
                {
                    totalServiços = 0;
                }
                if (cboServico1.Checked == true)
                {
                    totalServiços = 50;
                }
                if (cboServico2.Checked == true)
                {
                    totalServiços += 80;
                }
                if (cboServico3.Checked == true)
                {
                    totalServiços += 120;
                }
                if (cboServico4.Checked == true)
                {
                    totalServiços += 200;
                }
                if (rdoPagamentoVista.Checked == true)
                {
                totalValorDiarias = totalDias * valorDiaria;

                    valorDesconto = totalValorDiarias * 0.1;
                }
                else
                {
                    valorDesconto = 0;
                }

                subTotal = totalValorDiarias + totalServiços;
                totalPagar = subTotal - valorDesconto;


                lblValorDiarias.Text = totalValorDiarias.ToString("c2");
                lblDesconto.Text = valorDesconto.ToString("c2");
                lblSubtotal.Text = subTotal.ToString("c2");
                lblTotalServicos.Text = totalServiços.ToString("c2");
                lblTotal.Text = totalPagar.ToString("c2");

                //}
            }
            catch (Exception erro)
            {
                // MessageBox.Show("Insira um data válida", "Atenção");

                //return;
                MessageBox.Show("erro:" + erro.Message);
            }
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            rdoTipoSimples.Checked = true;
            rdoTipoDuplo.Checked = false;
            rdoPagamentoVista.Checked = true;
            rdoPagamentoParcelamento.Checked = false;
            cboServico1.Checked = false;
            cboServico2.Checked = false;
            cboServico3.Checked = false;
            cboServico4.Checked = false;

            lblValorDiarias.Text = "";
            lblDesconto.Text = "";
            lblTotalServicos.Text = "";
            lblSubtotal.Text = "";
            lblTotal.Text = "";
            lblDias.Text = "";
            mskEntrada.Text = "";

        }


    }
}
