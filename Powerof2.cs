using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlipCoin
{
    public class Powerof2
    {
        public static void Power()
        {
            Console.WriteLine(powertwo(32));
            Console.ReadLine();
        }
        static bool powertwo(ulong input)
        { 
            return (input&(input-1))==0;

        }
        
    }
}
