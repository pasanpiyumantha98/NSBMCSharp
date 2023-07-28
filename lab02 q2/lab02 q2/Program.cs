using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab02_q2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter the number 1 : ");
            float n1 = float.Parse(Console.ReadLine());
            Console.Write("Enter the number 2 : ");
            float n2 = float.Parse(Console.ReadLine());
            
            Console.Write("Sum = {0}", n1 + n2);

            
            Console.Write("Sub = {0}", n1 - n2);
            
            Console.Write("Mult = {0}", n1 * n2);
            
            Console.Write("Devi = {0}", n1 / n2);

        }
    }
}
