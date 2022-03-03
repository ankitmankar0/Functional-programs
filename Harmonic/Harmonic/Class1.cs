using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harmonic
{
    internal class Class1
    {
        double result = 0;
        public void Hormonic(int n)
        {
            while (n != 0)
            {
                result = result + 1/ (float) n;
                n--;
            }
            //for (int i = 1; i <= n; i++)
            //{
            //   result = result + 1/(float) i;
            //}
            Console.WriteLine($"Harmonic Number: " + result);
        }
    }
}
