using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FFT_Spectro
{
    public partial class Amostrado_Graf : Form
    {
        public Amostrado_Graf()
        {
            InitializeComponent();
            config_grafico_amostrado();
        }

        private void Amostrado_Graf_Load(object sender, EventArgs e)
        {

        }
        private void config_grafico_amostrado()
        {
            chart1.ChartAreas["ChartArea1"].AxisX.Title = "T";
            chart1.ChartAreas["ChartArea1"].AxisY.Title = "Y(T)";
        }

    }
}
