using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGuessingGme
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int winNum = r.Next(0, 100);

            bool win = false;

            do
            {
                Console.WriteLine("Guess a number between 1 and 100");
                string n = Console.ReadLine();

                int i = int.Parse(n);

                if (i > winNum)
                {
                    Console.WriteLine("To High! Guess Lower...");
                }
                else if (i < winNum)
                {
                    Console.WriteLine("Too Low! Guess Higher...");
                }
                else if (i == winNum)
                {
                    Console.WriteLine("You WIN!!!");
                    win = true;
                }

                
            } while (win == false);

            Console.WriteLine("Thank you for playing");
            Console.Write("Press any key to continue");
            Console.ReadKey(true);
        }
    }
}
