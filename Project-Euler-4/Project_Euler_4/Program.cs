using System;
using System.Collections.Generic;

namespace Project_Euler_4
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime starttime = DateTime.Now;
            //Ваши процедуры
            
            long number = 0;
            int polindrom = 0;
            List<int> myList = new List<int>();
            for (int i = 999; i > 100; i--)
            {
                if(i % 10 == 0)
                {
                    continue;
                }
                for(int j = 999; j >100; j--)
                {
                    string strStart = "";
                    string strEnd = "";
                    if (j % 10 == 0)
                    {
                        continue;
                    }
                    number = i * j;
                    /*Console.WriteLine(number);*/
                    string strNumber = Convert.ToString(number);
                    if (strNumber.Length % 2 == 0)
                    {
                        for (int k = 0; k < strNumber.Length / 2; k++)
                        {
                            strStart = strStart + strNumber[k];
                        }
                        for (int p = (strNumber.Length - 1); p >= strNumber.Length / 2; p--)
                        {
                            strEnd = strEnd + strNumber[p];
                        }
                        /*Console.WriteLine(strStart + " " + strEnd);*/
                        if(strStart == strEnd)
                        {
                            polindrom = Convert.ToInt32(strNumber);
                            if (!myList.Contains(polindrom))
                            {
                                myList.Add(polindrom);
                            }
                        }
                    } else
                    {
                        for (int K = 0; K < (strNumber.Length - 1) / 2; K++)
                        {
                            strStart = strStart + strNumber[K];
                        }
                        for (int P = strNumber.Length -1; P >= (strNumber.Length + 1) /2; P--)
                        {
                            strEnd = strEnd + strNumber[P];
                        }
                        /*Console.WriteLine(strStart + " " + strEnd);*/
                        if (strStart == strEnd)
                        {
                            polindrom = Convert.ToInt32(strNumber);
                            if (!myList.Contains(polindrom))
                            {
                                myList.Add(polindrom);
                            }
                        }
                    }
                }
            }
            myList.Sort();
            myList.Reverse();
            Console.WriteLine("Вывожу все палиндромы в порядке убывания");
            foreach (int li in myList)
            {
                Console.WriteLine(li);
            }
            DateTime endtime = DateTime.Now;
            Console.WriteLine(endtime - starttime);
        }
    }
}
