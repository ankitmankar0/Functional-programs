using System;
 
namespace LeapYear
{
        class Program
        {
            int Year = 0;
        public void LeapYear(int Year)
            {
            if (((Year % 4 == 0) && (Year % 100 != 0)) || (Year % 400 == 0))
                Console.WriteLine("{0} is a Leap Year.", Year);

            else Console.WriteLine("{0} is not a Leap Year.", Year);
            Console.ReadLine();
            }
        
                

        }
}
