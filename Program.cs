using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number to start counting from: ");
            int num = int.Parse(Console.ReadLine());

            Console.Write("Enter the number to stop counting to: ");
            int numf = int.Parse(Console.ReadLine());

            for (int c = num; c <= numf; c++)
            {

                int sum = 0;
                for (int x = 1; x < c; x++)
                {
                    if (c % x == 0)
                        sum += x;
                    else
                        continue;
                }
                if (sum == c)
                {
                    Console.WriteLine(c);
                }

            }


            Console.ReadKey();

        }
    }
}
