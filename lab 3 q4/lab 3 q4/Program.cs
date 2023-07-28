using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_3_q4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter num:");
            int no = int.Parse(Console.ReadLine());

            int tt = 0;

            while (no > 0)
            {
                int dt = no % 10;

                if (no % 2 == 1)
                {
                    tt += dt;
                }
                no /= 10;
            }

            Console.WriteLine("Sum of the Digit = {0}", tot);



        }
    }
}
