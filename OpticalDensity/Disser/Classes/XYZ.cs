using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disser.Classes
{
    public class XYZ : AbstractColor
    {
        public double X;
        public double Y;
        public double Z;

        public XYZ(double x, double y, double z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        public override XYZ ToXYZ()
        {
            return this;
        }

        public override Lab ToLab() // Конвертация XYZ в Lab 
        {
            //белый цвет в пространстве XYZ: [95.047; 100.000; 108.883]
             double ref_X = 95.047;
            double ref_Y = 100.000;
            double ref_Z = 108.883;

            double var_X = X / ref_X;
            double var_Y = Y / ref_Y;
            double var_Z = Z / ref_Z;

            if (var_X > 0.008856)
                var_X = Math.Pow(var_X, 1.0 / 3);
            else
                var_X = (7.787 * var_X) + (16.0 / 116);

            if (var_Y > 0.008856)
                var_Y = Math.Pow(var_Y, 1.0 / 3);
            else
                var_Y = (7.787 * var_Y) + (16.0 / 116);

            if (var_Z > 0.008856)
                var_Z = Math.Pow(var_Z, 1.0 / 3);
            else
                var_Z = (7.787 * var_Z) + (16.0 / 116);

            double l = (116 * var_Y) - 16;
            double a = 500 * (var_X - var_Y);
            double b = 200 * (var_Y - var_Z);

            return new Lab(l, a, b);
        }

        public override RGB ToRGB()     // Конвертация XYZ в RGB 
        {
            double var_X = this.X / 100;  //X from 0 to  95.047      
            double var_Y = this.Y / 100;  //Y from 0 to 100.000
            double var_Z = this.Z / 100;  //Z from 0 to 108.883

            double var_R = var_X * 3.2406 + var_Y * -1.5372 + var_Z * -0.4986;
            double var_G = var_X * -0.9689 + var_Y * 1.8758 + var_Z * 0.0415;
            double var_B = var_X * 0.0557 + var_Y * -0.2040 + var_Z * 1.0570;

            if (var_R > 0.0031308)
                var_R = 1.055 * Math.Pow(var_R, 1 / 2.4) - 0.055;
            else
                var_R = 12.92 * var_R;

            if (var_G > 0.0031308)
                var_G = 1.055 * Math.Pow(var_G, 1 / 2.4) - 0.055;
            else
                var_G = 12.92 * var_G;

            if (var_B > 0.0031308)
                var_B = 1.055 * Math.Pow(var_B, 1 / 2.4) - 0.055;
            else
                var_B = 12.92 * var_B;

            double r = var_R * 255;
            double g = var_G * 255;
            double b = var_B * 255;

            return new RGB(r, g, b);
        }
    }
}
