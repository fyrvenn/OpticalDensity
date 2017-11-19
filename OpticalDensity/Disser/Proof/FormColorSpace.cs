using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Disser.Proof
{
    public partial class FormColorSpace : Form
    {
        public FormColorSpace()
        {
            InitializeComponent();
        }

        public Bitmap ImgWork;
        public int currentTypeLine = 0;
        PictureBox pbImage = new PictureBox();
        Panel panel11 = new Panel();

        private void загрузитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofDialog = new OpenFileDialog();
            ofDialog.RestoreDirectory = true;

            if (ofDialog.ShowDialog() == DialogResult.OK)
            {
                ImgWork = new Bitmap(ofDialog.FileNames[0], true);
                pbImage.Image = ImgWork;    // по значению
            }
        }

        private void bTypeLine_Click(object sender, EventArgs e)
        {
            currentTypeLine = Convert.ToInt32(((Button)sender).Tag);
        }

        private void pbImage_Init()
        {
            pbImage.Location = new System.Drawing.Point(0, 0);
            pbImage.Name = "pbImage";
            pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            pbImage.TabIndex = 0;
            pbImage.TabStop = false;
            pbImage.Image = ImgWork;

            panel11.AutoScroll = true;
            panel11.Controls.Add(pbImage);
            panel11.Location = new Point(0, 0);
            panel11.Name = "panel11";
            panel11.Size = panel2.Size;
            panel11.TabIndex = 8;

            panel2.Controls.Add(panel11);
        }

        private void FormColorSpace_Load(object sender, EventArgs e)
        {
            pbImage_Init();
        }
    }
}
