using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatheProjekt.MatheProjekt_8.Functions
{
    /// <summary>
    /// Interface for functions.
    /// </summary>
    interface IFunction
    {
        double GetY(double input, bool deriv = false);
    }
}
