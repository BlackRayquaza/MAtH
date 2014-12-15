using System;
using System.IO;
using System.Threading;

namespace rotmgstats
{
    class Program
    {
        public static void CW(string message) // Console Write
        {
            Console.WriteLine(message);
        }

        public static void CW(string message, object agrs)
        {
            Console.WriteLine(message, agrs);
        }

        public static void CW(int message)
        {
            Console.WriteLine(message);
        }

        public static void Sleep(int time) // Sleepy....
        {
            Thread.Sleep(time);
        }

        static void Main(string[] args)
        {
            CW("Hello");
            Console.Beep();
            Console.SetWindowSize(width: 65, height: 40);

            for (int i = 0; i < 21; i++)
            {
                Random rand = new Random();
                int hp = 130;

                hp = hp + rand.Next(25, 31);
                Sleep(10);
                CW(hp);

                using (var fw = new StreamWriter(path: "rotmgstats_hp.output"))
                {
                    fw.WriteLine("[{0}] {1}", System.DateTime.Now, hp);
                }
                // Seems like this needs to be fixed lol http://gyazo.com/9a0b9fd6de02f576aff442b1dd095696.png
            }

            Sleep(2000); // End of ROTMG_Stats application.
            CW("");
            CW("Press 'ESC' to stop the application.");
            Console.ReadLine();
        }
    }
}
