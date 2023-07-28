using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_7_Q1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter the size for arrays - ");
            int sizee=int.Parse(Console.ReadLine());

           
            int[] arrr1 = new int[sizee];   
            int[] arrr2 = new int[sizee];
            int[] arrr3 = new int[sizee];


            //take inputs for array 1
            for (int i=0;i<arrr1.Length;i++)
            {
                Console.Write(i + "- ");
                arrr1[i] = int.Parse(Console.ReadLine());

            }

            //take inputs for array 2
            for (int i = 0; i < arrr2.Length; i++)
            {
                Console.Write(i + "- ");
                arrr2[i] = int.Parse(Console.ReadLine());

            }


            int ssum = 0;

            //scalar sum for array 1
            for (int i = 0; i < arrr1.Length; i++)
            {
                ssum = ssum + arrr1[i];

            }

            Console.WriteLine("The Scalar sum of array 1 is" + ssum);

            ssum = 0;

            //scalar sum for array 2
            for (int i = 0; i < arrr1.Length; i++)
            {
                ssum = ssum + arrr1[i];

            }

            Console.WriteLine("The Scalar sum of array 1 is" + ssum);

            //vector sum
            for (int i = 0; i < arrr1.Length; i++)
            {
                arrr3[i] = arrr1[i] + arrr2[i];
                Console.Write(arrr3[i] + " ");

            }

            Console.WriteLine("");

            //vector product
            for (int i = 0; i < arrr1.Length; i++)
            {
                arrr3[i] = arrr1[i] * arrr2[i];
                Console.Write(arrr3[i] + " ");

            }

            Console.WriteLine("");


            ssum = 0;

            //Scalar product
            for (int i = 0; i < arrr1.Length; i++)
            {
                ssum = ssum + arrr3[i];
               

            }

            Console.WriteLine("The scalar product is " + ssum);




















        }
    }
}
