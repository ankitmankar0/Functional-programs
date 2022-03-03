using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeapYear
{
        internal class Class1
        {
            static void Main(string[] args)
            {
                Console.Write("Please enter the Year! ");
                int number = Convert.ToInt32(Console.ReadLine());

                Program f = new Program();
                f.LeapYear(number);
            }
        }
    
}
