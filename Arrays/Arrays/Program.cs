using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] sim = new string[100];

            for (int i = 0; i < 100; i++)
            {
                if (i % 5 == 0 && i % 3 == 0 && i != 0)
                {

                    sim[i] = i + ".  FizzBuzz";
                }
                else if (i % 3 == 0 && i != 0)
                {
                    sim[i] = i + ".  Fizz";
                }
                else if (i % 5 == 0 && i != 0)
                {
                    sim[i] = i + ".  Buzz";

                }
                else
                {
                    sim[i] = i + ". ";
                }

            }

            for(int i = 0; i< sim.Length; i++)
            {
                Console.WriteLine(sim[i]);
            }
        }
    }
}
