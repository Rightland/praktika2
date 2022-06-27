using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculate
{
    class Sinus : ITwoArgumentsCalculator
    {


        public  double Calculate(double a,double b)
        {
            return Math.Sin(a);
        }
    }
}
