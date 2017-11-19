using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Disser.Classes;


namespace Disser
{
    public partial class FormImage : Form
    {
        public FormImage(FormMain form)
        {
            InitializeComponent();
            frmMain = form;            
        }

        public double LP = 0;//

        private FormMain frmMain;
        private bool extract = false;       //если происходит выделение = true
            //для случая 4, InExtracted = true когда произошло выделение внутренней области 
        private bool InExtracted = false;
        private List<Point> listPoints = new List<Point>();
        private List<Point> listPointsOut = new List<Point>();
       
        private void FormImage_Load(object sender, EventArgs e)
        {
            pbImage.Image = frmMain.ImgWork;
        }



        private void pbImage_MouseDown(object sender, MouseEventArgs e)
        {
            if (pbImage.Image != null && e.Button == System.Windows.Forms.MouseButtons.Left && frmMain.currentTypeLine != 0)
            {
                extract = true;
                if ((InExtracted) && (frmMain.currentTypeLine == 4))
                {
                    listPointsOut.Clear();
                    listPointsOut.Add(e.Location);
                    timerDraw.Start();                    
                }
                else
                {
                    listPoints.Clear();
                    listPointsOut.Clear();
                    listPoints.Add(e.Location);
                    timerDraw.Start();
                }
            }
        }

