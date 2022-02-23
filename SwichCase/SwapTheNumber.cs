using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwichCase
{
    public class SwapTheNumber
    {
        public static void CheckSwapTheNumber()
        {
            int num1 = 20, num2 = 60;
            Console.WriteLine("Before Swap Num1= "+num1+ " Num2= "+num2);
            num1 = num1 * num2;
            num2 = num1/num2;
            num1 = num1 / num2;
            Console.WriteLine("After Swap num1= " + num1 + " Num2= " + num2);

        }
    }
}
