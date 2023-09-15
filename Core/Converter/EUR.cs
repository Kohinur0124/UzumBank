using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Converter
{
    public  class EUR
    {
        public static double CourseUZS { set; get; } = 12553.31;

        public static double CourseUSD { set; get; } = 1.09;

        public static double CourseRUB { set; get; } = 91.94;

        public static string ToUZS(double eur)
        {
            return $"{eur * CourseUZS} UZS";
        }

        public static string ToUSD(double eur)
        {
            return $"{eur * CourseUSD} USD";
        }

        public static string ToRUB(double eur)
        {
             return $"{eur * CourseRUB} RUBL";
        }
    }
}
