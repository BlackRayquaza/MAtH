using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Functions
{
    public class Methods
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
    }
}
