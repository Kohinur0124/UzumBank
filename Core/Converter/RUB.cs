using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Converter
{
    public  class RUB
    {
        public static double CourseUZS { set; get; } = 136.53;

        public static double CourseEUR { set; get; } = 0.011;

        public static double CourseUSD { set; get; } = 0.012;

        public static string ToUZS(double rub)
        {
            return $"{rub * CourseUZS} UZS";
        }

        public static string ToEUR(double rub)
        {
            return $"{rub * CourseEUR} EUR";
        }

        public static string ToUSD(double rub)
        {
            return $"{rub * CourseUSD} UDS";
        }
    }
}
