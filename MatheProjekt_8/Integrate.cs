using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MatheProjekt.MatheProjekt_8.Functions;

namespace MatheProjekt.MatheProjekt_8
{
    /// <summary>
    /// Basic class for integration.
    /// </summary>
    static class Integrate
    {
        /// <summary>
        /// Integrates the given IFunction.
        /// </summary>
        /// <param name="a">Interval value a.</param>
        /// <param name="b">Interval value b.</param>
        /// <param name="samplingRate">
        /// The sampling rate. The smaller the better, 
        /// but it will take more time to calculate.
        /// </param>
        /// <param name="function">The function that will be integrated.</param>
        /// <returns></returns>
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
