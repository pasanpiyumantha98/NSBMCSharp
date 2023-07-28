using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_1_q2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float rd;

            Console.Write("Enter the radius  : ");
             rd = float.Parse(Console.ReadLine());
            Console.Write("The area = {0} ", 3.14 * rd * rd);

        }
    }
}
