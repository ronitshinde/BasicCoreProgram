using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    public class LeapYear
    {
        public static void Knowleapyear()
        {
            Console.WriteLine("Enter 4 digits only");
            int year = Convert.ToInt32(Console.ReadLine());
            
            if (year >= 1000 && year <= 9999)
            {
                int x = year % 4;
                int y = year % 100;
                int z = year % 400;

                if (z == 0 ) 
                {
                    Console.WriteLine("Given year is leap year : " + year);
                }
                else if (y == 0)
                {
                    Console.WriteLine("Given year is not a leap year : " + year);
                }
                else if (x == 0)
                {
                    Console.WriteLine("Given year is a leap year : " + year);
                }
                else
                {
                    Console.WriteLine("Given year is not a leap year : " + year);
                }

            }
            else
            {
                Console.WriteLine("Enter only 4 digits");
            }
        }    
    }
}