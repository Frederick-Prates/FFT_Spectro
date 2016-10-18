using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FFT_Spectro
{
    public partial class GeradorWav : Form
    {
        public GeradorWav()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)  //lista os microfones
        {
            List<NAudio.Wave.WaveInCapabilities> sources = new List<NAudio.Wave.WaveInCapabilities>();

            for (int i = 0; i < NAudio.Wave.WaveIn.DeviceCount; i++)
            {
                sources.Add(NAudio.Wave.WaveIn.GetCapabilities(i));
            }

            sourceList.Items.Clear();

            foreach (var source in sources)
            {
                ListViewItem item = new ListViewItem(source.ProductName);
                item.SubItems.Add(new ListViewItem.ListViewSubItem(item, source.Channels.ToString()));
                sourceList.Items.Add(item);
            }
        }

        NAudio.Wave.WaveIn sourceStream = null;
        NAudio.Wave.DirectSoundOut waveOut = null;
        NAudio.Wave.WaveFileWriter waveWriter = null;

        private void button2_Click(object sender, EventArgs e) // Start
        {
            if (sourceList.SelectedItems.Count == 0) return;

            int deviceNumber = sourceList.SelectedItems[0].Index;

            sourceStream = new NAudio.Wave.WaveIn();
            sourceStream.DeviceNumber = deviceNumber;
            sourceStream.WaveFormat = new NAudio.Wave.WaveFormat(44100, NAudio.Wave.WaveIn.GetCapabilities(deviceNumber).Channels);

            NAudio.Wave.WaveInProvider waveIn = new NAudio.Wave.WaveInProvider(sourceStream);

            waveOut = new NAudio.Wave.DirectSoundOut();
            waveOut.Init(waveIn);

            sourceStream.StartRecording();
            waveOut.Play();
        }

        private void button5_Click(object sender, EventArgs e) //To Wave
        {
            if (sourceList.SelectedItems.Count == 0) return;

            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Wave File (*.wav)|*.wav;";
            if (save.ShowDialog() != System.Windows.Forms.DialogResult.OK) return;

            int deviceNumber = sourceList.SelectedItems[0].Index;

            sourceStream = new NAudio.Wave.WaveIn();
            sourceStream.DeviceNumber = deviceNumber;
            sourceStream.WaveFormat = new NAudio.Wave.WaveFormat(44100, NAudio.Wave.WaveIn.GetCapabilities(deviceNumber).Channels);
            // Padrao 44.1KHz, 16bits e PCM
            sourceStream.DataAvailable += new EventHandler<NAudio.Wave.WaveInEventArgs>(sourceStream_DataAvailable);
            waveWriter = new NAudio.Wave.WaveFileWriter(save.FileName, sourceStream.WaveFormat);

            sourceStream.StartRecording();
        }

        private void sourceStream_DataAvailable(object sender, NAudio.Wave.WaveInEventArgs e)
        {
            if (waveWriter == null) return;

            waveWriter.WriteData(e.Buffer, 0, e.BytesRecorded);
            waveWriter.Flush();
        }

        private void button3_Click(object sender, EventArgs e) //Stop
        {
            if (waveOut != null)
            {
                waveOut.Stop();
                waveOut.Dispose();
                waveOut = null;
            }
            if (sourceStream != null)
            {
                sourceStream.StopRecording();
                sourceStream.Dispose();
                sourceStream = null;
            }
            if (waveWriter != null)
            {
                waveWriter.Dispose();
                waveWriter = null;
            }
        }

        private void button4_Click(object sender, EventArgs e) //Exit
        {
            button3_Click(sender, e);
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e) //Parar gravação
        {
            button3_Click(sender, e);
        }
        private void GeradorWav_Load(object sender, EventArgs e)
        {

        }
        private NAudio.Wave.BlockAlignReductionStream stream = null;
        private NAudio.Wave.DirectSoundOut output = null;

        private void bt_Abrir_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Audio File (*.mp3;*.wav)|*.mp3;*.wav;";
            if (open.ShowDialog() != DialogResult.OK) return;

            DisposeWave();

            if (open.FileName.EndsWith(".mp3"))
            {
                NAudio.Wave.WaveStream pcm = NAudio.Wave.WaveFormatConversionStream.CreatePcmStream(new NAudio.Wave.Mp3FileReader(open.FileName));
                stream = new NAudio.Wave.BlockAlignReductionStream(pcm);
            }
            else if (open.FileName.EndsWith(".wav"))
            {
                NAudio.Wave.WaveStream pcm = new NAudio.Wave.WaveChannel32(new NAudio.Wave.WaveFileReader(open.FileName));
                stream = new NAudio.Wave.BlockAlignReductionStream(pcm);
            }
            else throw new InvalidOperationException("Not a correct audio file type.");

            output = new NAudio.Wave.DirectSoundOut();
            output.Init(stream);
            output.Play();

            bt_Play_Stop.Enabled = true;
        }

        private void bt_Play_Stop_Click(object sender, EventArgs e)
        {
            if (output != null)
            {
                if (output.PlaybackState == NAudio.Wave.PlaybackState.Playing) output.Pause();
                else if (output.PlaybackState == NAudio.Wave.PlaybackState.Paused) output.Play();
            }
        }

        private void DisposeWave()
        {
            if (output != null)
            {
                if (output.PlaybackState == NAudio.Wave.PlaybackState.Playing) output.Stop();
                output.Dispose();
                output = null;
            }
            if (stream != null)
            {
                stream.Dispose();
                stream = null;
            }
        }

        private void GeradorWav_FormClosing(object sender, FormClosingEventArgs e)
        {
            DisposeWave();
        }

    }
}
