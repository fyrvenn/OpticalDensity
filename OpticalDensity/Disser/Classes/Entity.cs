using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disser.Classes
{
    public class Entity
    {
        public Entity(Point focus, double od, double odMin, double odMax,
            double kAbsorption, double kPropusc, double pAbsorption,
            double lEtalon, double lImg, double perimeter, double square)
        {
            Focus = focus;
            OD = od;
            ODmin = odMin;
            ODmax = odMax;
            LEtalon = lEtalon;
            LImg = lImg;
            Kpropusk = kPropusc;
            Kabsorption = kAbsorption;
            Pabsorption = pAbsorption;
            //периметр
            Perimeter = perimeter;
            //площадь
            Square = square;
        }

        [DisplayName("Координата центра")]
        [Description("Координата центра области")]
        [Category("1.Общие")]
        [ReadOnly(true)]
        public Point Focus { get; set; }


        [DisplayName("Эталон")]
        [Description("Среднее значение показателя L эталона")]
        [Category("2.Световой поток")]
        [ReadOnly(true)]
        public double LEtalon { get; set; }

        [DisplayName("Изображение")]
        [Description("Среднее значение показателя L изображения")]
        [Category("2.Световой поток")]
        [ReadOnly(true)]
        public double LImg { get; set; }


        [DisplayName("K порпускания")]
        [Description("коэффициент внутреннего пропускания")]
        [Category("3.Оценка величин светового потока")]
        [ReadOnly(true)]
        public double Kpropusk { get; set; }

        [DisplayName("K поглощения")]
        [Description("коэффициент поглощения")]
        [Category("3.Оценка величин светового потока")]
        [ReadOnly(true)]
        public double Kabsorption { get; set; }


        [DisplayName("Оптическая плотность")]
        [Description("Оптическая плотность")]
        [Category("4.Значения оптической плотности")]
        [ReadOnly(true)]
        public double OD { get; set; }

        [DisplayName("Min Оптическая плотность")]
        [Description("Min Оптическая плотность")]
        [Category("4.Значения оптической плотности")]
        [ReadOnly(true)]
        public double ODmin { get; set; }

        [DisplayName("Max Оптическая плотность")]
        [Description("Max Оптическая плотность")]
        [Category("4.Значения оптической плотности")]
        [ReadOnly(true)]
        public double ODmax { get; set; }

      
        [DisplayName("Показатель поглощения")]
        [Description("Показатель поглощения")]
        [Category("5.Характеристика поглощающего слоя")]
        [ReadOnly(true)]
        public double Pabsorption { get; set; }

        [DisplayName("Периметр")]
        [Description("Периметр выделенной области, выраженный в пикселях")]
        [Category("6.Измерение")]
        [ReadOnly(true)]
        public double Perimeter { get; set; }

        [DisplayName("Площадь")]
        [Description("Площадь выделенной области, выраженная в пикселях")]
        [Category("6.Измерение")]
        [ReadOnly(true)]
        public double Square { get; set; }


    }
}
