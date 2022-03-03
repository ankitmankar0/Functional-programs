using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Demo
{
    class Largest
    {
        static void Main(string[] args)
        {
            int num1, num2, num3;
            Console.WriteLine("Enter the three Numbers" );
            num1 = Convert.ToInt32(Console.ReadLine());
            num2 = Convert.ToInt32(Console.ReadLine());
            num3 = Convert.ToInt32(Console.ReadLine());
            // set the value of the three numbers
            if (num1 > num2)
            {
                if (num1 > num3)
                {
                    Console.Write("Number one is the largest!\n" + num1);
                }
            }
            else if (num2 > num3)
                Console.Write("Number two is the largest!\n" + num2);
            else
                Console.Write("Number three is the largest!\n" + num3);
        }
    }
}
