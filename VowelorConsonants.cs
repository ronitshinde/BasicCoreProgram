using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    public class VowelorConsonants
    {
        public static void Alphabets()
        {
            Console.WriteLine("Enter any Character : ");

            char Alp =Convert.ToChar(Console.ReadLine());


            if (Alp == 'a' || Alp == 'e' || Alp == 'i' || Alp == 'o' || Alp == 'u' ||
                  Alp == 'A' || Alp == 'E' || Alp == 'I' || Alp == 'O' || Alp == 'U')

            {
                Console.WriteLine(Alp + " Alphabet is vowels ");
            }

            else if ((Alp >= 'a' && Alp <= 'z') || (Alp >= 'A' && Alp <= 'Z'))

            { 
                Console.WriteLine( Alp + " Alphabet is Consonant ");
            }
        }
    }
}
