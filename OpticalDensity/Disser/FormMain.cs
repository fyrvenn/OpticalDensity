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
using System.IO;

namespace Disser
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        public Image ImgWork;
        public Image ImgEtalon;

        public Image RegionEtalon;
        public Image RegionImgOverEtalon;
        public Image RegionBlur;

        public int currentTypeLine = 0;
        //1 - прямоугольник
        //2 - овал
        //3 - произвольная фигура
        //4 - "бублик"

        private List<Entity> listEntity = new List<Entity>();
        public List<double> listOD = new List<double>();

        public double h = 2;    // толщина слоя

        public Entity CurrentEntity = new Entity(new Point(0, 0), 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);

        private void загрузитьЭталонToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofDialog = new OpenFileDialog();
            ofDialog.RestoreDirectory = true;

            if (ofDialog.ShowDialog() == DialogResult.OK)
            {
                ImgEtalon = new Bitmap(ofDialog.FileNames[0]);

                var wind = new Disser.FormEtalon(this);
                wind.MdiParent = this;
                wind.Show();
            }
        }

        private void загрузитьИзображениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofDialog = new OpenFileDialog();
            ofDialog.RestoreDirectory = true;

            if (ofDialog.ShowDialog() == DialogResult.OK)
            {
                ImgWork = new Bitmap(ofDialog.FileNames[0]);

                var wind = new Disser.FormImage(this);
                wind.MdiParent = this;
                wind.Show();
            }
        }

        private void PanelVisibleClic(object sender, EventArgs e)
        {
            switch (Convert.ToInt32(((ToolStripMenuItem)sender).Tag))
            {
                case 1:
                    gbType.Visible = !(gbType.Visible);
                    break;
                case 2:
                    pCurrentResult.Visible = !(pCurrentResult.Visible);
                    break;
                case 3:
                    pAllResult.Visible = !(pAllResult.Visible);
                    break;
            }
        }

        private void bTypeLine_Click(object sender, EventArgs e)
        {
            currentTypeLine = Convert.ToInt32(((Button)sender).Tag);
        }

        public void UpdatePanel()
        {
            pb1.Image = this.RegionEtalon;
            pb2.Image = this.RegionImgOverEtalon;
            pb3.Image = this.RegionBlur;
        }

        private void tbBlur_ValueChanged(object sender, EventArgs e)
        {
            Program.step = (2 * tbBlur.Value) + 1;

            RegionBlur = (Bitmap)RegionImgOverEtalon.Clone();
            for (int i = 1; i <= tbBlur.Value; i++)
            {
                RegionBlur = Calculate.Blur((Bitmap)RegionBlur);
            }

            pb3.Image = RegionBlur;
            Recalculation();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            propertyGrid1.SelectedObject = CurrentEntity;
            pb1.Visible = pb2.Visible = pb3.Visible = false;
        }

        public void propertyGridUpdate()
        {
            propertyGrid1.Refresh();
        }

        public void bAdd_Click(object sender, EventArgs e)
        {
            AddEntity();
        }

        public void AddEntity()
        {
            listEntity.Add(new Entity(CurrentEntity.Focus, CurrentEntity.OD, CurrentEntity.ODmin, CurrentEntity.ODmax,
                          CurrentEntity.Kabsorption, CurrentEntity.Kpropusk, CurrentEntity.Pabsorption,
                          CurrentEntity.LEtalon, CurrentEntity.LImg, CurrentEntity.Perimeter, CurrentEntity.Square));
            RefreshListBox();
        }

        private void RefreshListBox()
        {
            lbResultList.Items.Clear();
            string rowHeader;
            rowHeader = Program.SavePoint ? " Координата " + "\t" : "";
            rowHeader += Program.SaveOD ? " Od " + "\t" : "";
            rowHeader += Program.SaveODmin ? " Od min " + "\t" : "";
            rowHeader += Program.SaveODmax ? " Od max" + "\t" : "";
            rowHeader += Program.SaveLImg ? " L изображения " + "\t" : "";
            rowHeader += Program.SaveLEtalon ? " L эталона " + "\t" : "";
            rowHeader += Program.SaveKabsorption ? " К поглощения " + "\t" : "";
            rowHeader += Program.SaveKpropusk ? " К пропускания " + "\t" : "";
            rowHeader += Program.SavePabsorption ? " Показатель поглощения " + "\t" : "";
            rowHeader += Program.SavePerimeter ? " Периметр (pixels)" + "\t"  : "";
            rowHeader += Program.SaveSquare ? " Площадь (pixels)" + "\t" : "";

            lbResultList.Items.Add(rowHeader);
            foreach (Entity ent in listEntity)
            {
                string row;
                row = Program.SavePoint ? ent.Focus.ToString() + "\t" : "";
                row += Program.SaveOD ? ent.OD.ToString() + "\t" : "";
                row += Program.SaveODmin ? ent.ODmin.ToString() + "\t" : "";
                row += Program.SaveODmax ? ent.ODmax.ToString() + "\t" : "";
                row += Program.SaveLImg ? ent.LImg.ToString() + "\t" + "\t" : "";
                row += Program.SaveLEtalon ? ent.LEtalon.ToString() + "\t" + "\t" : "";
                row += Program.SaveKabsorption ? ent.Kabsorption.ToString() + "\t" + "\t" : "";
                row += Program.SaveKpropusk ? ent.Kpropusk.ToString() + "\t" + "\t"  : "";
                row += Program.SavePabsorption ? ent.Pabsorption.ToString() + "\t" + "\t" + "\t" : "";
                CurrentEntity.Perimeter = ent.Perimeter;
                row += Program.SavePerimeter ? ent.Perimeter.ToString() + "\t" + "\t" : "";
                row += Program.SaveSquare ? ent.Square.ToString() + "\t" : "";
                lbResultList.Items.Add(row);
                propertyGridUpdate();
            }
        }

        public void Recalculation()
        {
            if (RegionBlur != null)
            {
                Indicators currentIndicators = new Indicators(this);
                CurrentEntity.OD = currentIndicators.OD;
                CurrentEntity.ODmin = currentIndicators.ODmin;
                CurrentEntity.ODmax = currentIndicators.ODmax;
                CurrentEntity.Kpropusk = currentIndicators.Kpropusk;
                CurrentEntity.Pabsorption = currentIndicators.Pabsorption;
                CurrentEntity.Kabsorption = currentIndicators.Kabsorption;
                CurrentEntity.LImg = currentIndicators.LImg;
                CurrentEntity.LEtalon = currentIndicators.LEtalon;
                CurrentEntity.Perimeter = currentIndicators.Perimeter;
                CurrentEntity.Square = currentIndicators.Square;
                propertyGridUpdate();
            }
        }

        private void выборСохраняемыхХарактеристикToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormKit frm = new FormKit();
            if (frm.ShowDialog() == DialogResult.OK)
                RefreshListBox();
        }



        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Текстовый документ (*.txt)|*.txt|Все файлы (*.*)|*.*";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string rowHeader;
                rowHeader = Program.SavePoint ? " Координата " + "\t" : "";
                rowHeader += Program.SaveOD ? " Od " + "\t" : "";
                rowHeader += Program.SaveODmin ? " Od min " + "\t" : "";
                rowHeader += Program.SaveODmax ? " Od max" + "\t" : "";
                rowHeader += Program.SaveLImg ? " L изображения " + "\t" : "";
                rowHeader += Program.SaveLEtalon ? " L эталона " + "\t" : "";
                rowHeader += Program.SaveKpropusk ? " К пропускания " + "\t" : "";
                rowHeader += Program.SaveKabsorption ? " К поглощения " + "\t" : "";
                rowHeader += Program.SavePabsorption ? " показатель поглощения " + "\t" : "";
                rowHeader += Program.SavePerimeter ? " Периметр (pixels)" + "\t" : "";
                rowHeader += Program.SaveSquare ? " Площадь (pixels)" + "\t" : "";
                                
                StreamWriter streamWriter = new StreamWriter(saveFileDialog.FileName);
                streamWriter.WriteLine(rowHeader);
                for (int i = 0; i < listEntity.Count; i++)
                {
                    string row;
                    row = Program.SavePoint ? listEntity[i].Focus.ToString() + "\t" : "";
                    row += Program.SaveOD ? listEntity[i].OD.ToString() + "\t" : "";
                    row += Program.SaveODmin ? listEntity[i].ODmin.ToString() + "\t" : "";
                    row += Program.SaveODmax ? listEntity[i].ODmax.ToString() + "\t" : "";
                    row += Program.SaveLImg ? listEntity[i].LImg.ToString() + "\t" : "";
                    row += Program.SaveLEtalon ? listEntity[i].LEtalon.ToString() + "\t" : "";
                    row += Program.SaveKpropusk ? listEntity[i].Kpropusk.ToString() + "\t" : "";
                    row += Program.SaveKabsorption ? listEntity[i].Kabsorption.ToString() + "\t" : "";
                    row += Program.SavePabsorption ? listEntity[i].Pabsorption.ToString() + "\t" : "";
                    row += Program.SavePerimeter ? listEntity[i].Perimeter.ToString() + "\t" : "";
                    row += Program.SaveSquare ? listEntity[i].Square.ToString() + "\t" : "";


                    streamWriter.WriteLine(row);
                }

                streamWriter.Close();
            }

        }

        private void cbMethodSrednego_CheckedChanged(object sender, EventArgs e)
        {
            if (cbMethodSrednego.Checked)
            {
                cbMicroPlag.Checked = cbMethodScanirovaniy.Checked = false;
                Program.methodSrednego = true;
                Recalculation();
            }
        }

        private void cbMicroPlag_CheckedChanged(object sender, EventArgs e)
        {
            tbBlur.Enabled = cbMicroPlag.Checked;
            if (cbMicroPlag.Checked)
            {
                cbMethodSrednego.Checked = cbMethodScanirovaniy.Checked = false;
                Program.methodSrednego = false;
                Recalculation();
            }
        }

        private void cbMethodScanirovaniy_CheckedChanged(object sender, EventArgs e)
        {
            if (cbMethodScanirovaniy.Checked)
            {
                cbMethodSrednego.Checked = cbMicroPlag.Checked = false;
                Program.methodSrednego = false;
                Recalculation();
            }
        }

        private void текущегоОбъектаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listOD != null && listOD.Count > 0)
            {
                var wind = new Disser.FormStatistics(listOD);
                wind.MdiParent = this;
                wind.Text += " текущей области";
                wind.Show();
            }
        }

        private void набораОбластейToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listEntity.Count > 0)
            {
                List<double> listODentity = new List<double>();
                foreach (Entity ent in listEntity) listODentity.Add(ent.OD);
                listODentity.Add(CurrentEntity.OD);

                if (listODentity.Count > 0)
                {
                    var wind = new Disser.FormStatistics(listODentity);
                    wind.MdiParent = this;
                    wind.Text += " набора областей";
                    wind.Show();
                }
            }
        }

        private void tbH_TextChanged(object sender, EventArgs e)
        {
            h = Convert.ToDouble(tbH.Text);
            Recalculation();
        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormHelp fHelp = new FormHelp();
            fHelp.Show();
        }

        private void pbRollUp_Click(object sender, EventArgs e)
        {
            pb1.Visible = pb2.Visible = pb3.Visible = !pb1.Visible;
        }

        private void каталогToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormBase fBase = new FormBase();
            fBase.Show();
        }

    }
}