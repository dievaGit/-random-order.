using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise16
{
    class Program
    {
        static void Main(string[] args)
        {
            //Defining variables
            int n = 0, x = 0;
            Random value = new Random();

            //Requesting the number of numbers 
            Console.Write(" Enter the number of numbers to process: ");
            n = Convert.ToInt32(Console.ReadLine());

            int[] num = new int[n];

            //Looking for random number and Showing values
            for (int i = 0; i < n; i++)
            {
                if (i == 0)
                {
                    num[i] = value.Next(1, n + 1);
                    Console.Write(" {0} ", num[i]);
                }
                else
                {
                    bool xFound = false;
                    do
                    {
                        xFound = false;
                        x = value.Next(1, n + 1);
                        for (int j = 0; j < i; j++)
                        {
                            if (num[j] == x)
                            {
                                xFound = true;
                                break;

                            }
                        }
                    }
                    while (xFound == true);

                    num[i] = x;
                    Console.Write(" {0} ", num[i]);

                }     

            }
                Console.ReadKey();
        }
    }
}
