using System;
using System.Drawing;
using System.Windows.Forms;
using AForge.Math;

namespace FFT_Spectro
{
    [Serializable()]
    public partial class Spec_FFT : Form
    {
        // Janelas de Dialogo
        private Config_Diag cfg_dg;
        private GeradorWav ger_wav;
        private Amostrado_Graf amo_graf;
        //

        public Spec_FFT()
        {
            InitializeComponent();
            __GrafConfig();
        }

        // Variaveis globais
        OpenFileDialog open;
        NAudio.Wave.WaveFileReader reader;
        short[] sample;
        Complex[] tmpComplexArray;
        int _reader_freq;
        int _reader_bit;
        long tam_arq_vetor;
        // 

        // Função que plota o grafico do vetor de amostras
        public void graph_t_amostrado(short[] sample_t)
        {
            amo_graf = new Amostrado_Graf();
            amo_graf.chart1.Series["Series1"].Points.Clear();
            for(int i = 0; i < sample_t.Length; i++)
            {
                amo_graf.chart1.Series["Series1"].Points.AddXY(i, sample_t[i]);
            }
            amo_graf.Show();
        }

        // Calcula FFT e plota o gráfico
        public void analise()
        {
            // Lê o arquivo .wav que está em reader e transfere para o buffer 
            byte[] buffer = new byte[reader.Length];
            reader.Read(buffer, 0, buffer.Length);
            // Cria o vetor de amostras
            sample = new short[reader.Length];
            
            // Faz a conversão de buffer de byte para inteiro de 16bit(short) e armazena
            // no vetor de amostras.
            // Observar que grava em amostra a cada 2 saltos de posição.
            for (int n = 0; n < buffer.Length; n += 2)
            {
                sample[n] = BitConverter.ToInt16(buffer, n);
            }
            // Plota o grafico deste vetor de amostra em função do tempo
            if(cfg_dg.checkBox1.Checked) graph_t_amostrado(sample);

            // Faz a adaptação de inteiro para complexo. Ex 15 => 15 + 0i
            // E armazena em um vetor complexo que servirá de entrada
            // para a FFT.
            Complex[] complexData = new Complex[sample.Length];
            for (int i = 0; i < complexData.Length; i++)
            {
                Complex tmp = new Complex(sample[i], 0);
                complexData[i] = tmp;
            }
            //MessageBox.Show("Arquivo: " + reader.Length + "\nAmostras: " + sample.Length);
            //Pega a offset+N(cfg_dg.nzao)-1 amostras que é definida pelo usuario
            // atraves das configurações. Obrigatoriamente potencia de 2.
            tmpComplexArray = new Complex[cfg_dg.nzao];
            for (int i = cfg_dg.offset, j = 0; i < cfg_dg.nzao; i++,j++)
            {
                Complex a = new Complex(complexData[i]);
                tmpComplexArray[j] = a;
            }
            //run FFT - Verificar FFT_Aforge.cs para codigo do FFT
            FourierTransform.FFT(tmpComplexArray, FourierTransform.Direction.Forward);

            // Plota graficos de saida da FFT
            // Pega-se a magnitude do num complexo e calcula 20log10(Mag) para obter ganho
            // em dB.
            // Para a frequencia captura-se a frequencia de amostragem (Supor FA = 44100 Hz)
            // do arquivo.wav e captura o valor de N (aquele que tem que ser potencia de 2). 
            // Supondo que N = 1024 (ou 2^10), então os valores da frequencia em Hz são  
            // calculados da seguinte maneira:
            // i * FA/N
            // 0 * 44100/1024 = 0Hz
            // 1 * 44100/1024 = 43.1Hz
            // .
            // .
            // 511 * 44100/1024 = 22006.9 Hz
            // 512 * 44100/1024 = 22050 Hz  Particularidade: Representa a frequencia de Nyquist (FA/2)
            // .
            // 1023 * 44100/1024 = 44056,9 Hz Ultimo.
            double freq_para_hertz;
            double mag_para_dB;
            for (int i = 0; i < tmpComplexArray.Length; i++)
            {
                freq_para_hertz = ((double)i * (double)_reader_freq / (double)cfg_dg.nzao);
                mag_para_dB = 20 * Math.Log10(tmpComplexArray[i].Magnitude);

                if (cfg_dg.rb_Bar.Checked)
                    chart1.Series["Series1"].Points.AddXY(freq_para_hertz, mag_para_dB);
                if (cfg_dg.rb_Pon.Checked)
                    chart1.Series["Series2"].Points.AddXY(freq_para_hertz, mag_para_dB);
                if (cfg_dg.rb_PR.Checked)
                {
                    chart1.Series["Series2"].Points.AddXY(freq_para_hertz, mag_para_dB);
                    chart1.Series["Series3"].Points.AddXY(freq_para_hertz, mag_para_dB);
                }
                if (cfg_dg.rb_PS.Checked)
                {
                    chart1.Series["Series2"].Points.AddXY(freq_para_hertz, mag_para_dB);
                    chart1.Series["Series4"].Points.AddXY(freq_para_hertz, mag_para_dB);
                }

            }
            //
        }