        private void pbImage_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left && extract)
                if ((InExtracted) && (frmMain.currentTypeLine == 4))
                    listPointsOut.Add(e.Location);
                else                
                    listPoints.Add(e.Location);                    
                
        }

        private void pbImage_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left && extract)
            {
                if ((InExtracted) && (frmMain.currentTypeLine == 4))
                {
                    listPointsOut.Add(e.Location);
                    timerDraw.Stop();
                    if (listPointsOut.Count > 4)
                    {
                        Cut();
                        frmMain.UpdatePanel();
                    }
                    
                }
                else
                    if ((frmMain.currentTypeLine == 4) && (listPoints.Count > 4))
                    {
                        Cut();
                        frmMain.UpdatePanel();
                        InExtracted = true;                        
                    }
                    else
                    {
                        listPoints.Add(e.Location);
                        timerDraw.Stop();
                        if (listPoints.Count > 4)
                        {
                            Cut();
                            frmMain.UpdatePanel();
                        }
                    }                
            }
        }

        private bool CalculateRegionLasso(out int minX, out int minY, out  int maxX, out  int maxY)
        {
            try
            {
                minX = frmMain.ImgWork.Width;
                minY = frmMain.ImgWork.Height;
                maxX = 0;
                maxY = 0;

                foreach (Point p in listPoints)
                {
                    minX = (p.X < minX) ? p.X : minX;
                    minY = (p.Y < minY) ? p.Y : minY;
                    maxX = (p.X > maxX) ? p.X : maxX;
                    maxY = (p.Y > maxY) ? p.Y : maxY;                    
                }
                return true;
            }
            catch
            {
                minX = minY = maxX = maxY = 0;
                return false;
            }
        }


        private bool CalculateRegionRing(out int minX, out int minY, out  int maxX, out  int maxY)
        {
            try
            {
                minX = frmMain.ImgWork.Width;
                minY = frmMain.ImgWork.Height;
                maxX = 0;
                maxY = 0;
                if (listPointsOut.Count > 4)
                {
                    foreach (Point p in listPointsOut)
                    {
                        minX = (p.X < minX) ? p.X : minX;
                        minY = (p.Y < minY) ? p.Y : minY;
                        maxX = (p.X > maxX) ? p.X : maxX;
                        maxY = (p.Y > maxY) ? p.Y : maxY;
                    }
                }
                else
                {
                    foreach (Point p in listPoints)
                    {
                        minX = (p.X < minX) ? p.X : minX;
                        minY = (p.Y < minY) ? p.Y : minY;
                        maxX = (p.X > maxX) ? p.X : maxX;
                        maxY = (p.Y > maxY) ? p.Y : maxY;
                    }
                }
                return true;
            }
            catch
            {
                minX = minY = maxX = maxY = 0;
                return false;
            }
        }

        private bool CalculateRegionRectangle(out int minX, out int minY, out  int maxX, out  int maxY)
        {
            try
            {
                minX = Math.Min(listPoints.First().X, listPoints.Last().X);
                minY = Math.Min(listPoints.First().Y, listPoints.Last().Y);
                maxX = Math.Max(listPoints.First().X, listPoints.Last().X);
                maxY = Math.Max(listPoints.First().Y, listPoints.Last().Y);

                return true;
            }
            catch
            {
                minX = minY = maxX = maxY = 0;
                return false;
            }
        }

        private bool CalculateRegionEllipse(out int minX, out int minY, out  int maxX, out  int maxY)
        {
            try
            {
                minX = Math.Min(listPoints.First().X, listPoints.Last().X);
                minY = Math.Min(listPoints.First().Y, listPoints.Last().Y);
                maxX = Math.Max(listPoints.First().X, listPoints.Last().X);
                maxY = Math.Max(listPoints.First().Y, listPoints.Last().Y);

                return true;
            }
            catch
            {
                minX = minY = maxX = maxY = 0;
                return false;
            }
        }

        private void Cut()
        {
            Rectangle rec;
            int minX, minY, maxX, maxY;
             
            if ((frmMain.currentTypeLine) == 1)
            {
                CalculateRegionRectangle(out minX, out minY, out maxX, out maxY);
            }
            else if (frmMain.currentTypeLine == 2)
            {
                CalculateRegionEllipse(out minX, out minY, out maxX, out maxY);
            }
            else if (frmMain.currentTypeLine == 3)
            {
                CalculateRegionLasso(out minX, out minY, out maxX, out maxY);
            }
            else if (frmMain.currentTypeLine == 4)
            {
                CalculateRegionRing(out minX, out minY, out maxX, out maxY);
            }
            else return;

            if (maxX - minX == 0 || maxY - minY == 0) return; //если нарисовали линию

            rec = new Rectangle(new Point(minX, minY), new Size(maxX - minX, maxY - minY));

            Bitmap bmp;// основа рисования

            if (frmMain.ImgEtalon != null)
            {
                frmMain.RegionEtalon = ((Bitmap)frmMain.ImgEtalon).Clone(rec, ((Bitmap)frmMain.ImgEtalon).PixelFormat); //если есть абсолютно прозрачное изображение frmMain.imgEtalon
                bmp = (Bitmap)frmMain.ImgEtalon.Clone();
            }
            else
            {
                frmMain.RegionEtalon = new Bitmap(rec.Width, rec.Height);
                bmp = new Bitmap(frmMain.ImgWork.Width, frmMain.ImgWork.Height);
            }

            if ((frmMain.currentTypeLine) == 1)
            {
                frmMain.RegionImgOverEtalon = ((Bitmap)frmMain.ImgWork).Clone(rec, frmMain.ImgWork.PixelFormat);             
            }

            if ((frmMain.currentTypeLine) == 2)
            {
                Graphics g = Graphics.FromImage(bmp);
                using (TextureBrush br = new TextureBrush(pbImage.Image))
                {
                    using (GraphicsPath gp = new GraphicsPath())
                    {
                        gp.AddLines(listPoints.ToArray());
                        g.FillEllipse(br, rec);
                    }
                }

                frmMain.RegionImgOverEtalon = bmp.Clone(rec, bmp.PixelFormat);

            }

            if ((frmMain.currentTypeLine) == 3)
            {
                Graphics g = Graphics.FromImage(bmp);
                using (TextureBrush br = new TextureBrush(pbImage.Image))
                {
                    using (GraphicsPath gp = new GraphicsPath())
                    {
                        gp.AddLines(listPoints.ToArray());
                        g.FillPath(br, gp);
                    }
                }

                frmMain.RegionImgOverEtalon = bmp.Clone(rec, bmp.PixelFormat);
            }

            if ((frmMain.currentTypeLine) == 4)
            {
                if ((listPoints.Count > 4) && (InExtracted==false))
                {
                    Graphics g = Graphics.FromImage(bmp);
                    using (TextureBrush br = new TextureBrush(pbImage.Image))
                    {
                        using (GraphicsPath gp = new GraphicsPath())
                        {
                            gp.AddLines(listPoints.ToArray());
                            g.FillPath(br, gp);
                        }
                    }

                    frmMain.RegionImgOverEtalon = bmp.Clone(rec, bmp.PixelFormat);
                }                

                if ((listPointsOut.Count > 4) && (InExtracted))
                {
                                        
                        Graphics gOut = Graphics.FromImage(bmp);
                        Graphics gIn = Graphics.FromImage(bmp);
                        using (TextureBrush br = new TextureBrush(pbImage.Image)) using (TextureBrush brIn = new TextureBrush(frmMain.ImgEtalon))
                        {
                            using (GraphicsPath gpOut = new GraphicsPath()) using (GraphicsPath gpIn = new GraphicsPath())
                            {
                                gpOut.AddLines(listPointsOut.ToArray());
                                gpIn.AddLines(listPoints.ToArray());
                                gOut.FillPath(br, gpOut);
                                gIn.FillPath(brIn, gpIn);
                            }
                        }
                                      
                    frmMain.RegionImgOverEtalon = bmp.Clone(rec, bmp.PixelFormat);
                    InExtracted = false;
                }
            }

            if (frmMain.RegionImgOverEtalon != null)
                frmMain.RegionBlur = frmMain.RegionImgOverEtalon;

            frmMain.CurrentEntity.Perimeter = 1;
            
            //записать текущий результат в таблицу
            frmMain.CurrentEntity.Focus = new Point(minX + (maxX - minX) / 2, minY + (maxY - minY) / 2);
            frmMain.Recalculation();
            if (frmMain.currentTypeLine == 3)
            { //периметр
                LP = 0;
                 for (int j = 1; j < listPoints.Count; j++)
                     LP += Math.Sqrt((listPoints[j].X - listPoints[j - 1].X) * (listPoints[j].X - listPoints[j - 1].X)
                            + (listPoints[j].Y - listPoints[j - 1].Y) * (listPoints[j].Y - listPoints[j - 1].Y));
                 frmMain.CurrentEntity.Perimeter = Math.Round(LP, 0);///периметр
            }
            if (frmMain.currentTypeLine == 4)
            {
                LP = 0;
                if (listPointsOut.Count > 4)
                {
                    //периметр
                    for (int j = 1; j < listPointsOut.Count; j++)
                        LP += Math.Sqrt((listPointsOut[j].X - listPointsOut[j - 1].X) * (listPointsOut[j].X - listPointsOut[j - 1].X)
                               + (listPointsOut[j].Y - listPointsOut[j - 1].Y) * (listPointsOut[j].Y - listPointsOut[j - 1].Y));
                    frmMain.CurrentEntity.Perimeter = Math.Round(LP, 0);///периметр
                }
                else
                {
                    //периметр
                    for (int j = 1; j < listPoints.Count; j++)
                        LP += Math.Sqrt((listPoints[j].X - listPoints[j - 1].X) * (listPoints[j].X - listPoints[j - 1].X)
                               + (listPoints[j].Y - listPoints[j - 1].Y) * (listPoints[j].Y - listPoints[j - 1].Y));
                    frmMain.CurrentEntity.Perimeter = Math.Round(LP, 0);///периметр
                }
            }
            frmMain.AddEntity();   
        }

        private void timerDraw_Tick(object sender, EventArgs e)
        {
            pbImage.Invalidate();
        }

        private void pbImage_Paint(object sender, PaintEventArgs e)
        {
            if (pbImage.Image != null)
                DrawIn(e.Graphics);
        }

        private void DrawIn(Graphics g)
        {
            Pen myPen = new Pen(Color.Red, 1);
            myPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            if (listPoints.Count > 0)
            {
                switch (frmMain.currentTypeLine)
                {
                    case 1:
                        g.DrawRectangle(myPen, Math.Min(listPoints.First().X, listPoints.Last().X), Math.Min(listPoints.First().Y, listPoints.Last().Y),
                            Math.Max(listPoints.First().X, listPoints.Last().X) - Math.Min(listPoints.First().X, listPoints.Last().X),
                            Math.Max(listPoints.First().Y, listPoints.Last().Y) - Math.Min(listPoints.First().Y, listPoints.Last().Y));
                        break;
                    case 2:
                        g.DrawEllipse(myPen, Math.Min(listPoints.First().X, listPoints.Last().X), Math.Min(listPoints.First().Y, listPoints.Last().Y),
                            Math.Max(listPoints.First().X, listPoints.Last().X) - Math.Min(listPoints.First().X, listPoints.Last().X),
                            Math.Max(listPoints.First().Y, listPoints.Last().Y) - Math.Min(listPoints.First().Y, listPoints.Last().Y));
                        break;
                    case 3:
                        using (GraphicsPath gp = new GraphicsPath())
                        {
                            gp.AddLines(listPoints.ToArray());
                            g.DrawPath(myPen, gp);
                        }
                        break;
                    case 4:
                        using (GraphicsPath gp = new GraphicsPath()) 
                        {
                            gp.AddLines(listPoints.ToArray());
                            g.DrawPath(myPen, gp);
                        }
                        if ((InExtracted) && (listPointsOut.Count > 4))
                        {
                            using (GraphicsPath gp1 = new GraphicsPath())
                            {
                                gp1.AddLines(listPointsOut.ToArray());
                                g.DrawPath(myPen, gp1);
                            }
                        }
                        break;
                    default:
                        break;
                }            
            }
        }

    }
}
