using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwichCase
{
    public class QuotientAndRemindere
    {
        public static void FindQuotientAndRemindere()
        {
            int divident = 78, divisor = 8;

            int quotient = divident / divisor;
            int reminder=divident % divisor;

            Console.WriteLine("Divident : {0}, Divisor: {1}",divident, divisor);
            Console.WriteLine("Quotient = " + quotient);
            Console.WriteLine("Reminder = " + reminder);
        }

    }
}
