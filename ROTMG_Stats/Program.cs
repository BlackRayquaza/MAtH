using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rotmgstats
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi!");

            for (int i = 0; i < 21; i++)
            {
                Random rand = new Random();
                int hp = 130;
                hp = hp + rand.Next(25, 31);
                Console.WriteLine(hp);

                using (var fw = new StreamWriter(path: "rotmgstats_hp.output"))
                {
                    fw.WriteLine("[{0}] {1}", System.DateTime.Now, hp);
                }
            }
            // Seems like this needs to be fixed lol http://gyazo.com/9a0b9fd6de02f576aff442b1dd095696
            Console.WriteLine("Press 'ESC' to stop the application.");
            Console.ReadLine();
        }
    }
}
