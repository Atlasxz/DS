namespace PrjOperadores
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label5 = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnValidar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnPower = new System.Windows.Forms.Button();
            this.btnVezes = new System.Windows.Forms.Button();
            this.btnSub = new System.Windows.Forms.Button();
            this.btnDividir = new System.Windows.Forms.Button();
            this.btnSoma = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtV2 = new System.Windows.Forms.TextBox();
            this.txtV1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(317, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(189, 37);
            this.label5.TabIndex = 9;
            this.label5.Text = "Calculadora";
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.Snow;
            this.btnSair.Location = new System.Drawing.Point(529, 539);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(180, 72);
            this.btnSair.TabIndex = 8;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.ForeColor = System.Drawing.Color.Snow;
            this.btnLimpar.Location = new System.Drawing.Point(91, 539);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(180, 72);
            this.btnLimpar.TabIndex = 7;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.BackColor = System.Drawing.Color.Snow;
            this.lblResultado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblResultado.Location = new System.Drawing.Point(300, 167);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(347, 37);
            this.lblResultado.TabIndex = 7;
            this.lblResultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite o primeiro valor:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(294, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 26);
            this.label4.TabIndex = 6;
            // 
            // btnValidar
            // 
            this.btnValidar.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnValidar.ForeColor = System.Drawing.Color.Snow;
            this.btnValidar.Location = new System.Drawing.Point(453, 57);
            this.btnValidar.Name = "btnValidar";
            this.btnValidar.Size = new System.Drawing.Size(193, 86);
            this.btnValidar.TabIndex = 4;
            this.btnValidar.Text = "Validar Valores";
            this.btnValidar.UseVisualStyleBackColor = false;
            this.btnValidar.Click += new System.EventHandler(this.BtnValidar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(241, 26);
            this.label3.TabIndex = 5;
            this.label3.Text = "Resultado da Operação";
            // 
            // btnPower
            // 
            this.btnPower.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnPower.ForeColor = System.Drawing.Color.Snow;
            this.btnPower.Location = new System.Drawing.Point(485, 78);
            this.btnPower.Name = "btnPower";
            this.btnPower.Size = new System.Drawing.Size(130, 50);
            this.btnPower.TabIndex = 4;
            this.btnPower.Text = "Potência";
            this.btnPower.UseVisualStyleBackColor = false;
            this.btnPower.Click += new System.EventHandler(this.BtnPower_Click);
            // 
            // btnVezes
            // 
            this.btnVezes.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnVezes.ForeColor = System.Drawing.Color.Snow;
            this.btnVezes.Location = new System.Drawing.Point(222, 78);
            this.btnVezes.Name = "btnVezes";
            this.btnVezes.Size = new System.Drawing.Size(50, 50);
            this.btnVezes.TabIndex = 3;
            this.btnVezes.Text = "X";
            this.btnVezes.UseVisualStyleBackColor = false;
            this.btnVezes.Click += new System.EventHandler(this.BtnVezes_Click_1);
            // 
            // btnSub
            // 
            this.btnSub.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnSub.ForeColor = System.Drawing.Color.Snow;
            this.btnSub.Location = new System.Drawing.Point(110, 78);
            this.btnSub.Name = "btnSub";
            this.btnSub.Size = new System.Drawing.Size(50, 50);
            this.btnSub.TabIndex = 2;
            this.btnSub.Text = "-";
            this.btnSub.UseVisualStyleBackColor = false;
            this.btnSub.Click += new System.EventHandler(this.BtnSub_Click_1);
            // 
            // btnDividir
            // 
            this.btnDividir.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnDividir.ForeColor = System.Drawing.Color.Snow;
            this.btnDividir.Location = new System.Drawing.Point(166, 78);
            this.btnDividir.Name = "btnDividir";
            this.btnDividir.Size = new System.Drawing.Size(50, 50);
            this.btnDividir.TabIndex = 1;
            this.btnDividir.Text = "/";
            this.btnDividir.UseVisualStyleBackColor = false;
            this.btnDividir.Click += new System.EventHandler(this.BtnDividir_Click_1);
            // 
            // btnSoma
            // 
            this.btnSoma.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnSoma.ForeColor = System.Drawing.Color.Snow;
            this.btnSoma.Location = new System.Drawing.Point(54, 78);
            this.btnSoma.Name = "btnSoma";
            this.btnSoma.Size = new System.Drawing.Size(50, 50);
            this.btnSoma.TabIndex = 0;
            this.btnSoma.Text = "+";
            this.btnSoma.UseVisualStyleBackColor = false;
            this.btnSoma.Click += new System.EventHandler(this.BtnSoma_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Aquamarine;
            this.groupBox1.Controls.Add(this.txtV2);
            this.groupBox1.Controls.Add(this.txtV1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btnValidar);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(62, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(670, 186);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Valores:";
            // 
            // txtV2
            // 
            this.txtV2.Location = new System.Drawing.Point(273, 115);
            this.txtV2.Name = "txtV2";
            this.txtV2.Size = new System.Drawing.Size(147, 32);
            this.txtV2.TabIndex = 11;
            // 
            // txtV1
            // 
            this.txtV1.Location = new System.Drawing.Point(273, 61);
            this.txtV1.Name = "txtV1";
            this.txtV1.Size = new System.Drawing.Size(147, 32);
            this.txtV1.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(521, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Formulário 2 --->";
            this.label6.Click += new System.EventHandler(this.Label6_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(234, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Digite o segunda valor:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Aquamarine;
            this.groupBox2.Controls.Add(this.lblResultado);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.btnPower);
            this.groupBox2.Controls.Add(this.btnVezes);
            this.groupBox2.Controls.Add(this.btnSub);
            this.groupBox2.Controls.Add(this.btnDividir);
            this.groupBox2.Controls.Add(this.btnSoma);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(62, 290);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(670, 229);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Operadores Aritméticos";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(800, 693);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "Form1";
            this.Text = "Form2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnValidar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnPower;
        private System.Windows.Forms.Button btnVezes;
        private System.Windows.Forms.Button btnSub;
        private System.Windows.Forms.Button btnDividir;
        private System.Windows.Forms.Button btnSoma;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtV2;
        private System.Windows.Forms.TextBox txtV1;
    }
}