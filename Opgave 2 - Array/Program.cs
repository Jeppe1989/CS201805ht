using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave_2___Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] løn = { 10000, 20000, 15000, 20000, 30000, 15000 };

            double sum = 0;
                       
            for (int i = 0; i < løn.Length; i++)
            {
                Console.WriteLine(løn[i]);
            }
                        

            for (int i = 0; i < løn.Length; i++)
            {
                sum += løn[i];
                
            }

            double avg = sum / løn.Length;
            
            
            Console.WriteLine("Gennemsnit " + avg);

            
        

        }
    }
}
