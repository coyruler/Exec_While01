using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1+2+3+4+5+...+n<105
            int value = 0;
            int result = 0;
            while (result < 105)
            {
                value++;
                result += value;
            }
            
            Console.WriteLine(value - 1);


            //105-1-2-3...-n<0

            //int value2 = 0;
            //int result2 = 105;
            //while (result2>0)
            //{
            //    value2++;
            //    result2 -= value2;

            //}
            //Console.WriteLine(value2 - 1);

        }
    }
}
