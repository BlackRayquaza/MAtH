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
            
            FConsole.Print("What program do you wanna run?");
            CurrentProgram = Console.ReadLine().ToLower();

            if ((CurrentProgram == "" && DebugMode) || (CurrentProgram == "hp"))
            {
                Console.Beep();

                Random rand = new Random();
                
                FConsole.Print("How much HP?");
                int hp = int.Parse(Console.ReadLine());

                if (hp == 130)
                {
                    for (int i = 0; i < 21; i++)
                    {
                        hp += rand.Next(25, 31);
                        FConsole.Print(hp);
                    }
                } else  {

                    FConsole.Print("Min?");
                    int min = int.Parse(Console.ReadLine());
                    FConsole.Print("Max?");
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
