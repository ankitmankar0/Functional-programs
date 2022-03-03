using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quotient
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int divD, divS, rem, quo = 0;
            Console.Write("Enter a Divident : ");
            divD = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter a divisor : ");
            divS = Convert.ToInt32(Console.ReadLine());
            if (divD > divS)
            {
                //while (divD >= divS)
                //{
                //   divD = divD - divS;
                //    quo++;
                //}
                //rem = divD;

                quo = divD / divS;
                rem = divD % divS;
               
                Console.WriteLine("\nThe quotient is : " + quo + "\nThe remainder is : " + rem);
            }
            else
                Console.WriteLine("Please enter valid values.");

            Console.ReadLine();
        }

    }
}
