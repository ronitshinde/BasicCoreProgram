using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    public class Powerof2
    {
        public static void CheckPower()
        {
            Console.WriteLine("Enter the value of N");
            int N = Convert.ToInt32(Console.ReadLine());
            int a = 0;
            int i;
            if(N >= 0 && N < 31)
            {
                for (i = 0; i <= N; i++)
                {
                    a = Convert.ToInt32(Math.Pow(2, i));

                    Console.WriteLine("2 ^ {0} = {1} ", i, a);
                }
               
            }
            else
            {
                Console.WriteLine("Enter the value of N between 0 and 31");
            }
            
        }
    }
}
