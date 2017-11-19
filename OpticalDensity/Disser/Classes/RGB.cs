using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disser.Classes
{
    public class RGB : AbstractColor
    {
        public double R;    //Red
        public double G;    //Green
        public double B;    //Blue 

        public RGB(double r, double g, double b)
        {
            this.R = r;
            this.G = g;
            this.B = b;
        }

        public override RGB ToRGB()
        {
            return this;
        }

        public override XYZ ToXYZ()     // Конвертация RGB в XYZ 
        {
            double var_R = R / 255;
            double var_G = G / 255;
            double var_B = B / 255;

            if (var_R > 0.04045)
                var_R = Math.Pow(((var_R + 0.055) / 1.055), 2.4);
            else
                var_R = var_R / 12.92;

            if (var_G > 0.04045)
                var_G = Math.Pow(((var_G + 0.055) / 1.055), 2.4);
            else
                var_G = var_G / 12.92;

            if (var_B > 0.04045)
                var_B = Math.Pow(((var_B + 0.055) / 1.055), 2.4);
            else
                var_B = var_B / 12.92;

            var_R = var_R * 100;
            var_G = var_G * 100;
            var_B = var_B * 100;

            double x = var_R * 0.4124 + var_G * 0.3576 + var_B * 0.1805;
            double y = var_R * 0.2126 + var_G * 0.7152 + var_B * 0.0722;
            double z = var_R * 0.0193 + var_G * 0.1192 + var_B * 0.9505;

            return new XYZ(x, y, z);
        }

        public override Lab ToLab() // Конвертация RGB в Lab через XYZ
        {
            return this.ToXYZ().ToLab();
        }
    }
}
