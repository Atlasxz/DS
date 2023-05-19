namespace PrjOperadores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnValidar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnPower = new System.Windows.Forms.Button();
            this.btnVezes = new System.Windows.Forms.Button();
            this.btnSub = new System.Windows.Forms.Button();
            this.btnDividir = new System.Windows.Forms.Button();
            this.btnSoma = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtV1 = new System.Windows.Forms.NumericUpDown();
            this.txtV2 = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtV1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtV2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtV2);
            this.groupBox1.Controls.Add(this.txtV1);
            this.groupBox1.Controls.Add(this.btnValidar);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(18, 106);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(1005, 286);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Valores:";
            this.groupBox1.Enter += new System.EventHandler(this.GroupBox1_Enter);
            // 
            // btnValidar
            // 
            this.btnValidar.BackColor = System.Drawing.Color.RosyBrown;
            this.btnValidar.Location = new System.Drawing.Point(680, 87);
            this.btnValidar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnValidar.Name = "btnValidar";
            this.btnValidar.Size = new System.Drawing.Size(290, 132);
            this.btnValidar.TabIndex = 4;
            this.btnValidar.Text = "Validar Valores";
            this.btnValidar.UseVisualStyleBackColor = false;
            this.btnValidar.Click += new System.EventHandler(this.BtnValidar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 177);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(344, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "Digite o segunda valor:";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 94);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(337, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite o primeiro valor:";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblResultado);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.btnPower);
            this.groupBox2.Controls.Add(this.btnVezes);
            this.groupBox2.Controls.Add(this.btnSub);
            this.groupBox2.Controls.Add(this.btnDividir);
            this.groupBox2.Controls.Add(this.btnSoma);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(18, 457);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(1005, 352);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Operadores Aritméticos";
            this.groupBox2.Enter += new System.EventHandler(this.GroupBox2_Enter);
            // 
            // lblResultado
            // 
            this.lblResultado.BackColor = System.Drawing.Color.Snow;
            this.lblResultado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblResultado.Location = new System.Drawing.Point(450, 257);
            this.lblResultado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(520, 56);
            this.lblResultado.TabIndex = 7;
            this.lblResultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblResultado.Click += new System.EventHandler(this.LblResultado_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(441, 257);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 37);
            this.label4.TabIndex = 6;
            this.label4.Click += new System.EventHandler(this.Label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 257);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(355, 37);
            this.label3.TabIndex = 5;
            this.label3.Text = "Resultado da Operação";
            this.label3.Click += new System.EventHandler(this.Label3_Click);
            // 
            // btnPower
            // 
            this.btnPower.BackColor = System.Drawing.Color.RosyBrown;
            this.btnPower.Location = new System.Drawing.Point(728, 120);
            this.btnPower.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPower.Name = "btnPower";
            this.btnPower.Size = new System.Drawing.Size(195, 77);
            this.btnPower.TabIndex = 4;
            this.btnPower.Text = "Potência";
            this.btnPower.UseVisualStyleBackColor = false;
            this.btnPower.Click += new System.EventHandler(this.BtnPower_Click);
            // 
            // btnVezes
            // 
            this.btnVezes.BackColor = System.Drawing.Color.RosyBrown;
            this.btnVezes.Location = new System.Drawing.Point(333, 120);
            this.btnVezes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnVezes.Name = "btnVezes";
            this.btnVezes.Size = new System.Drawing.Size(75, 77);
            this.btnVezes.TabIndex = 3;
            this.btnVezes.Text = "X";
            this.btnVezes.UseVisualStyleBackColor = false;
            this.btnVezes.Click += new System.EventHandler(this.BtnVezes_Click);
            // 
            // btnSub
            // 
            this.btnSub.BackColor = System.Drawing.Color.RosyBrown;
            this.btnSub.Location = new System.Drawing.Point(165, 120);
            this.btnSub.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSub.Name = "btnSub";
            this.btnSub.Size = new System.Drawing.Size(75, 77);
            this.btnSub.TabIndex = 2;
            this.btnSub.Text = "-";
            this.btnSub.UseVisualStyleBackColor = false;
            this.btnSub.Click += new System.EventHandler(this.BtnSub_Click);
            // 
            // btnDividir
            // 
            this.btnDividir.BackColor = System.Drawing.Color.RosyBrown;
            this.btnDividir.Location = new System.Drawing.Point(249, 120);
            this.btnDividir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDividir.Name = "btnDividir";
            this.btnDividir.Size = new System.Drawing.Size(75, 77);
            this.btnDividir.TabIndex = 1;
            this.btnDividir.Text = "/";
            this.btnDividir.UseVisualStyleBackColor = false;
            this.btnDividir.Click += new System.EventHandler(this.BtnDividir_Click);
            // 
            // btnSoma
            // 
            this.btnSoma.BackColor = System.Drawing.Color.RosyBrown;
            this.btnSoma.Location = new System.Drawing.Point(81, 120);
            this.btnSoma.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSoma.Name = "btnSoma";
            this.btnSoma.Size = new System.Drawing.Size(75, 77);
            this.btnSoma.TabIndex = 0;
            this.btnSoma.Text = "+";
            this.btnSoma.UseVisualStyleBackColor = false;
            this.btnSoma.Click += new System.EventHandler(this.BtnSoma_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.RosyBrown;
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(62, 840);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(270, 111);
            this.btnLimpar.TabIndex = 2;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.Button1_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.RosyBrown;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(718, 840);
            this.btnSair.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(270, 111);
            this.btnSair.TabIndex = 3;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.Button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(400, 45);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(281, 55);
            this.label5.TabIndex = 4;
            this.label5.Text = "Calculadora";
            // 
            // txtV1
            // 
            this.txtV1.DecimalPlaces = 2;
            this.txtV1.Location = new System.Drawing.Point(409, 94);
            this.txtV1.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.txtV1.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.txtV1.Name = "txtV1";
            this.txtV1.Size = new System.Drawing.Size(223, 44);
            this.txtV1.TabIndex = 5;
            this.txtV1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtV1.ValueChanged += new System.EventHandler(this.TxtV1_ValueChanged);
            // 
            // txtV2
            // 
            this.txtV2.DecimalPlaces = 2;
            this.txtV2.Location = new System.Drawing.Point(409, 175);
            this.txtV2.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.txtV2.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.txtV2.Name = "txtV2";
            this.txtV2.Size = new System.Drawing.Size(223, 44);
            this.txtV2.TabIndex = 6;
            this.txtV2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(1041, 997);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Formulário - Calculadora";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtV1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtV2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnValidar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnPower;
        private System.Windows.Forms.Button btnVezes;
        private System.Windows.Forms.Button btnSub;
        private System.Windows.Forms.Button btnDividir;
        private System.Windows.Forms.Button btnSoma;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown txtV1;
        private System.Windows.Forms.NumericUpDown txtV2;
    }
}

