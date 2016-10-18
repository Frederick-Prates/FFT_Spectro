namespace FFT_Spectro
{
    partial class Spec_FFT
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Spec_FFT));
            this.bt_Abrir = new System.Windows.Forms.Button();
            this.bt_GerarFFT = new System.Windows.Forms.Button();
            this.bt_CriarWav = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bt_Limpar = new System.Windows.Forms.Button();
            this.Entrada = new System.Windows.Forms.GroupBox();
            this.bt_CFG_wav = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.Entrada.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_Abrir
            // 
            this.bt_Abrir.BackColor = System.Drawing.SystemColors.HotTrack;
            this.bt_Abrir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.bt_Abrir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Abrir.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bt_Abrir.Location = new System.Drawing.Point(99, 19);
            this.bt_Abrir.Name = "bt_Abrir";
            this.bt_Abrir.Size = new System.Drawing.Size(90, 75);
            this.bt_Abrir.TabIndex = 0;
            this.bt_Abrir.Text = "Abrir";
            this.bt_Abrir.UseVisualStyleBackColor = false;
            this.bt_Abrir.Click += new System.EventHandler(this.bt_Abrir_Click);
            // 
            // bt_GerarFFT
            // 
            this.bt_GerarFFT.BackColor = System.Drawing.SystemColors.HotTrack;
            this.bt_GerarFFT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.bt_GerarFFT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_GerarFFT.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bt_GerarFFT.Location = new System.Drawing.Point(6, 19);
            this.bt_GerarFFT.Name = "bt_GerarFFT";
            this.bt_GerarFFT.Size = new System.Drawing.Size(90, 75);
            this.bt_GerarFFT.TabIndex = 1;
            this.bt_GerarFFT.Text = "Gerar FFT";
            this.bt_GerarFFT.UseVisualStyleBackColor = false;
            this.bt_GerarFFT.Click += new System.EventHandler(this.bt_Gerar_Click);
            // 
            // bt_CriarWav
            // 
            this.bt_CriarWav.BackColor = System.Drawing.SystemColors.HotTrack;
            this.bt_CriarWav.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.bt_CriarWav.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_CriarWav.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bt_CriarWav.Location = new System.Drawing.Point(6, 19);
            this.bt_CriarWav.Name = "bt_CriarWav";
            this.bt_CriarWav.Size = new System.Drawing.Size(90, 75);
            this.bt_CriarWav.TabIndex = 2;
            this.bt_CriarWav.Text = "Criar .wav";
            this.bt_CriarWav.UseVisualStyleBackColor = false;
            this.bt_CriarWav.Click += new System.EventHandler(this.bt_CriarWav_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(2, 6);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel1.Controls.Add(this.Entrada);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.chart1);
            this.splitContainer1.Size = new System.Drawing.Size(867, 308);
            this.splitContainer1.SplitterDistance = 211;
            this.splitContainer1.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bt_GerarFFT);
            this.groupBox2.Controls.Add(this.bt_Limpar);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox2.Location = new System.Drawing.Point(3, 195);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(195, 107);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Saida";
            // 
            // bt_Limpar
            // 
            this.bt_Limpar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.bt_Limpar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.bt_Limpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Limpar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bt_Limpar.Location = new System.Drawing.Point(99, 19);
            this.bt_Limpar.Name = "bt_Limpar";
            this.bt_Limpar.Size = new System.Drawing.Size(90, 75);
            this.bt_Limpar.TabIndex = 3;
            this.bt_Limpar.Text = "Limpar";
            this.bt_Limpar.UseVisualStyleBackColor = false;
            this.bt_Limpar.Click += new System.EventHandler(this.bt_Limpar_Click);
            // 
            // Entrada
            // 
            this.Entrada.Controls.Add(this.bt_CFG_wav);
            this.Entrada.Controls.Add(this.bt_CriarWav);
            this.Entrada.Controls.Add(this.bt_Abrir);
            this.Entrada.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Entrada.Location = new System.Drawing.Point(3, 6);
            this.Entrada.Name = "Entrada";
            this.Entrada.Size = new System.Drawing.Size(195, 183);
            this.Entrada.TabIndex = 4;
            this.Entrada.TabStop = false;
            this.Entrada.Text = "Entrada";
            // 
            // bt_CFG_wav
            // 
            this.bt_CFG_wav.BackColor = System.Drawing.SystemColors.HotTrack;
            this.bt_CFG_wav.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.bt_CFG_wav.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_CFG_wav.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bt_CFG_wav.Location = new System.Drawing.Point(6, 100);
            this.bt_CFG_wav.Name = "bt_CFG_wav";
            this.bt_CFG_wav.Size = new System.Drawing.Size(183, 75);
            this.bt_CFG_wav.TabIndex = 3;
            this.bt_CFG_wav.Text = "Configurações";
            this.bt_CFG_wav.UseVisualStyleBackColor = false;
            this.bt_CFG_wav.Click += new System.EventHandler(this.bt_CFG_wav_Click);
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.RoyalBlue;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.ForeColor = System.Drawing.Color.Silver;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(3, 3);
            this.chart1.Margin = new System.Windows.Forms.Padding(2);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Grayscale;
            series1.ChartArea = "ChartArea1";
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series2.IsVisibleInLegend = false;
            series2.Legend = "Legend1";
            series2.Name = "Series2";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.IsVisibleInLegend = false;
            series3.Legend = "Legend1";
            series3.Name = "Series3";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series4.IsVisibleInLegend = false;
            series4.Legend = "Legend1";
            series4.Name = "Series4";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Series.Add(series3);
            this.chart1.Series.Add(series4);
            this.chart1.Size = new System.Drawing.Size(647, 299);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // Spec_FFT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(871, 316);
            this.Controls.Add(this.splitContainer1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Spec_FFT";
            this.Text = "PDS - FFT - Frederick Prates e Marcos Siqueira";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.Entrada.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_Abrir;
        private System.Windows.Forms.Button bt_GerarFFT;
        private System.Windows.Forms.Button bt_CriarWav;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button bt_Limpar;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox Entrada;
        private System.Windows.Forms.Button bt_CFG_wav;
    }
}

