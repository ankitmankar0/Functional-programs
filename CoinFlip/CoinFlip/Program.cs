using System;

namespace CoinFlip
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter the Number! ");
            int number =Convert.ToInt32(Console.ReadLine());

            FlipCoin f = new FlipCoin();
            f.FliptheCoin(number);
        }
    }
}

