using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disser.Classes
{
    public class Calculate
    {
        public static Bitmap Blur(Bitmap Img)
        {
            try
            {
                int w = Img.Width;
                int h = Img.Height;

                //Bitmap ImgBlur = new Bitmap( w, h );
                Bitmap ImgBlur = (Bitmap)Img.Clone();

                for (int i = 1; i < w - 1; i++)
                {
                    for (int k = 1; k < h - 1; k++)
                    {
                        Color[] clrs = { Img.GetPixel(i - 1, k - 1), Img.GetPixel(i - 1, k), Img.GetPixel(i - 1, k + 1),
                                             Img.GetPixel(i, k - 1), Img.GetPixel(i, k), Img.GetPixel(i, k + 1),
                                             Img.GetPixel(i, k - 1), Img.GetPixel(i + 1, k), Img.GetPixel(i + 1, k + 1) };

                        int newR = 0, newG = 0, newB = 0;
                        foreach (Color clr in clrs)
                        {
                            newR += clr.R;
                            newG += clr.G;
                            newB += clr.B;
                        }
                        newR /= 9;
                        newG /= 9;
                        newB /= 9;

                        Color cl2 = Color.FromArgb(newR, newG, newB);

                        ImgBlur.SetPixel(i, k, cl2);
                    }
                }

                return ImgBlur;
            }
            catch
            {
                return null;
            }
        }


    }
}
