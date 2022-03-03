using System;

namespace Project_Euler_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int b = 1;

            while(b <= 21)
            {
                if(a % b == 0)
                {
                    b++;
                } else
                {
                    a++;
                    b = 1;
                }
            }
            Console.WriteLine(a);
        }
    }
}
