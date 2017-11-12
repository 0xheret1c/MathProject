using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MatheProjekt.MatheProjekt_8.Functions;

namespace MatheProjekt.MatheProjekt_8
{
    static class Integrate
    {
        public static double IntegrateFunction(double a, double b, double samplingRate,IFunction function)
        {
            double val = 0;
            for (double x = a; x < b; x+= samplingRate)
            {
                val += function.GetY(x);
            }
            val *= samplingRate;
            return val;
        }

    }
}
