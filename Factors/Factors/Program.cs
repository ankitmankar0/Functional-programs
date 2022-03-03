using System;

namespace Factors
{
    internal class Program
    {
        int fact = 1;  
        public void Factorial(int n)
        {
            //while (n != 0)
            //{
            //    fact = fact * n;
            //    n--;
            //}
            for (int i=n; i >= 1; i--)
            {
               fact = fact * i;
            }
            Console.WriteLine($"Factorial is: " + fact);
        }
    }
}
