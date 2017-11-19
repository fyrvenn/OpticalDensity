using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disser.Classes
{
    public class Statistics
    {
        public Statistics(List<double> ListParam)
        {
            _listParam = ListParam;
            CalculateStatistics();
        }

        private List<double> _listParam;
        private double _D;
        private double _M;
        private double _S;
        private double _min;
        private double _max;

        public double D //Дисперсия
        {
            get { return Math.Round(_D, 3); }
            set { _D = value; }
        }
        public double M  //Мат. ожидание
        {
            get { return Math.Round(_M, 3); }
            set { _M = value; }
        }
        public double S  //Стандартное отклонение
        {
            get { return Math.Round(_S, 3); }
            set { _S = value; }
        }
        public double Min
        {
            get { return Math.Round(_min, 3); }
            set { _min = value; }
        }
        public double Max
        {
            get { return Math.Round(_max, 3); }
            set { _max = value; }
        }

        private void CalculateStatistics()
        {
            _M = _listParam.Sum() / _listParam.Count;
            _D = Disp();
            _S = Math.Sqrt(_D);
            _min = _listParam.Min();
            _max = _listParam.Max();
        }

        private double Disp()
        {
            double d, sum = 0;
            foreach (double elem in _listParam.AsEnumerable())
            {
                sum += Math.Pow(elem - _M, 2);
            }
            d = sum / _listParam.Count;
            return d;
        }

        public int CountInInterval(int i)  //i - нумерация с 1
        {
            int k = 0;
            double stepLength;
            stepLength = (_max - _min) / Program.countIntervalStatistics;

            double left, right;
            left = _min + (i - 1) * stepLength;
            right = _min + i * stepLength;

            foreach (double elem in _listParam)
            {
                if (elem >= left && elem < right) k++;
            }

            return k;
        }

    }
}
