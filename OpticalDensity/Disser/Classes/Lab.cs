using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disser.Classes
{
    public class Lab : AbstractColor
    {
        public double l;    // светлота
        public double a;    // красный и зеленый цвет
        public double b;    // синий и желтый цвет

        public Lab(double l, double a, double b)
        {
            this.l = l;
            this.a = a;
            this.b = b;
        }

        public override Lab ToLab()
        {
            return this;
        }

        public override XYZ ToXYZ()     // Конвертация Lab в XYZ
        {
            double ref_X = 95.047;
            double ref_Y = 100.000;
            double ref_Z = 108.883;

            double var_Y = (this.l + 16) / 116;
            double var_X = this.a / 500 + var_Y;
            double var_Z = var_Y - this.b / 200;

            if (Math.Pow(var_Y, 3) > 0.008856)			        //дельта б^3 = 0.008856 
            {
                var_Y = Math.Pow(var_Y, 3);
            }
            else
            {
                var_Y = (var_Y - 16 / 116) / 7.787; 			// 1/3*б = 7.787
            }
            if (Math.Pow(var_X, 3) > 0.008856)
            {
                var_X = Math.Pow(var_X, 3);
            }
            else
            {
                var_X = (var_X - 16 / 116) / 7.787;
            }
            if (Math.Pow(var_Z, 3) > 0.008856)
            {
                var_Z = Math.Pow(var_Z, 3);
            }
            else
            {
                var_Z = (var_Z - 16 / 116) / 7.787;
            }

            double x = ref_X * var_X;
            double y = ref_Y * var_Y;
            double z = ref_Z * var_Z;
            return new XYZ(x, y, z);
        }

        public override RGB ToRGB() // Конвертация Lab в RGB через XYZ
        {
            return this.ToXYZ().ToRGB();
        }
    }
}