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
    public partial class FormEtalon : Form
    {
        public FormEtalon(FormMain form)
        {
            InitializeComponent();
            frmMain = form;
        }
        private FormMain frmMain;

        private void FormEtalon_Load(object sender, EventArgs e)
        {
            pbImage.Image = frmMain.ImgEtalon;
        }
    }
}
