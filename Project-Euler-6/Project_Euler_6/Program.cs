using System;

namespace Project_Euler_6
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime starttime = DateTime.Now;
            long sum1 = 0;
            long sum2 = 0;
            long total = 0;
            for (long i = 1; i < 101; i++)
            {
                sum1 += i;
                sum2 += i * i;
            }
            total = sum1 * sum1 - sum2;
            Console.WriteLine(total);
            DateTime endtime = DateTime.Now;
            Console.WriteLine(endtime - starttime);
        }
    }
}
