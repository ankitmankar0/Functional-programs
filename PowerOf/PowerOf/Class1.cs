using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerOf
{
    internal class PowerOfTwo
    {
        double result = 1;
        public void Power(int n)
        {
            while (n != 0)
            { 
                result *= 2;
                n--;
            }
            //for (int i = 0; i < n; i++)
            //{
            //   result *= 2;
            //}
            Console.WriteLine($"Power Of 2^{n}: " + result);
        }
        
    }
}
