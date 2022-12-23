using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    public class FlipCoins
    {
        public static void Coinsflip()
        {
            Console.WriteLine("Enter the number of time to flip the coin");
            int a=Convert.ToInt32(Console.ReadLine());

            int Headcount = 0;
            int Tailcount = 0;
            int i;
            for (i = 0; i < a; i++)
            {
                Random random = new Random();
                int num = random.Next(2);
                Console.WriteLine(num);

                if (num == 1)
                {
                    Headcount++;
                }
                else
                {
                    Tailcount++;
                }
            }
            double HeadscountPercentage = Convert.ToDouble(Headcount * 100 / a);
            double TailscountPercentage = Convert.ToDouble(Tailcount * 100 / a);


            Console.WriteLine("No of headcounts : " + Headcount);
            Console.WriteLine("No of tailcounts : " + Tailcount);
           
            Console.WriteLine("Percentage of Heads Count = " + HeadscountPercentage +"%");
            Console.WriteLine("Percentage of Tails Count = " + TailscountPercentage +"%");
        }
    }
}
