using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Disser
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormMain());
        }

        public static int step = 1;
        public static bool methodSrednego = false;

        public static bool SaveOD = true;
        public static bool SaveODmin = true;
        public static bool SaveODmax = true;
        public static bool SaveLImg = true;
        public static bool SaveLEtalon = true;
        public static bool SavePoint = true;
        public static bool SaveKpropusk = true;
        public static bool SaveKabsorption = true;
        public static bool SavePabsorption = true;
        public static bool SavePerimeter = true;
        public static bool SaveSquare = true;

        public static int countIntervalStatistics = 10;

    }
}
