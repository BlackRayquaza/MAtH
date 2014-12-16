using System;
using System.IO;
using Functions;

namespace rotmgstats
{
    class Program
    {
        static void Main(string[] args)
        {
            FConsole.Print("Hello");
            Console.Beep();

            Random rand = new Random();

            for (int i = 0; i < 21; i++)
            {
                int hp = 130;

                hp += rand.Next(25, 31);
                FConsole.Print(hp);

                // Seems like this needs to be fixed lol http://gyazo.com/9a0b9fd6de02f576aff442b1dd095696.png
            }
         
            FConsole.Sleep(2000); // 2 Second sleep before end
            FConsole.Print(""); // Empty Line
            FConsole.Print("Press 'ESC' to stop the application.");
            Console.ReadLine(); // Waiting for close
        }
    }
}
