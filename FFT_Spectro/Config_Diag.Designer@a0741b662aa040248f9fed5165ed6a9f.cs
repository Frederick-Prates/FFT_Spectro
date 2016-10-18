namespace FFT_Spectro
{
    partial class Config_Diag
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
            this.txt_TamArq = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_N = new System.Windows.Forms.TextBox();
            this.bt_Conf = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Bit = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_FA = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Cam = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rb_Bar = new System.Windows.Forms.RadioButton();
            this.rb_PS = new System.Windows.Forms.RadioButton();
            this.rb_Pon = new System.Windows.Forms.RadioButton();
            this.rb_PR = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_OSet = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_TamArq
            // 
            this.txt_TamArq.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_TamArq.Location = new System.Drawing.Point(24, 61);
            this.txt_TamArq.Name = "txt_TamArq";
            this.txt_TamArq.Size = new System.Drawing.Size(90, 20);
            this.txt_TamArq.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.label1.Location = new System.Drawing.Point(10, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tamanho do vetor .wav:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txt_OSet);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_N);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.groupBox1.Location = new System.Drawing.Point(2, 120);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(253, 139);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Modificaveis";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(13, 102);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(191, 17);
            this.checkBox1.TabIndex = 11;
            this.checkBox1.Text = "Plotar vetor de Amostras  no tempo";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.label6.Location = new System.Drawing.Point(6, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(178, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "n é inteiro positivo de 9 à 14. N=2^n";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.label5.Location = new System.Drawing.Point(34, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "n = ";
            // 
            // txt_N
            // 
            this.txt_N.Location = new System.Drawing.Point(67, 32);
            this.txt_N.Name = "txt_N";
            this.txt_N.Size = new System.Drawing.Size(90, 20);
            this.txt_N.TabIndex = 8;
            this.txt_N.TextChanged += new System.EventHandler(this.txt_N_TextChanged);
            // 
            // bt_Conf
            // 
            this.bt_Conf.BackColor = System.Drawing.SystemColors.HotTrack;
            this.bt_Conf.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.bt_Conf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Conf.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bt_Conf.Location = new System.Drawing.Point(450, 62);
            this.bt_Conf.Name = "bt_Conf";
            this.bt_Conf.Size = new System.Drawing.Size(124, 124);
            this.bt_Conf.TabIndex = 11;
            this.bt_Conf.Text = "Confirmar";
            this.bt_Conf.UseVisualStyleBackColor = false;
            this.bt_Conf.Click += new System.EventHandler(this.bt_Conf_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txt_Bit);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txt_FA);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txt_Cam);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txt_TamArq);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.groupBox2.Location = new System.Drawing.Point(2, 1);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(413, 100);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Arquivo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.label4.Location = new System.Drawing.Point(313, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Bit depth:";
            // 
            // txt_Bit
            // 
            this.txt_Bit.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_Bit.Location = new System.Drawing.Point(294, 61);
            this.txt_Bit.Name = "txt_Bit";
            this.txt_Bit.Size = new System.Drawing.Size(90, 20);
            this.txt_Bit.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.label3.Location = new System.Drawing.Point(160, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Freq Amostragem(Hz)";
            // 
            // txt_FA
            // 
            this.txt_FA.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_FA.Location = new System.Drawing.Point(163, 61);
            this.txt_FA.Name = "txt_FA";
            this.txt_FA.Size = new System.Drawing.Size(90, 20);
            this.txt_FA.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.label2.Location = new System.Drawing.Point(10, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Caminho:";
            // 
            // txt_Cam
            // 
            this.txt_Cam.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_Cam.Location = new System.Drawing.Point(67, 13);
            this.txt_Cam.Name = "txt_Cam";
            this.txt_Cam.Size = new System.Drawing.Size(340, 20);
            this.txt_Cam.TabIndex = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.WindowText;
            this.groupBox3.Controls.Add(this.rb_Bar);
            this.groupBox3.Controls.Add(this.rb_PS);
            this.groupBox3.Controls.Add(this.rb_Pon);
            this.groupBox3.Controls.Add(this.rb_PR);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.groupBox3.Location = new System.Drawing.Point(272, 120);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(143, 139);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Estilo do Gráfico";
            // 
            // rb_Bar
            // 
            this.rb_Bar.AutoSize = true;
            this.rb_Bar.Location = new System.Drawing.Point(24, 31);
            this.rb_Bar.Name = "rb_Bar";
            this.rb_Bar.Size = new System.Drawing.Size(55, 17);
            this.rb_Bar.TabIndex = 4;
            this.rb_Bar.TabStop = true;
            this.rb_Bar.Text = "Barras";
            this.rb_Bar.UseVisualStyleBackColor = true;
            // 
            // rb_PS
            // 
            this.rb_PS.AutoSize = true;
            this.rb_PS.Location = new System.Drawing.Point(24, 100);
            this.rb_PS.Name = "rb_PS";
            this.rb_PS.Size = new System.Drawing.Size(94, 17);
            this.rb_PS.TabIndex = 7;
            this.rb_PS.TabStop = true;
            this.rb_PS.Text = "Ponto + Spline";
            this.rb_PS.UseVisualStyleBackColor = true;
            // 
            // rb_Pon
            // 
            this.rb_Pon.AutoSize = true;
            this.rb_Pon.Location = new System.Drawing.Point(24, 54);
            this.rb_Pon.Name = "rb_Pon";
            this.rb_Pon.Size = new System.Drawing.Size(58, 17);
            this.rb_Pon.TabIndex = 5;
            this.rb_Pon.TabStop = true;
            this.rb_Pon.Text = "Pontos";
            this.rb_Pon.UseVisualStyleBackColor = true;
            // 
            // rb_PR
            // 
            this.rb_PR.AutoSize = true;
            this.rb_PR.Location = new System.Drawing.Point(24, 77);
            this.rb_PR.Name = "rb_PR";
            this.rb_PR.Size = new System.Drawing.Size(88, 17);
            this.rb_PR.TabIndex = 6;
            this.rb_PR.TabStop = true;
            this.rb_PR.Text = "Ponto + Reta";
            this.rb_PR.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.label7.Location = new System.Drawing.Point(14, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Offset = ";
            // 
            // txt_OSet
            // 
            this.txt_OSet.Location = new System.Drawing.Point(67, 62);
            this.txt_OSet.Name = "txt_OSet";
            this.txt_OSet.Size = new System.Drawing.Size(90, 20);
            this.txt_OSet.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.label8.Location = new System.Drawing.Point(160, 67);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "(Inicio da Janela)";
            // 
            // Config_Diag
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(604, 261);
            this.Controls.Add(this.bt_Conf);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Config_Diag";
            this.Text = "Configuração FFT";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_N;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bt_Conf;
        public System.Windows.Forms.TextBox txt_TamArq;
        public System.Windows.Forms.TextBox txt_Cam;
        public System.Windows.Forms.TextBox txt_Bit;
        public System.Windows.Forms.TextBox txt_FA;
        private System.Windows.Forms.GroupBox groupBox3;
        public System.Windows.Forms.RadioButton rb_Bar;
        public System.Windows.Forms.RadioButton rb_PS;
        public System.Windows.Forms.RadioButton rb_Pon;
        public System.Windows.Forms.RadioButton rb_PR;
        public System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_OSet;
        private System.Windows.Forms.Label label8;
    }
}