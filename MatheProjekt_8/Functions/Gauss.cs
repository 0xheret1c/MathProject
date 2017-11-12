using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatheProjekt.MatheProjekt_8.Functions
{
    class Gauss : IFunction
    {
        public double GetY(double input, bool deriv = false)
        {
            double y = 0;
            double x = input;
            if (deriv)
            {
                throw new NotImplementedException();
            }
            else
            {
                y = Math.Pow(Math.E, Math.Pow(-x, 2)); 
                return y;
            }
        }
    }
}
