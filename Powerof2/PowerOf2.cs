using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Powerof2
{
    public class PowerOf2
    {
    public void PowerOfTwo()
        {
            int N;
            int baseNum = 0;
           

            Console.WriteLine("Enter a Expoent : ");
            N=Convert.ToInt32(Console.ReadLine());

            //condition to giving the range of 1 to 32

            if(0 <= N && N <= 31)
            {
                for(int i = 0; i < N; i++)
                {
                    if (i == 0)
                    {
                        baseNum = 1;
                    }
                    else
                    {
                        baseNum = baseNum * 2;
                    }
                    Console.WriteLine("2^{0} ={1}", i,baseNum);
                }
            }
        }

    }
}
