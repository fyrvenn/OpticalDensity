using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disser.Classes
{
    public class Indicators
    {
        public Indicators(FormMain frm)
        {
            _frm = frm;
            _h = frm.h;
            if (Program.methodSrednego == true)
                CalculateODsr((Bitmap)frm.RegionBlur, (Bitmap)frm.RegionEtalon);
            else
                CalculateOD((Bitmap)frm.RegionBlur, (Bitmap)frm.RegionEtalon);
        }

            
        private FormMain _frm;
       
        private double _OD;             // оптическая плотность
        private double _ODmin;
        private double _ODmax;
        private double _Kabsorption;    // коэффициент поглощения
        private double _Kpropusk;       // коэффициент пропускания
        private double _Pabsorption;    // показатель поглощения
        private double _LEtalon;
        private double _LImg;
        private double _h;  // толщина слоя
        private double _Perimeter;  //периметр
        private double _Square;     //площадь

        public double OD
        {
            get { return Math.Round(_OD, 3); }
            set { _OD = value; }
        }
        public double ODmin
        {
            get { return Math.Round(_ODmin, 3); }
            set { _ODmin = value; }
        }
        public double ODmax
        {
            get { return Math.Round(_ODmax, 3); }
            set { _ODmax = value; }
        }
        public double Kabsorption
        {
            get { return Math.Round(_Kabsorption, 3); }
            set { _Kabsorption = value; }
        }
        public double Kpropusk
        {
            get { return Math.Round(_Kpropusk, 3); }
            set { _Kpropusk = value; }
        }
        public double Pabsorption
        {
            get { return Math.Round(_Pabsorption, 3); }
            set { _Pabsorption = value; }
        }
       
        public double LEtalon
        {
            get { return Math.Round(_LEtalon, 3); }
            set { _LEtalon = value; }
        }
        public double LImg
        {
            get { return Math.Round(_LImg, 3); }
            set { _LImg = value; }
        }

        public double Perimeter
        {
            get { return Math.Round(_Perimeter, 0); }
            set { _Perimeter = value; }
        }

        public double Square
        {
            get { return Math.Round(_Square, 0); }
            set { _Square = value; }
        }

        /// <summary>
        /// Вычисление характеристик по микроплаг методу в случае step > 1, и по методу сканирования при step = 1
        /// </summary>
        /// <param name="Img">Область изображения</param>
        /// <param name="Etalon">Область эталона</param>
        private void CalculateOD(Bitmap Img, Bitmap Etalon)
        {
            List<double> ListOD = new List<double>();
            
            List<double> ListLEtalon = new List<double>();
            List<double> ListLImg = new List<double>();
            int step = Program.step;
            _Square = 0;

            for (int y = 0; y < Img.Height; y += step)
                for (int x = 0; x < Img.Width; x += step)
                {
                    Color ce = Etalon.GetPixel(x, y);
                    Color ci = Img.GetPixel(x, y);
                    RGB ImgRGB = new RGB(ci.R, ci.G, ci.B);
                    RGB EtalonRGB = new RGB(ce.R, ce.G, ce.B);

                    double Li = ImgRGB.ToLab().l;
                    double Le = EtalonRGB.ToLab().l;

                    if (Li != Le)
                    {
                        _Square += 1;
                        ListLImg.Add(Li);
                        ListLEtalon.Add(Le);
                        if (Math.Log10(Le / Li) > 0)
                            ListOD.Add(Math.Log10(Le / Li));
                    }
                }

            _LEtalon = ListLEtalon.Count() > 0 ? ListLEtalon.Sum() / ListLEtalon.Count() : 0;
            _LImg = ListLImg.Count() > 0 ? ListLImg.Sum() / ListLImg.Count() : 0;

            _OD = ListOD.Count() > 0 ? ListOD.Sum() / ListOD.Count() : 0;
            _ODmin = ListOD.Count() > 0 ? ListOD.Min() : 0;
            _ODmax = ListOD.Count() > 0 ? ListOD.Max() : 0;

            _Kpropusk = _LImg / _LEtalon;
            _Kabsorption = 1 - _Kpropusk;
            _Pabsorption = _OD / _h;

            switch (_frm.currentTypeLine)
            {
                case 1: 
                    _Perimeter = 2 * (Img.Height + Img.Width);
                    break;
                case 2: 
                    _Perimeter = 2 * Math.PI * Math.Sqrt((Img.Height * Img.Height/4 +
                        Img.Width * Img.Width/4)/2);
                    break;
                case 3:
                    
                    break;
                case 4: 
                    
                    break;
                default:
                    break;
            }

            _Square = ListOD.Count() > 0 ? ListOD.Count() : 0 ;

            _frm.listOD.Clear();
            _frm.listOD = ListOD.Count() > 0 ? ListOD : null;

        }

        /// <summary>
        /// Вычисление характеристик методом сканирования с усреднением
        /// </summary>
        /// <param name="Img">Область изображения</param>
        /// <param name="Etalon">Область эталона</param>
        private void CalculateODsr(Bitmap Img, Bitmap Etalon)
        {
            List<double> ListLEtalon = new List<double>();
            List<double> ListLImg = new List<double>();
            int step = Program.step;

            for (int y = 0; y < Img.Height; y += step)
                for (int x = 0; x < Img.Width; x += step)
                {
                    Color ce = Etalon.GetPixel(x, y);
                    Color ci = Img.GetPixel(x, y);
                    RGB ImgRGB = new RGB(ci.R, ci.G, ci.B);
                    RGB EtalonRGB = new RGB(ce.R, ce.G, ce.B);

                    double Li = ImgRGB.ToLab().l;
                    double Le = EtalonRGB.ToLab().l;

                    if (Li != Le)
                    {
                        ListLImg.Add(Li);
                        ListLEtalon.Add(Le);
                    }
                }

            _LEtalon = ListLEtalon.Count() > 0 ? ListLEtalon.Sum() / ListLEtalon.Count() : 0;
            _LImg = ListLImg.Count() > 0 ? ListLImg.Sum() / ListLImg.Count() : 0;

            _OD = _LImg > 0 ? Math.Log10(_LEtalon / _LImg) : 0;
            _ODmin = _OD;
            _ODmax = _OD;

            _Kpropusk = _LImg / _LEtalon;
            _Kabsorption = 1 - _Kpropusk;
            _Pabsorption = _OD / _h;

            switch (_frm.currentTypeLine)
            {
                case 1:
                    _Perimeter = 2 * (Img.Height + Img.Width);
                    break;
                case 2:
                    _Perimeter = 2 * Math.PI * Math.Sqrt((Img.Height * Img.Height/4 +
                        Img.Width * Img.Width/4)/2);
                    break;
                case 3:
                    
                    break;
                case 4:
                    
                    break;
                default:
                    break;
            }
            _Square = ListLEtalon.Count() > 0 ? ListLEtalon.Count() : 0;

            _frm.listOD.Clear();
            _frm.listOD.Add(_OD);
        }

    }
}
