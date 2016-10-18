using System;
using System.Windows.Forms;

namespace FFT_Spectro
{
    [Serializable()]
    public partial class Config_Diag : Form
    {
        public Config_Diag()
        {
            InitializeComponent();
        }
        public int nzao;
        public int offset;
        public void bt_Conf_Click(object sender, EventArgs e)
        {
            if(txt_N.Text != "")
            {
                if(Int16.Parse(txt_N.Text) >=9 && Int16.Parse(txt_N.Text) <= 14)
                {
                    nzao = (int)Math.Pow(2, Int16.Parse(txt_N.Text));
                    offset = (int)Int16.Parse(txt_OSet.Text);
                    if (nzao <= offset)
                    {
                        MessageBox.Show(" Erro! Offset deve ser menor que N (" + Math.Pow(2, Int16.Parse(txt_N.Text)) + " )");
                    }
                    if(!rb_Bar.Checked && !rb_Pon.Checked && !rb_PR.Checked && !rb_PS.Checked)
                    {
                        MessageBox.Show(" Selecione um estilo de grafico.");
                    }
                    else
                    {
                        MessageBox.Show("Confirmado: n = " + Int16.Parse(txt_N.Text) + ", N = " + Math.Pow(2, Int16.Parse(txt_N.Text)));
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("n inválido. Observe que n deve estar no intervalo [9..14].");
                }
            }
            else
            MessageBox.Show("N não preenchido.");
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                MessageBox.Show("Considere que o tamanho do vetor .wav ("+txt_TamArq.Text+")\ninfluenciará no tempo de processamento.");
            }
        }

        private void txt_N_TextChanged(object sender, EventArgs e)
        {
            // Faz nada.
        }
    }
}
