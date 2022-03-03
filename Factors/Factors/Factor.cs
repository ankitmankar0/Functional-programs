using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factors
{
    internal class Factor
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("please enter the n: ");
            int number = Convert.ToInt32(Console.ReadLine());
            Program p = new Program();
            p.Factorial (number);
        }
    }
}
