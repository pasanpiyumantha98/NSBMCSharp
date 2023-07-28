using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace lab_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size;

            Arr nset = new Arr();


            Console.WriteLine("Enter the size for the array-");
            size = int.Parse(Console.ReadLine());

            nset.Arry(size);






        }
    }
}
