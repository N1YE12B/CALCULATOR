using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ULTIMATECALCULATOR_By_Mineev;


namespace ULTIMATECALCULATOR_By_Mineev
{
    class CountAll
    {
        public static double Check(string Text)
        {
            char per = '%';
            char div = '/';
            char mult = '*';
            char sub = '-';
            char sum = '+';
            if (Text.Contains(per))
            {
                
                double ch = 1;
                return ch;
            }
            if (Text.Contains(div))
            {
              
                double ch = 2;
                return ch;
            }
            if (Text.Contains(mult))
            {
              
                double ch = 3;
                return ch;
            }
            if (Text.Contains(sub))
            {
                
                double ch = 4;
                return ch;
            }
            if (Text.Contains(sum))
            {
                
                double ch = 5;
                return ch;
            }

            return 0;
        }

        public static double CAL(double check, double up, double down)
        {


            if (check == 1)
            {
                double result = Calc.Percent(up, down);
                return result;
            }
            if (check == 2)
            {
                double result = Calc.Div(up, down);
                return result;
            }
            if (check == 3)
            {
                double result = Calc.Mult(up, down);
                return result;
            }
            if (check == 4)
            {
                double result = Calc.Sub(up, down);
                return result;
            }
            if (check == 5)
            {
                double result = Calc.Sum(up, down);
                return result;
            }
            return 0;

        }

    }
}
