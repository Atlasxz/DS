namespace PrjCadastroC_Variavel
{
    partial class Exe005
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Exe005));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblIdadeMucilon = new System.Windows.Forms.Label();
            this.lblNomeMucilon = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnExibir = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtIdade2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNome2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtIdade1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNome1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.lblDia = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(189)))), ((int)(((byte)(139)))));
            this.panel1.Controls.Add(this.btnSair);
            this.panel1.Controls.Add(this.btnLimpar);
            this.panel1.Controls.Add(this.groupBox4);
            this.panel1.Controls.Add(this.btnExibir);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Location = new System.Drawing.Point(23, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(762, 808);
            this.panel1.TabIndex = 0;
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(119)))), ((int)(((byte)(68)))));
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(460, 745);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(239, 50);
            this.btnSair.TabIndex = 7;
            this.btnSair.Text = "SAIR";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(119)))), ((int)(((byte)(68)))));
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(63, 745);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(239, 50);
            this.btnLimpar.TabIndex = 6;
            this.btnLimpar.Text = "LIMPAR";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblIdadeMucilon);
            this.groupBox4.Controls.Add(this.lblNomeMucilon);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(9, 566);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(747, 173);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Resultado - Aluno Mais Novo";
            this.groupBox4.Enter += new System.EventHandler(this.GroupBox4_Enter);
            // 
            // lblIdadeMucilon
            // 
            this.lblIdadeMucilon.BackColor = System.Drawing.Color.White;
            this.lblIdadeMucilon.Location = new System.Drawing.Point(101, 113);
            this.lblIdadeMucilon.Name = "lblIdadeMucilon";
            this.lblIdadeMucilon.Size = new System.Drawing.Size(609, 35);
            this.lblIdadeMucilon.TabIndex = 4;
            // 
            // lblNomeMucilon
            // 
            this.lblNomeMucilon.BackColor = System.Drawing.Color.White;
            this.lblNomeMucilon.Location = new System.Drawing.Point(101, 43);
            this.lblNomeMucilon.Name = "lblNomeMucilon";
            this.lblNomeMucilon.Size = new System.Drawing.Size(609, 35);
            this.lblNomeMucilon.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Cursor = System.Windows.Forms.Cursors.Default;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label8.Location = new System.Drawing.Point(18, 113);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 26);
            this.label8.TabIndex = 2;
            this.label8.Text = "Idade";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label9.Location = new System.Drawing.Point(18, 43);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 26);
            this.label9.TabIndex = 0;
            this.label9.Text = "Nome:";
            this.label9.Click += new System.EventHandler(this.Label9_Click);
            // 
            // btnExibir
            // 
            this.btnExibir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(119)))), ((int)(((byte)(68)))));
            this.btnExibir.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExibir.Location = new System.Drawing.Point(207, 466);
            this.btnExibir.Name = "btnExibir";
            this.btnExibir.Size = new System.Drawing.Size(352, 65);
            this.btnExibir.TabIndex = 5;
            this.btnExibir.Text = "EXIBIR ALUNO MAIS NOVO";
            this.btnExibir.UseVisualStyleBackColor = false;
            this.btnExibir.Click += new System.EventHandler(this.BtnExibir_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtIdade2);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.txtNome2);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(9, 266);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(747, 173);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Segundo Aluno";
            // 
            // txtIdade2
            // 
            this.txtIdade2.Location = new System.Drawing.Point(101, 113);
            this.txtIdade2.Name = "txtIdade2";
            this.txtIdade2.Size = new System.Drawing.Size(66, 32);
            this.txtIdade2.TabIndex = 3;
            this.txtIdade2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtIdade1_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Cursor = System.Windows.Forms.Cursors.Default;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Location = new System.Drawing.Point(18, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 26);
            this.label6.TabIndex = 2;
            this.label6.Text = "Idade:";
            // 
            // txtNome2
            // 
            this.txtNome2.Location = new System.Drawing.Point(101, 43);
            this.txtNome2.Name = "txtNome2";
            this.txtNome2.Size = new System.Drawing.Size(640, 32);
            this.txtNome2.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Location = new System.Drawing.Point(18, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 26);
            this.label7.TabIndex = 0;
            this.label7.Text = "Nome:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtIdade1);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtNome1);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(9, 78);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(747, 173);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Primeiro Aluno";
            // 
            // txtIdade1
            // 
            this.txtIdade1.Location = new System.Drawing.Point(101, 113);
            this.txtIdade1.Name = "txtIdade1";
            this.txtIdade1.Size = new System.Drawing.Size(66, 32);
            this.txtIdade1.TabIndex = 3;
            this.txtIdade1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtIdade1_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Cursor = System.Windows.Forms.Cursors.Default;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Location = new System.Drawing.Point(18, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 26);
            this.label5.TabIndex = 2;
            this.label5.Text = "Idade:";
            // 
            // txtNome1
            // 
            this.txtNome1.Location = new System.Drawing.Point(101, 43);
            this.txtNome1.Name = "txtNome1";
            this.txtNome1.Size = new System.Drawing.Size(640, 32);
            this.txtNome1.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Location = new System.Drawing.Point(18, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 26);
            this.label4.TabIndex = 0;
            this.label4.Text = "Nome:";
            // 
            // lblData
            // 
            this.lblData.BackColor = System.Drawing.Color.White;
            this.lblData.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.Location = new System.Drawing.Point(6, 16);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(135, 34);
            this.lblData.TabIndex = 0;
            this.lblData.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDia
            // 
            this.lblDia.BackColor = System.Drawing.Color.White;
            this.lblDia.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDia.Location = new System.Drawing.Point(147, 16);
            this.lblDia.Name = "lblDia";
            this.lblDia.Size = new System.Drawing.Size(453, 34);
            this.lblDia.TabIndex = 1;
            this.lblDia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHora
            // 
            this.lblHora.BackColor = System.Drawing.Color.White;
            this.lblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.Location = new System.Drawing.Point(606, 16);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(135, 34);
            this.lblHora.TabIndex = 2;
            this.lblHora.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(32)))));
            this.groupBox1.Controls.Add(this.lblHora);
            this.groupBox1.Controls.Add(this.lblDia);
            this.groupBox1.Controls.Add(this.lblData);
            this.groupBox1.Location = new System.Drawing.Point(32, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(747, 57);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.GroupBox1_Enter);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // Exe005
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(237)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(812, 844);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Exe005";
            this.Text = "Exe005 - Trabalhando com Variáveis";
            this.Load += new System.EventHandler(this.Exe005_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnExibir;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtIdade2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNome2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtIdade1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNome1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblDia;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblIdadeMucilon;
        private System.Windows.Forms.Label lblNomeMucilon;
    }
}

