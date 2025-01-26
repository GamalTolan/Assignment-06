using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Assignment_06.Duration;

namespace Assignment_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1

            Time D1 = new Time(1, 10, 15);
            Console.WriteLine(D1.ToString());

            Time D2 = new Time(3600);
            Console.WriteLine(D2.ToString());

            Time D3 = new Time(7800);
            //Console.WriteLine(D3.ToString());

            //Time D4 = new Time(666);
            //Console.WriteLine(D4.ToString());

            Console.WriteLine("======================================");

            #endregion

            #region 2

            //D3 = D1 + D2;
            //Console.WriteLine(D3.ToString());

            //D3 = D1 + 7800;
            //Console.WriteLine(D3);

            //D3 = 666 + D3;
            //Console.WriteLine(D3);

            //D3 = ++D1;
            //Console.WriteLine(D3);

            //D3=--D1;
            //Console.WriteLine(D3);

            //D1 = D1 - D2;
            //Console.WriteLine(D1);

            if(D1 > D2)
            {
                Console.WriteLine("D1 is greater than D2");
            }
            else
            {
                Console.WriteLine("D1 is not greater than D2");
            }

            if(D1 <= D2)
            {
                Console.WriteLine("D1 is less than or equal to D2");
            }
            else
            {
                Console.WriteLine("D1 is not less than or equal to D2");
            }

            // if (D1) ????

            //DateTime Obj = (DateTime) D1 ?




            #endregion
        }
    }
}
