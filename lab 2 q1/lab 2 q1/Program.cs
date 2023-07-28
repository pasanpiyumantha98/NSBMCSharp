using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2_q1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Give value for number 1 : ");
            int n01 = int.Parse(Console.ReadLine());
            Console.Write("Give value for number 2 : ");
            int n02 = int.Parse(Console.ReadLine());
            int sum=n01+n02;

            Console.Write("Sum =  "  + sum);


        }
    }
}
