using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Converter
{
    public  class USD
    {
        public static double CourseUZS { set; get; } = 11498.69;

        public static double CourseEUR { set; get; } = 0.92;

        public static double CourseRUB { set; get; } = 84.21;

        public static string ToUZS(double usd)
        {
            return $"{usd * CourseUZS} UZS";
        }

        public static string ToEUR(double uzs)
        {
            return $"{uzs * CourseEUR} EUR";
        }

        public static string ToRUB(double usd)
        {
            return $"{usd * CourseRUB} RUBL";
        }
    }
}
