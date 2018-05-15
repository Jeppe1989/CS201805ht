using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave_4___10_tabel
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int x = 1; x < 11; x++)
            {
                for (int y = 1; y < 11; y++)
                {
                    string number = (x * y).ToString();
                    if ((x * y) > 50)
                        Console.ForegroundColor = ConsoleColor.Yellow;
                    else
                        Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(number.PadLeft(4));
                }
                Console.WriteLine();
            }

            
        }
    }
}
