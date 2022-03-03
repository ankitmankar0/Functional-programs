using System;

namespace EvenOdd
{
    internal class Program
    {
        public static void Main()
        {
            int num, rem;
            Console.Write("Input an integer : ");
            num = Convert.ToInt32(Console.ReadLine());
            rem = num % 2;
            if (rem == 0)
                Console.WriteLine("{0} is an even integer.\n", num);
            else
                Console.WriteLine("{0} is an odd integer.\n", num);
        }
    }
}
