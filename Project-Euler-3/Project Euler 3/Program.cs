using System;

namespace Project_Euler_3
{
    class Program
    {
        static void Main(string[] args)
        {

            decimal myNumber = 600851475143; //600851475143
            decimal counter = 0;
            for (decimal i = 2; i < Math.Ceiling(myNumber / 2); i++)
            {
                if (myNumber % i == 0)
                {
                    if ((myNumber / i) % 2 != 0)
                    {
                        for (decimal j = 2; j < Math.Ceiling((myNumber / i) / 2); j++)
                        {
                            if ((myNumber / i) % j == 0)
                            {
                                counter++;
                                break;
                            }
                        }
                        if (counter == 0)
                        {
                            Console.WriteLine((myNumber / i));
                            Console.WriteLine("We found the cherished number");
                            break;
                        }
                        else
                        {
                            counter = 0;
                        }
                    }
                }
                //Console.WriteLine(count);
            }
        }
    }
}
