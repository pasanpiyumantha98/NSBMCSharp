using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace lab_6
{
    internal class Arr
    {

        



        public void Arry(int size)
        {
            int[] numset = new int[size];

            for(int i = 0; i < numset.Length; i++) 
            {

                Console.Write(i + "-");
                numset[i] = int.Parse(Console.ReadLine());                

            
            }

            for (int i = 0; i < numset.Length; i++)
            {

                Console.Write("U.Input 0 " + numset[i] + "  ");
                


            }




        }


    }
}
