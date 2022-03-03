using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harmonic
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("please enter the n: ");
            int number = Convert.ToInt32(Console.ReadLine());
            Class1 p = new Class1();
            p.Hormonic(number);
        }
    }
}
