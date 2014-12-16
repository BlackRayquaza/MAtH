using System;
using System.IO;
using Functions;

namespace rotmgstats
{
    class Program
    {
        static void Main(string[] args)
        {
            string CurrentProgram;
            bool DebugMode = true;
            
            CurrentProgram = Console.ReadLine().ToLower();

            if ((CurrentProgram == "" && DebugMode) || (CurrentProgram == "hp"))
            {
                FConsole.Print("Hello");
                Console.Beep();

                Random rand = new Random();
                int hp = int.Parse(Console.ReadLine());

                if (hp == 130)
                {
                    for (int i = 0; i < 21; i++)
                    {
                        hp += rand.Next(25, 31);
                        FConsole.Print(hp);
                    }
                } else  {
                    int min = int.Parse(Console.ReadLine());
                    int max = int.Parse(Console.ReadLine());
                    for (int i = 0; i < 21; i++)
                    {
                        hp += rand.Next(min, max);
                        FConsole.Print(hp);
                    }

                }
         
            FConsole.Sleep(2000);
            FConsole.Print("");
            FConsole.Print("Press 'ESC' or 'Enter' to stop the application.");
            Console.ReadLine();
            } else { 
                FConsole.Print("No program was selected");
                FConsole.Print("Press 'ESC' or 'Enter' to stop the application.");
                Console.ReadLine();
            }
        }
    }
}
