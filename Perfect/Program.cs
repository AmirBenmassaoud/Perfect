using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perfect
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numinput = 0;

            //Get a number input to test
            do
            {
                Console.WriteLine(" Input a number between 1 and 10,000");
                numinput = Convert.ToInt32(Console.ReadLine()
                    );
            } while (numinput < 0 && numinput > 10000);



            // Divide the inputed number by every number up to the input. If evenly, add it to the total
            int total = 0;
            for (int i = 1; i < numinput; i++)
            {
             if (numinput % i== 0)
                {
                    total = total + i;
                }

            }


            if (total == numinput)
            {
                Console.WriteLine(numinput + " is a perfect number.");
            }

            else { Console.WriteLine(numinput + " is not a perfect number."); }

            Console.ReadKey();
               






        }
    }
}
