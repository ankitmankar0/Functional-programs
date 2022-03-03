using System;

namespace Swap
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int a = 5, b = 10; int temp;
            Console.WriteLine("Before swap a= " + a + " b= " + b);
            a = a + b; //a=15 (5+10)      
            b = a - b; //b=5 (15-10)      
            a = a - b; //a=10 (15-5)   

            //temp = a;
            //a = b;
            //b = temp;

            Console.Write("After swap a= " + a + " b= " + b);
        }
    }
}
