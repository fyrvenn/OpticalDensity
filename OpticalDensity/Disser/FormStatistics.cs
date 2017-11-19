using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Disser.Classes;

namespace Disser
{
    public partial class FormStatistics : Form
    {
        public FormStatistics(List<double> listParam)
        {
            _ListParam = listParam;
            InitializeComponent();
        }

        private List<double> _ListParam;
        private Statistics stat;
        //private bool load = true;        

        private void FormStatisticsCurrent_Load(object sender, EventArgs e)
        {
            stat = new Statistics(_ListParam);
            tbM.Text = stat.M.ToString();
            tbD.Text = stat.D.ToString();
            tbS.Text = stat.S.ToString();
            tbMin.Text = stat.Min.ToString();
            tbMax.Text = stat.Max.ToString();

            tbCountIntervals.Text = Program.countIntervalStatistics.ToString();
            DrawChart();
            //load = false;
        }

        private void DrawChart()
        {
            double[] masX = new double[Program.countIntervalStatistics];
            for (int i = 0; i < Program.countIntervalStatistics; i++)
            {
                masX[i] = Math.Round(stat.Min + (i) * (stat.Max - stat.Min) / Program.countIntervalStatistics, 3);
            }
            double[] masY = new double[Program.countIntervalStatistics];
            for (int i = 0; i < Program.countIntervalStatistics; i++)
            {
                masY[i] = stat.CountInInterval(i + 1);
            }

            this.chart1.Series["Серия"].Points.DataBindXY(masX, masY);
        }

        private void tbCountIntervals_TextChanged(object sender, EventArgs e)
        {
            if (tbCountIntervals.Text.Trim() != "")
            {
                Program.countIntervalStatistics = Convert.ToInt32(tbCountIntervals.Text);
                DrawChart();
            }
        }


    }
}
