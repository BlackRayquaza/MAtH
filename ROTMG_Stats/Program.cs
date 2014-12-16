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

            for (int i = 0; i < 21; i++)
            {
                Random rand = new Random();
                int hp = 130;

                hp = hp + rand.Next(25, 31);
                FConsole.Sleep(10);
                FConsole.Print(hp);

                using (var writer = new StreamWriter("rotmgstats_hp.output"))
                {
                    writer.WriteLine("[{0}] {1}", System.DateTime.Now, hp);
                }
                // Seems like this needs to be fixed lol http://gyazo.com/9a0b9fd6de02f576aff442b1dd095696.png
            }
         
            FConsole.Sleep(2000); // 2 Second sleep before end
            FConsole.Print(""); // Empty Line
            FConsole.Print("Press 'ESC' to stop the application.");
            Console.ReadLine(); // Waiting for close
        }
    }
}
