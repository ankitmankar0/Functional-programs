using System;

namespace PowerOf
{
    internal class Program
    {
            public static void Main(string[] args)
        {
            Console.WriteLine("please enter the Power of 2: " );
            int number =Convert.ToInt32(Console.ReadLine());
            PowerOfTwo p = new PowerOfTwo();
            p.Power(number);
        }
    }
}
