using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    public class SwipeNumbers
    {
        public static void SwipeNum()
        {
            Console.WriteLine("Enter value of a");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter value of b");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Value before swap a = "+a +", b = " +b);
            //Console.WriteLine("Value of b : " + a);

            a = a * b;
            b = a / b;
            a = a / b;

            Console.WriteLine("Value after swap a = " + a + ", b = " +b);
        }    
    }
}
