using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatheProjekt.MatheProjekt_8.Functions
{
    /// <summary>
    /// Sigmoid function:
    /// f(x) = 1/(1+e^⁻x); 
    /// f'(x) = f(x) * 1 - f(x);
    /// </summary>
    class Sigmoid : IFunction
    {
        /// <summary>
        /// Returns the y value for the given x value.
        /// </summary>
        /// <param name="input">The x value.</param>
        /// <param name="deriv">
        /// Specifies if the derivate of the function
        /// will be used.
        /// </param>
        /// <returns>The y value for the given x value.</returns>
        public double GetY(double input, bool deriv = false)
        {
            double y = 0;
            double x = input;
            if (deriv)
            {
                double fx = GetY(x, false);
                y = fx * 1 - fx; // The derivate of sig()
                return y;
            }
            else
            {
                y = 1 / (1 + Math.Pow(Math.E, -x)); // sig()
                return y;
            }
        }
    }
}
