using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Disser
{
    public partial class FormKit : Form
    {
        public FormKit()
        {
            InitializeComponent();
        }

        private void FormKit_Load(object sender, EventArgs e)
        {
            cbPoint.Checked = Program.SavePoint;
            cbLEtalon.Checked = Program.SaveLEtalon;
            cbLImg.Checked = Program.SaveLImg;
            cbKpropusk.Checked = Program.SaveKpropusk;
            cbKabsorption.Checked = Program.SaveKabsorption;
            cbOD.Checked = Program.SaveOD;
            cbODmin.Checked = Program.SaveODmin;
            cbODmax.Checked = Program.SaveODmax;
            cbPabsorption.Checked = Program.SavePabsorption;
            cbPerimeter.Checked = Program.SavePerimeter;
            cbSquare.Checked = Program.SaveSquare;
        }

        private void bChancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bOk_Click(object sender, EventArgs e)
        {
            Program.SavePoint = cbPoint.Checked;
            Program.SaveLImg = cbLImg.Checked;
            Program.SaveLEtalon = cbLEtalon.Checked;
            Program.SaveKpropusk = cbKpropusk.Checked;
            Program.SaveKabsorption = cbKabsorption.Checked;
            Program.SavePabsorption = cbPabsorption.Checked;
            Program.SaveOD = cbOD.Checked;
            Program.SaveODmin = cbODmin.Checked;
            Program.SaveODmax = cbODmax.Checked;
            Program.SavePerimeter = cbPerimeter.Checked;
            Program.SaveSquare = cbSquare.Checked;
            
            Program.SavePabsorption = cbPabsorption.Checked;
            Close();
        }
    }
}
