namespace PrjControleDiversos
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
            this.lblHora = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.lblDia = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TxtNome = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DtpDataNascto = new System.Windows.Forms.DateTimePicker();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.CboInstrucao = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.RdoRendaAcima = new System.Windows.Forms.RadioButton();
            this.RdoRendaAte = new System.Windows.Forms.RadioButton();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.ChkCantar = new System.Windows.Forms.CheckBox();
            this.ChkNadar = new System.Windows.Forms.CheckBox();
            this.ChkDancar = new System.Windows.Forms.CheckBox();
            this.ChkViajar = new System.Windows.Forms.CheckBox();
            this.ChkCaminhar = new System.Windows.Forms.CheckBox();
            this.ChkLer = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.LstRespostas = new System.Windows.Forms.ListBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHora
            // 
            this.lblHora.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.Location = new System.Drawing.Point(13, 13);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(156, 62);
            this.lblHora.TabIndex = 0;
            this.lblHora.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblHora.Click += new System.EventHandler(this.LblHora_Click);
            // 
            // lblData
            // 
            this.lblData.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblData.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.Location = new System.Drawing.Point(210, 13);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(371, 62);
            this.lblData.TabIndex = 1;
            this.lblData.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblData.Click += new System.EventHandler(this.LblData_Click);
            // 
            // lblDia
            // 
            this.lblDia.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDia.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDia.Location = new System.Drawing.Point(631, 13);
            this.lblDia.Name = "lblDia";
            this.lblDia.Size = new System.Drawing.Size(156, 62);
            this.lblDia.TabIndex = 2;
            this.lblDia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblDia.Click += new System.EventHandler(this.LblDia_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(261, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(248, 37);
            this.label4.TabIndex = 3;
            this.label4.Text = "Dados Pessoais";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.groupBox1.Controls.Add(this.TxtNome);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 157);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(774, 77);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nome";
            // 
            // TxtNome
            // 
            this.TxtNome.Location = new System.Drawing.Point(18, 28);
            this.TxtNome.Name = "TxtNome";
            this.TxtNome.Size = new System.Drawing.Size(737, 29);
            this.TxtNome.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.groupBox2.Controls.Add(this.DtpDataNascto);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(13, 240);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(238, 113);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Data de Nascimento";
            // 
            // DtpDataNascto
            // 
            this.DtpDataNascto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpDataNascto.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpDataNascto.Location = new System.Drawing.Point(18, 48);
            this.DtpDataNascto.Name = "DtpDataNascto";
            this.DtpDataNascto.Size = new System.Drawing.Size(203, 29);
            this.DtpDataNascto.TabIndex = 0;
            this.DtpDataNascto.ValueChanged += new System.EventHandler(this.DateTimePicker1_ValueChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.groupBox3.Controls.Add(this.CboInstrucao);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(314, 240);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(454, 113);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Grau de Instituição";
            this.groupBox3.Enter += new System.EventHandler(this.GroupBox3_Enter);
            // 
            // CboInstrucao
            // 
            this.CboInstrucao.FormattingEnabled = true;
            this.CboInstrucao.Location = new System.Drawing.Point(16, 49);
            this.CboInstrucao.Name = "CboInstrucao";
            this.CboInstrucao.Size = new System.Drawing.Size(417, 32);
            this.CboInstrucao.TabIndex = 0;
            this.CboInstrucao.Text = "Selecione:";
            this.CboInstrucao.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            this.CboInstrucao.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CboInstrucao_KeyPress);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.groupBox4.Controls.Add(this.RdoRendaAcima);
            this.groupBox4.Controls.Add(this.RdoRendaAte);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(13, 371);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(238, 142);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Renda Familiar";
            // 
            // RdoRendaAcima
            // 
            this.RdoRendaAcima.AutoSize = true;
            this.RdoRendaAcima.Location = new System.Drawing.Point(18, 92);
            this.RdoRendaAcima.Name = "RdoRendaAcima";
            this.RdoRendaAcima.Size = new System.Drawing.Size(153, 28);
            this.RdoRendaAcima.TabIndex = 1;
            this.RdoRendaAcima.Text = "Acima de 5 sm";
            this.RdoRendaAcima.UseVisualStyleBackColor = true;
            // 
            // RdoRendaAte
            // 
            this.RdoRendaAte.AutoSize = true;
            this.RdoRendaAte.Checked = true;
            this.RdoRendaAte.Location = new System.Drawing.Point(18, 47);
            this.RdoRendaAte.Name = "RdoRendaAte";
            this.RdoRendaAte.Size = new System.Drawing.Size(101, 28);
            this.RdoRendaAte.TabIndex = 0;
            this.RdoRendaAte.TabStop = true;
            this.RdoRendaAte.Text = "Até 5 sm";
            this.RdoRendaAte.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.groupBox5.Controls.Add(this.ChkCantar);
            this.groupBox5.Controls.Add(this.ChkNadar);
            this.groupBox5.Controls.Add(this.ChkDancar);
            this.groupBox5.Controls.Add(this.ChkViajar);
            this.groupBox5.Controls.Add(this.ChkCaminhar);
            this.groupBox5.Controls.Add(this.ChkLer);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(314, 371);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(454, 142);
            this.groupBox5.TabIndex = 7;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Renda Familiar";
            // 
            // ChkCantar
            // 
            this.ChkCantar.AutoSize = true;
            this.ChkCantar.Location = new System.Drawing.Point(310, 93);
            this.ChkCantar.Name = "ChkCantar";
            this.ChkCantar.Size = new System.Drawing.Size(83, 28);
            this.ChkCantar.TabIndex = 5;
            this.ChkCantar.Text = "Cantar";
            this.ChkCantar.UseVisualStyleBackColor = true;
            // 
            // ChkNadar
            // 
            this.ChkNadar.AutoSize = true;
            this.ChkNadar.Location = new System.Drawing.Point(310, 48);
            this.ChkNadar.Name = "ChkNadar";
            this.ChkNadar.Size = new System.Drawing.Size(80, 28);
            this.ChkNadar.TabIndex = 4;
            this.ChkNadar.Text = "Nadar";
            this.ChkNadar.UseVisualStyleBackColor = true;
            // 
            // ChkDancar
            // 
            this.ChkDancar.AutoSize = true;
            this.ChkDancar.Location = new System.Drawing.Point(156, 93);
            this.ChkDancar.Name = "ChkDancar";
            this.ChkDancar.Size = new System.Drawing.Size(89, 28);
            this.ChkDancar.TabIndex = 3;
            this.ChkDancar.Text = "Dançar";
            this.ChkDancar.UseVisualStyleBackColor = true;
            // 
            // ChkViajar
            // 
            this.ChkViajar.AutoSize = true;
            this.ChkViajar.Location = new System.Drawing.Point(156, 48);
            this.ChkViajar.Name = "ChkViajar";
            this.ChkViajar.Size = new System.Drawing.Size(76, 28);
            this.ChkViajar.TabIndex = 2;
            this.ChkViajar.Text = "Viajar";
            this.ChkViajar.UseVisualStyleBackColor = true;
            // 
            // ChkCaminhar
            // 
            this.ChkCaminhar.AutoSize = true;
            this.ChkCaminhar.Location = new System.Drawing.Point(16, 92);
            this.ChkCaminhar.Name = "ChkCaminhar";
            this.ChkCaminhar.Size = new System.Drawing.Size(110, 28);
            this.ChkCaminhar.TabIndex = 1;
            this.ChkCaminhar.Text = "Caminhar";
            this.ChkCaminhar.UseVisualStyleBackColor = true;
            // 
            // ChkLer
            // 
            this.ChkLer.AutoSize = true;
            this.ChkLer.Location = new System.Drawing.Point(16, 47);
            this.ChkLer.Name = "ChkLer";
            this.ChkLer.Size = new System.Drawing.Size(56, 28);
            this.ChkLer.TabIndex = 0;
            this.ChkLer.Text = "Ler";
            this.ChkLer.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(608, 537);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 49);
            this.button1.TabIndex = 9;
            this.button1.Text = "Enviar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(608, 626);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(160, 49);
            this.button2.TabIndex = 10;
            this.button2.Text = "Limpar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(608, 713);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(160, 49);
            this.button3.TabIndex = 11;
            this.button3.Text = "Sair";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // LstRespostas
            // 
            this.LstRespostas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LstRespostas.FormattingEnabled = true;
            this.LstRespostas.ItemHeight = 20;
            this.LstRespostas.Location = new System.Drawing.Point(13, 537);
            this.LstRespostas.Name = "LstRespostas";
            this.LstRespostas.Size = new System.Drawing.Size(568, 224);
            this.LstRespostas.TabIndex = 12;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(814, 770);
            this.Controls.Add(this.LstRespostas);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblDia);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.lblHora);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblDia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TxtNome;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker DtpDataNascto;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox CboInstrucao;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton RdoRendaAcima;
        private System.Windows.Forms.RadioButton RdoRendaAte;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.CheckBox ChkCantar;
        private System.Windows.Forms.CheckBox ChkNadar;
        private System.Windows.Forms.CheckBox ChkDancar;
        private System.Windows.Forms.CheckBox ChkViajar;
        private System.Windows.Forms.CheckBox ChkCaminhar;
        private System.Windows.Forms.CheckBox ChkLer;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListBox LstRespostas;
        private System.Windows.Forms.Timer timer1;
    }
}

