using System;

namespace Project_Euler_2
{
    class Program
    {
        /*Fibonacci even numbers*/
        static void Main(string[] args)
        {
            int a = 1;
            int b = 1;
            int c = 0;
            int sum = 0;
            for (int i = 0; c < 4000000; i++)
            { 
                c = a + b;
                a = b;
                b = c;
                if(c % 2 == 0)
                {
                    sum = sum + c;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
