using System;
using System.Threading;

namespace rotmgstats
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string CurrentProgram;
            bool DebugMode = true;

            Console.WriteLine("What program do you wanna run?");
            CurrentProgram = Console.ReadLine().ToLower();

            if ((CurrentProgram == "" && DebugMode) || (CurrentProgram == "hp"))
            {
                Console.Beep();

                Random rand = new Random();

                Console.WriteLine("How much HP?");
                int hp = int.Parse(Console.ReadLine());

                if (hp == 130)
                {
                    for (int i = 0; i < 21; i++)
                    {
                        hp += rand.Next(25, 31);
                        Console.WriteLine(hp);
                    }
                }
                else
                {
                    Console.WriteLine("Min?");
                    int min = int.Parse(Console.ReadLine());
                    Console.WriteLine("Max?");
                    int max = int.Parse(Console.ReadLine());

                    for (int i = 0; i < 21; i++)
                    {
                        hp += rand.Next(min, max);
                        Console.WriteLine(hp);
                    }
                }

                Thread.Sleep(2000);
                Console.WriteLine("");
                Console.WriteLine("Press 'ESC' or 'Enter' to stop the application.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("No program was selected");
                Console.WriteLine("Press 'ESC' or 'Enter' to stop the application.");
                Console.ReadLine();
            }
        }
    }
}