using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2_q5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] digits = new int[10];

            for (int a = 0; a < digits.Length; a++)
            {
                Console.Write("Enter the value {0} : ", a);
                digits[a] = int.Parse(Console.ReadLine());
            }

            for (int j = 0; j < digits.Length; j++)
            {
                if (digits[j] % 2 == 0)
                {
                    Console.WriteLine("The number {0} is Even number", j);
                }
                else
                {
                    Console.WriteLine("The number {0} is ODD number", j);
                }
            }

        }
    }
}
