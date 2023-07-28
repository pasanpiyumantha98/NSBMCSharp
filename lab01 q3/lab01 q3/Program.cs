using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab01_q3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter value 1 : ");
            int n1 = int.Parse(Console.ReadLine());
            Console.Write("Enter value 2 :  ");
            int n2 = int.Parse(Console.ReadLine());

            int sum = n1 + n2;
            Console.Write("Sumation of numbers  is {0}", +  sum);



        }
    }
}
