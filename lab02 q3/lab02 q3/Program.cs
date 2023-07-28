using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab02_q3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter R : ");
            int rd = int.Parse(Console.ReadLine());

            Console.Write("Area = {0}", 3.14 * rd * rd);

            Console.Write("Circumference = {0}", 2 * 3.14 * rd);

        }
    }
}
