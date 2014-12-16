using System;
using System.Threading;

namespace Functions
{
    public class FConsole
    {
        #region Print
        public static void Print()
        {
            Console.WriteLine();
        }

        public static void Print(bool value)
        {
            Console.WriteLine(value);
        }

        public static void Print(char value)
        {
            Console.WriteLine(value);
        }

        public static void Print(char[] buffer)
        {
            Console.WriteLine(buffer);
        }

        public static void Print(decimal value)
        {
            Console.WriteLine(value);
        }

        public static void Print(double value)
        {
            Console.WriteLine(value);
        }

        public static void Print(float value)
        {
            Console.WriteLine(value);
        }

        public static void Print(int value)
        {
            Console.WriteLine(value);
        }

        public static void Print(long value)
        {
            Console.WriteLine(value);
        }

        public static void Print(object value)
        {
            Console.WriteLine(value);
        }

        public static void Print(string value)
        {
            Console.WriteLine(value);
        }

        public static void Print(uint value)
        {
            Console.WriteLine(value);
        }

        public static void Print(ulong value)
        {
            Console.WriteLine(value);
        }

        public static void Print(string format, object arg0)
        {
            Console.WriteLine(format, arg0);
        }

        public static void Print(string format, object arg0, object arg1)
        {
            Console.WriteLine(format, arg0, arg1);
        }

        public static void Print(string format, object arg0, object arg1, object arg2)
        {
            Console.WriteLine(format, arg0, arg1, arg2);
        }

        public static void Print(string format, object arg0, object arg1, object arg2, object arg3)
        {
            Console.WriteLine(format, arg0, arg1, arg2, arg3);
        }

        public static void Print(string format, params object[] arg)
        {
            Console.WriteLine(format, arg);
        }

        public static void Print(char[] buffer, int index, int count)
        {
            Console.WriteLine(buffer, index, count);
        }

        #endregion

        public static void Sleep(int time) // Sleepy....
        {
            Thread.Sleep(time);
        }
    }
}
