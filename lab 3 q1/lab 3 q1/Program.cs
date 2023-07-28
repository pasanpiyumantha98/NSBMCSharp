using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_3_q1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter num :");
            int bum = int.Parse(Console.ReadLine());
            if (num % 2 == 0)
            {
                Console.WriteLine("Even Number");
            }
            else
            {
                Console.WriteLine("ODD Number");
            }
        }
    }
}
