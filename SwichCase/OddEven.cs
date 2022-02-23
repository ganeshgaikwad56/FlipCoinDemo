using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwichCase
{
    public class OddEven
    {
        public static void OddandEven()

        {
            Console.WriteLine("Enter The Number");

            int N =Convert.ToInt32(Console.ReadLine());

            if (N%2==0)
            {
                Console.WriteLine("The number is even");
            }
            else
            {
                Console.WriteLine("The number is odd");
            }
        }
    }
}
