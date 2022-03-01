using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linecomparison_day3
{
    public class linelength
    {

        public static void lengthofline()
        {

            double x1 = 3;
            double y1 = 4;
            double x2 = 4;
            double y2 = 3;

           

            double d =  Math.Sqrt(Math.Pow(x2 - x1, 2) +
                              Math.Pow(y2 - y1, 2) * 1.0);


            Console.WriteLine(" Distance :" + d );
            


        }


        
          
            
        
    }
}
