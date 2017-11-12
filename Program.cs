using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MatheProjekt.MatheProjekt_8;
using MatheProjekt.MatheProjekt_8.Functions;

namespace MatheProjekt
{
    class Program
    {
        static void Main(string[] args)
        {
            double samplingRate = 0.00000001;
            while (samplingRate < 1)
            {
                double dx = Integrate.IntegrateFunction(0, 2, samplingRate, new Sigmoid());
                Console.WriteLine("Sigmoid: " + dx + " Sampling Rate: " + samplingRate);
                samplingRate *= 10;
            } 

            Console.ReadKey();
        }
    }
}
