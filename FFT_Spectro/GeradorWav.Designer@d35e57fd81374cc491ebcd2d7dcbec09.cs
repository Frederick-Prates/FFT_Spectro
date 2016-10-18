namespace FFT_Spectro
{
    partial class GeradorWav
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.sourceList = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.bt_Play_Stop = new System.Windows.Forms.Button();
            this.bt_Abrir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.sourceList);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.WindowText;
            this.splitContainer1.Panel2.Controls.Add(this.groupBox3);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel2.Controls.Add(this.button4);
            this.splitContainer1.Panel2.Controls.Add(this.button1);
            this.splitContainer1.Size = new System.Drawing.Size(617, 300);
            this.splitContainer1.SplitterDistance = 203;
            this.splitContainer1.TabIndex = 0;
            // 
            // sourceList
            // 
            this.sourceList.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.sourceList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.sourceList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sourceList.Location = new System.Drawing.Point(0, 0);
            this.sourceList.MultiSelect = false;
            this.sourceList.Name = "sourceList";
            this.sourceList.Size = new System.Drawing.Size(203, 300);
            this.sourceList.TabIndex = 0;
            this.sourceList.UseCompatibleStateImageBehavior = false;
            this.sourceList.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Device";
            this.columnHeader1.Width = 138;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Channels";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button6);
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox2.Location = new System.Drawing.Point(3, 139);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(221, 73);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Gravar";
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button6.Location = new System.Drawing.Point(118, 16);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(97, 51);
            this.button6.TabIndex = 5;
            this.button6.Text = "Parar Gravação";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button5.Location = new System.Drawing.Point(6, 16);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(97, 51);
            this.button5.TabIndex = 4;
            this.button5.Text = "Gravar para Wave";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Location = new System.Drawing.Point(3, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(221, 74);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Teste Mic Aberto";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(6, 17);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 51);
            this.button2.TabIndex = 1;
            this.button2.Text = "Start";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.button3.Location = new System.Drawing.Point(118, 17);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(97, 51);
            this.button3.TabIndex = 2;
            this.button3.Text = "Stop";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(251, 112);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(129, 74);
            this.button4.TabIndex = 3;
            this.button4.Text = "Exit";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(3, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(221, 45);
            this.button1.TabIndex = 0;
            this.button1.Text = "Pesquisar Recursos";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.bt_Play_Stop);
            this.groupBox3.Controls.Add(this.bt_Abrir);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox3.Location = new System.Drawing.Point(3, 218);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(221, 73);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ouvir";
            // 
            // bt_Play_Stop
            // 
            this.bt_Play_Stop.BackColor = System.Drawing.SystemColors.HotTrack;
            this.bt_Play_Stop.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.bt_Play_Stop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Play_Stop.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bt_Play_Stop.Location = new System.Drawing.Point(118, 16);
            this.bt_Play_Stop.Name = "bt_Play_Stop";
            this.bt_Play_Stop.Size = new System.Drawing.Size(97, 51);
            this.bt_Play_Stop.TabIndex = 5;
            this.bt_Play_Stop.Text = "Play/Stop";
            this.bt_Play_Stop.UseVisualStyleBackColor = false;
            this.bt_Play_Stop.Click += new System.EventHandler(this.bt_Play_Stop_Click);
            // 
            // bt_Abrir
            // 
            this.bt_Abrir.BackColor = System.Drawing.SystemColors.HotTrack;
            this.bt_Abrir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.bt_Abrir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Abrir.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bt_Abrir.Location = new System.Drawing.Point(6, 16);
            this.bt_Abrir.Name = "bt_Abrir";
            this.bt_Abrir.Size = new System.Drawing.Size(97, 51);
            this.bt_Abrir.TabIndex = 4;
            this.bt_Abrir.Text = "Abrir";
            this.bt_Abrir.UseVisualStyleBackColor = false;
            this.bt_Abrir.Click += new System.EventHandler(this.bt_Abrir_Click);
            // 
            // GeradorWav
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(617, 300);
            this.Controls.Add(this.splitContainer1);
            this.Name = "GeradorWav";
            this.Text = "Audio Loopback";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        public System.Windows.Forms.ListView sourceList;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.Button button4;
        public System.Windows.Forms.Button button3;
        public System.Windows.Forms.Button button2;
        public System.Windows.Forms.Button button5;
        public System.Windows.Forms.Button button6;
        public System.Windows.Forms.Button bt_Play_Stop;
        public System.Windows.Forms.Button bt_Abrir;
    }
}

