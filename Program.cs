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
            double samplingRate = 1;
            int index = 1;
            while (true)
            {
                switch (index)
                {
                    case 1:
                    case 2:
                    case 3:
                        Console.ForegroundColor = ConsoleColor.Red;
                        break;
                    case 4:
                    case 5:
                    case 6:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Green;
                        break;
                }
                double dx = Integrate.IntegrateFunction(0, 2, samplingRate, new Sigmoid());
                Console.WriteLine("├ #" + index++ + " ┼ Sigmoid integral: " + dx + " on sampling rate: " + samplingRate);
                samplingRate /= 10;
            } 
        }
    }
}
