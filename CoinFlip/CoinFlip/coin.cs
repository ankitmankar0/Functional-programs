using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinFlip
{
        public class FlipCoin
        {

        int Head = 0;
        int Tail = 0;
            public void FliptheCoin( int userinput)
            {
            double temp = userinput;
            Random r = new Random();
            while (userinput != 0)
            {
                double random=r.NextDouble();
                if (random <= 0.5)
                {
                    Tail = Tail + 1;
                }
                else 
                {
                    Head++;
                }

                userinput = userinput - 1;
            }
            Console.WriteLine("HeadCount is :" + (Head * 100) / temp);

            Console.WriteLine("TailCount is :" + (Tail * 100) / temp);

        }
        }
    
}
