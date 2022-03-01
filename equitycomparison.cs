using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linecomparison_day3
{
    public class equitycomparison
    {
        public static void comparingline()
        {
            int line1 = 5;
            int line2 = 10;

            int value = line1.CompareTo(line2);

            if (line2 == line1)
            {
                Console.WriteLine("Lines are equal");
            }
            else if (line2 > line1)
            {
                Console.WriteLine("line2 is greaterthan line1");
            }
            else
            {
                Console.WriteLine("line2 is lessthan line1");
            }
        }
    }
}
