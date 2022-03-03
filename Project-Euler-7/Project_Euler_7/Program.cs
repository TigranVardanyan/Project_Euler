using System;

namespace Project_Euler_7
{
    class Program
    {
        static void Main(string[] args)
        {
            double simpleNumberCount = 1;
            double number = 3;
            double dividers = 0;

            /*for(simpleNumberCount = 1; simpleNumberCount < 10002; simpleNumberCount++)
            {
                for(int i = 2; i < Math.Round(number / 2); i++)
                {
                    if(number % i == 0)
                    {
                        break;
                    }
                }
            }*/
            while(true)
            {
                for(int i = 2; i < Math.Round(number/2); i++)
                {
                    if(number % i == 0)
                    {
                        dividers++;
                    }
                }
                if(dividers > 0)
                {
                    dividers = 0;
                } else
                {
                    simpleNumberCount++;
                    dividers = 0;
                }
                if(simpleNumberCount == 10001)
                {
                    Console.WriteLine(number);
                    break;
                }
                number += 2;
            }
        }
    }
}
