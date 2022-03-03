using System;
using System.Collections.Generic;
using System.Text;

namespace Project_Euler_3
{
    class Class1
    {
        static void bulean (string[] args)
        {
            decimal myNumber = 600851475143; //600851475143
            decimal ost = 0;
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
