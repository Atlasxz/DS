namespace PrjHotel
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblSemana = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.mskSaida = new System.Windows.Forms.MaskedTextBox();
            this.mskEntrada = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoTipoDuplo = new System.Windows.Forms.RadioButton();
            this.rdoTipoSimples = new System.Windows.Forms.RadioButton();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.rdoPagamentoParcelamento = new System.Windows.Forms.RadioButton();
            this.rdoPagamentoVista = new System.Windows.Forms.RadioButton();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.lblDias = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.lblTotalServicos = new System.Windows.Forms.Label();
            this.lblValorDiarias = new System.Windows.Forms.Label();
            this.lblDesconto = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cboServico4 = new System.Windows.Forms.CheckBox();
            this.cboServico3 = new System.Windows.Forms.CheckBox();
            this.cboServico2 = new System.Windows.Forms.CheckBox();
            this.cboServico1 = new System.Windows.Forms.CheckBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSemana
            // 
            this.lblSemana.BackColor = System.Drawing.Color.AntiqueWhite;
            this.lblSemana.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSemana.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblSemana.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSemana.ForeColor = System.Drawing.Color.Black;
            this.lblSemana.Location = new System.Drawing.Point(9, 10);
            this.lblSemana.Name = "lblSemana";
            this.lblSemana.Size = new System.Drawing.Size(169, 48);
            this.lblSemana.TabIndex = 0;
            this.lblSemana.Text = "//";
            this.lblSemana.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.BackColor = System.Drawing.Color.AntiqueWhite;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(184, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(652, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "HOTEL MOSCABESSA - FECHAMENTO DE CONTA - CHECKOUT\r\n\r\n";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHora
            // 
            this.lblHora.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHora.BackColor = System.Drawing.Color.AntiqueWhite;
            this.lblHora.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblHora.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.ForeColor = System.Drawing.Color.Black;
            this.lblHora.Location = new System.Drawing.Point(842, 10);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(169, 48);
            this.lblHora.TabIndex = 2;
            this.lblHora.Text = "//";
            this.lblHora.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.BackColor = System.Drawing.Color.AntiqueWhite;
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.mskSaida);
            this.groupBox4.Controls.Add(this.mskEntrada);
            this.groupBox4.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.Black;
            this.groupBox4.Location = new System.Drawing.Point(791, 81);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(214, 110);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Datas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Saida:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Entrada:";
            // 
            // mskSaida
            // 
            this.mskSaida.Location = new System.Drawing.Point(98, 70);
            this.mskSaida.Mask = "00/00/0000";
            this.mskSaida.Name = "mskSaida";
            this.mskSaida.Size = new System.Drawing.Size(95, 29);
            this.mskSaida.TabIndex = 1;
            this.mskSaida.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mskSaida.ValidatingType = typeof(System.DateTime);
            // 
            // mskEntrada
            // 
            this.mskEntrada.Location = new System.Drawing.Point(98, 38);
            this.mskEntrada.Mask = "00/00/0000";
            this.mskEntrada.Name = "mskEntrada";
            this.mskEntrada.Size = new System.Drawing.Size(95, 29);
            this.mskEntrada.TabIndex = 0;
            this.mskEntrada.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mskEntrada.ValidatingType = typeof(System.DateTime);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.groupBox1.Controls.Add(this.rdoTipoDuplo);
            this.groupBox1.Controls.Add(this.rdoTipoSimples);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(9, 81);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(214, 110);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo de quarto:";
            // 
            // rdoTipoDuplo
            // 
            this.rdoTipoDuplo.AutoSize = true;
            this.rdoTipoDuplo.Location = new System.Drawing.Point(18, 69);
            this.rdoTipoDuplo.Name = "rdoTipoDuplo";
            this.rdoTipoDuplo.Size = new System.Drawing.Size(156, 25);
            this.rdoTipoDuplo.TabIndex = 1;
            this.rdoTipoDuplo.Text = "Duplo   - R$ 280,00";
            this.rdoTipoDuplo.UseVisualStyleBackColor = true;
            // 
            // rdoTipoSimples
            // 
            this.rdoTipoSimples.AutoSize = true;
            this.rdoTipoSimples.Location = new System.Drawing.Point(18, 38);
            this.rdoTipoSimples.Name = "rdoTipoSimples";
            this.rdoTipoSimples.Size = new System.Drawing.Size(155, 25);
            this.rdoTipoSimples.TabIndex = 0;
            this.rdoTipoSimples.Text = "Simples - R$ 150,00";
            this.rdoTipoSimples.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox5.BackColor = System.Drawing.Color.AntiqueWhite;
            this.groupBox5.Controls.Add(this.rdoPagamentoParcelamento);
            this.groupBox5.Controls.Add(this.rdoPagamentoVista);
            this.groupBox5.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.ForeColor = System.Drawing.Color.Black;
            this.groupBox5.Location = new System.Drawing.Point(9, 197);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(406, 102);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Forma de Pagamento";
            // 
            // rdoPagamentoParcelamento
            // 
            this.rdoPagamentoParcelamento.AutoSize = true;
            this.rdoPagamentoParcelamento.Location = new System.Drawing.Point(254, 49);
            this.rdoPagamentoParcelamento.Name = "rdoPagamentoParcelamento";
            this.rdoPagamentoParcelamento.Size = new System.Drawing.Size(93, 25);
            this.rdoPagamentoParcelamento.TabIndex = 3;
            this.rdoPagamentoParcelamento.TabStop = true;
            this.rdoPagamentoParcelamento.Text = "Parcelado";
            this.rdoPagamentoParcelamento.UseVisualStyleBackColor = true;
            // 
            // rdoPagamentoVista
            // 
            this.rdoPagamentoVista.AutoSize = true;
            this.rdoPagamentoVista.Location = new System.Drawing.Point(16, 49);
            this.rdoPagamentoVista.Name = "rdoPagamentoVista";
            this.rdoPagamentoVista.Size = new System.Drawing.Size(204, 25);
            this.rdoPagamentoVista.TabIndex = 2;
            this.rdoPagamentoVista.TabStop = true;
            this.rdoPagamentoVista.Text = "A Vista - 10% de Desconto";
            this.rdoPagamentoVista.UseVisualStyleBackColor = true;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCalcular.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCalcular.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCalcular.Location = new System.Drawing.Point(476, 211);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(243, 78);
            this.btnCalcular.TabIndex = 5;
            this.btnCalcular.Text = "CALCULAR";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.BtnCalcular_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox6.BackColor = System.Drawing.Color.AntiqueWhite;
            this.groupBox6.Controls.Add(this.lblDias);
            this.groupBox6.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.ForeColor = System.Drawing.Color.Black;
            this.groupBox6.Location = new System.Drawing.Point(791, 197);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(214, 102);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Total de Dias Hospedados:";
            // 
            // lblDias
            // 
            this.lblDias.BackColor = System.Drawing.Color.FloralWhite;
            this.lblDias.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDias.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDias.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblDias.Location = new System.Drawing.Point(61, 34);
            this.lblDias.Name = "lblDias";
            this.lblDias.Size = new System.Drawing.Size(90, 49);
            this.lblDias.TabIndex = 0;
            this.lblDias.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox7
            // 
            this.groupBox7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox7.BackColor = System.Drawing.Color.AntiqueWhite;
            this.groupBox7.Controls.Add(this.lblTotalServicos);
            this.groupBox7.Controls.Add(this.lblValorDiarias);
            this.groupBox7.Controls.Add(this.lblDesconto);
            this.groupBox7.Controls.Add(this.lblSubtotal);
            this.groupBox7.Controls.Add(this.label14);
            this.groupBox7.Controls.Add(this.lblTotal);
            this.groupBox7.Controls.Add(this.label11);
            this.groupBox7.Controls.Add(this.label9);
            this.groupBox7.Controls.Add(this.label8);
            this.groupBox7.Controls.Add(this.label5);
            this.groupBox7.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox7.ForeColor = System.Drawing.Color.Black;
            this.groupBox7.Location = new System.Drawing.Point(9, 314);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(996, 140);
            this.groupBox7.TabIndex = 5;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Dados Completos:";
            // 
            // lblTotalServicos
            // 
            this.lblTotalServicos.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.lblTotalServicos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotalServicos.Location = new System.Drawing.Point(139, 90);
            this.lblTotalServicos.Name = "lblTotalServicos";
            this.lblTotalServicos.Size = new System.Drawing.Size(165, 25);
            this.lblTotalServicos.TabIndex = 16;
            // 
            // lblValorDiarias
            // 
            this.lblValorDiarias.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.lblValorDiarias.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblValorDiarias.Location = new System.Drawing.Point(139, 49);
            this.lblValorDiarias.Name = "lblValorDiarias";
            this.lblValorDiarias.Size = new System.Drawing.Size(165, 25);
            this.lblValorDiarias.TabIndex = 15;
            // 
            // lblDesconto
            // 
            this.lblDesconto.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.lblDesconto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDesconto.Location = new System.Drawing.Point(447, 50);
            this.lblDesconto.Name = "lblDesconto";
            this.lblDesconto.Size = new System.Drawing.Size(165, 25);
            this.lblDesconto.TabIndex = 14;
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.lblSubtotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSubtotal.Location = new System.Drawing.Point(782, 49);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(165, 25);
            this.lblSubtotal.TabIndex = 13;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(710, 49);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(66, 21);
            this.label14.TabIndex = 12;
            this.label14.Text = "SubTotal";
            // 
            // lblTotal
            // 
            this.lblTotal.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotal.Location = new System.Drawing.Point(509, 90);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(165, 34);
            this.lblTotal.TabIndex = 11;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Light", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(341, 90);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(162, 30);
            this.label11.TabIndex = 10;
            this.label11.Text = "Valor de Diárias:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(363, 51);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 21);
            this.label9.TabIndex = 8;
            this.label9.Text = "Desconto:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 89);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(123, 21);
            this.label8.TabIndex = 6;
            this.label8.Text = "Total de Serviços:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "Valor de Diárias:";
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLimpar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLimpar.Location = new System.Drawing.Point(229, 472);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(206, 63);
            this.btnLimpar.TabIndex = 6;
            this.btnLimpar.Text = "LIMPAR";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSair.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSair.Location = new System.Drawing.Point(579, 472);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(206, 63);
            this.btnSair.TabIndex = 7;
            this.btnSair.Text = "SAIR";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.BackColor = System.Drawing.Color.AntiqueWhite;
            this.groupBox2.Controls.Add(this.cboServico4);
            this.groupBox2.Controls.Add(this.cboServico3);
            this.groupBox2.Controls.Add(this.cboServico2);
            this.groupBox2.Controls.Add(this.cboServico1);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(229, 81);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(556, 110);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Serviços Utilizados";
            // 
            // cboServico4
            // 
            this.cboServico4.AutoSize = true;
            this.cboServico4.Location = new System.Drawing.Point(350, 67);
            this.cboServico4.Name = "cboServico4";
            this.cboServico4.Size = new System.Drawing.Size(168, 25);
            this.cboServico4.TabIndex = 3;
            this.cboServico4.Text = "Serviço 4 - R$ 200,00";
            this.cboServico4.UseVisualStyleBackColor = true;
            // 
            // cboServico3
            // 
            this.cboServico3.AutoSize = true;
            this.cboServico3.Location = new System.Drawing.Point(350, 39);
            this.cboServico3.Name = "cboServico3";
            this.cboServico3.Size = new System.Drawing.Size(166, 25);
            this.cboServico3.TabIndex = 2;
            this.cboServico3.Text = "Serviço 3 - R$ 120,00";
            this.cboServico3.UseVisualStyleBackColor = true;
            // 
            // cboServico2
            // 
            this.cboServico2.AutoSize = true;
            this.cboServico2.Location = new System.Drawing.Point(29, 69);
            this.cboServico2.Name = "cboServico2";
            this.cboServico2.Size = new System.Drawing.Size(160, 25);
            this.cboServico2.TabIndex = 1;
            this.cboServico2.Text = "Serviço 2 - R$ 80,00";
            this.cboServico2.UseVisualStyleBackColor = true;
            // 
            // cboServico1
            // 
            this.cboServico1.AutoSize = true;
            this.cboServico1.Location = new System.Drawing.Point(29, 41);
            this.cboServico1.Name = "cboServico1";
            this.cboServico1.Size = new System.Drawing.Size(158, 25);
            this.cboServico1.TabIndex = 0;
            this.cboServico1.Text = "Serviço 1 - R$ 50,00";
            this.cboServico1.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PrjHotel.Properties.Resources.claude_monet___impression_sunrise____meisterdrucke_22436__compressed;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1023, 565);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblSemana);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.MinimumSize = new System.Drawing.Size(1039, 604);
            this.Name = "Form1";
            this.Text = "Calculadora de Diárias - Hotel";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblSemana;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.RadioButton rdoTipoDuplo;
        private System.Windows.Forms.RadioButton rdoTipoSimples;
        private System.Windows.Forms.MaskedTextBox mskSaida;
        private System.Windows.Forms.MaskedTextBox mskEntrada;
        private System.Windows.Forms.RadioButton rdoPagamentoParcelamento;
        private System.Windows.Forms.RadioButton rdoPagamentoVista;
        private System.Windows.Forms.Label lblDias;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox cboServico4;
        private System.Windows.Forms.CheckBox cboServico3;
        private System.Windows.Forms.CheckBox cboServico2;
        private System.Windows.Forms.CheckBox cboServico1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblTotalServicos;
        private System.Windows.Forms.Label lblValorDiarias;
        private System.Windows.Forms.Label lblDesconto;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Timer timer1;
    }
}

