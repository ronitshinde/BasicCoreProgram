using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    public class QuotientRemainder
    {
        public static void QRemainder()
        {
            Console.WriteLine("Enter the value of dividend");
            int dividend = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the value of divisor");
            int divisor = Convert.ToInt32(Console.ReadLine());

            int quotient = (dividend / divisor);
            int remainder = (dividend % divisor);

            //Console.WriteLine("Dividend : {0} Divisor : {1}" ,dividend,divisor);
             Console.WriteLine("Dividend : " + dividend + " and Divisor : " + divisor);

            Console.WriteLine("Quotient = " + quotient);
            Console.WriteLine("Remainder = " + remainder);
        
        }
    }
}
