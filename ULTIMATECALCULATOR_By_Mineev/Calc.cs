using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ULTIMATECALCULATOR_By_Mineev
{
    class Calc
    {
        public static double Div(double a, double b)
        {
            return a / b;
        }
        public static double Pow(double a, double b)
        {
            return Math.Pow(a, b);
        }
        public static double Mult(double a, double b)
        {
            return a * b;
        }
        public static double Sub(double a, double b)
        {
            return a - b;
        }
        public static double Sum(double a, double b)
        {
            return a + b;
        }
        public static double Percent(double a, double b)
        {
            return a % b;
        }
        public static double SQRT(double a)
        {
            return Math.Sqrt(a);
        }
    }
}
