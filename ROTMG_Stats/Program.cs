using System;
using System.IO;
using Functions;

namespace rotmgstats
{
    class Program
    {
        static void Main(string[] args)
        {
            Methods.CW("Hello");
            Console.Beep();
            Console.SetWindowSize(width: 65, height: 40);

            for (int i = 0; i < 21; i++)
            {
                Random rand = new Random();
                int hp = 130;

                hp = hp + rand.Next(25, 31);
                Methods.Sleep(10);
                Methods.CW(hp);

                using (var fw = new StreamWriter(path: "rotmgstats_hp.output"))
                {
                    fw.WriteLine("[{0}] {1}", System.DateTime.Now, hp);
                }
                // Seems like this needs to be fixed lol http://gyazo.com/9a0b9fd6de02f576aff442b1dd095696.png
            }

            Methods.Sleep(2000); // End of ROTMG_Stats application.
            Methods.CW("");
            Methods.CW("Press 'ESC' to stop the application.");
            Console.ReadLine();
        }
    }
}
