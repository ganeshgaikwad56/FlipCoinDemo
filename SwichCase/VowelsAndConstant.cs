using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwichCase
{
    public class VowelsAndConstant
    {
        public static void CheckVowelsAndConstant()
        {
            Console.WriteLine("Enter any Charecter");
            char charecter=Convert.ToChar(Console.ReadLine());
            if (charecter == 'a' || charecter == 'e' || charecter == 'i' || charecter == 'o' || charecter == 'u' || charecter == 'A' || charecter == 'E' || charecter == 'I' || charecter == 'O' || charecter == 'U') 
            {
                Console.WriteLine(charecter+ " is Vowel");
            }
            else if ((charecter>='a' && charecter<='z')||(charecter>='A' && charecter<='Z'))
            {
                Console.WriteLine(charecter + " Is Constant");
            }
            else
            {
                Console.WriteLine("Enter Valid Charecter");
            }
        }
    }
}
