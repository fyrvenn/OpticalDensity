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
    public partial class FormTest : Form
    {
        public FormTest()
        {
            InitializeComponent();
        }
        public Bitmap ImgWork;

        private void FormTest_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox2 = new PictureBox();
            pictureBox2.Location = new System.Drawing.Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            pictureBox2.Image = ImgWork;

            Panel panel1 = new Panel();
            panel1.AutoScroll = true;
            panel1.Controls.Add(pictureBox2);
            panel1.Location = new System.Drawing.Point(251, 252);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(305, 267);
            panel1.TabIndex = 8;
            this.Controls.Add(panel1);

        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofDialog = new OpenFileDialog();
            ofDialog.RestoreDirectory = true;

            if (ofDialog.ShowDialog() == DialogResult.OK)
            {
                ImgWork = new Bitmap(ofDialog.FileNames[0]);

            }
        }
    }
}
