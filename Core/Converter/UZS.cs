using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Converter
{
    public  class UZS
    {
        public static double CourseUSD { set; get; } = 0.000087;

        public static double CourseEUR { set; get; } = 0.00008;

        public static double CourseRUB { set; get; } = 0.0073;

        public static string ToUSD(double uzs)
        {
            return $"{(uzs * CourseUSD)} USD";
        }

        public static string ToEUR(double uzs)
        {
            return $"{uzs * CourseEUR} EUR ";
        }
       
        public static string ToRUB(double uzs)
        {
            return $"{uzs * CourseRUB} RUBL";
        }
    }
}