        public void __GrafConfig()                                  // Configurações dos gráficos
        {   // 
            chart1.ChartAreas["ChartArea1"].AxisX.Title = "Hz";      // Nomeia eixo X como Hz
            chart1.ChartAreas["ChartArea1"].AxisX.TitleForeColor = Color.Silver;
            chart1.ChartAreas["ChartArea1"].AxisY.Title = "dB";     // Nomeia eixo Y como dB
            chart1.ChartAreas["ChartArea1"].AxisY.TitleForeColor = Color.Silver;
            chart1.ChartAreas["ChartArea1"].BackColor = Color.Silver;
            //chart1.ChartAreas["ChartArea1"].AxisX.Interval = 1;     // Força a exibição de x em escala de 1 em 1
            chart1.Series["Series1"]["PixelPointWidth"] = "1";      // Configura a largura da coluna em pixels
            chart1.Series["Series1"].Color = Color.PowderBlue;      // Configura a cor
            chart1.Series["Series2"].Color = Color.Chartreuse;
            chart1.Series["Series3"].Color = Color.SaddleBrown;
            chart1.Series["Series4"].Color = Color.MistyRose;
            chart1.ChartAreas["ChartArea1"].AxisY.Crossing = 0;     // Configura o eixo y = 0 como a origem de todos 
            // os gráficos plotados
            //chart1.ChartAreas["ChartArea1"].AxisY.MajorGrid.Enabled = false; // tira o grid
        }
        // Abertura do arquivo
        private void bt_Abrir_Click(object sender, EventArgs e)
        {
            open = new OpenFileDialog();
            open.Filter = "Wave File (*.wav)|*.wav;";
            if (open.ShowDialog() != DialogResult.OK) return;
            reader = new NAudio.Wave.WaveFileReader(open.FileName);
            tam_arq_vetor = reader.Length;
            _reader_freq = reader.WaveFormat.SampleRate;
            _reader_bit  = reader.WaveFormat.BitsPerSample;
        }
        // Gatilho para gerar FFT
        private void bt_Gerar_Click(object sender, EventArgs e)
        {
            analise();
        }
        // Botao para criar arquivo .wav
        private void bt_CriarWav_Click(object sender, EventArgs e)
        {
            //System.Diagnostics.Process.Start("Tutorial6.exe");
            ger_wav = new GeradorWav();
            ger_wav.ShowDialog();
        }

        // Limpar gráfico da FFT
        private void bt_Limpar_Click(object sender, EventArgs e)
        {
            chart1.Series["Series1"].Points.Clear();
            chart1.Series["Series2"].Points.Clear();
            chart1.Series["Series3"].Points.Clear();
            chart1.Series["Series4"].Points.Clear();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {
            // Não faz nada
        }
        // Botão de configurações
        private void bt_CFG_wav_Click(object sender, EventArgs e)
        {
            cfg_dg = new Config_Diag();
            cfg_dg.txt_Cam.Text = open.FileName;
            cfg_dg.txt_FA.Text = Convert.ToString( _reader_freq);
            cfg_dg.txt_Bit.Text = Convert.ToString(_reader_bit);
            cfg_dg.txt_TamArq.Text = Convert.ToString(tam_arq_vetor);
            cfg_dg.ShowDialog();
        }
    }
}
