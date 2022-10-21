using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //使用while,在畫面顯示所有可以整除300的整數
            //例如:1,2,3,4,5,6,10,...,300
            int num1 = 1;


            while ( num1 <=300 )
            {
                if(300 % num1 == 0)
                {
                    Console.WriteLine(num1);
                }
                num1++;                
            }
        }
    }
}
