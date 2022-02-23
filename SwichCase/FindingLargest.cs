using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwichCase
{
    public class FindingLargest
    {
        public static void FindLargestNumber()
        {
            int num1, num2, num3;
            Console.WriteLine("Find the largesst among three numbers: ");
            Console.WriteLine("Input the first number");
            num1 =Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the 2nd Number");
            num2 =Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input The 3rd number");
            num3 =Convert.ToInt32(Console.ReadLine());

            if (num1 > num2 && num1 > num3)
            {
                Console.WriteLine(num1 + " is greater among three");
            }
            else if (num2 > num3 && num2 > num1)
            {
                Console.WriteLine(num2 + " is greater among three");
            }
            else
            {
                Console.WriteLine(num3 + " is greater among three");
            }
        }
    }
}
