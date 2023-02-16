using System;
namespace SomeConsoleApplication
{
    public class Program
    {
        static void Main(string[] args)
        {
            var iAmTrue = (new Random().Next(10) % 2 == 2);
            if (iAmTrue)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }

            Console.ReadKey();
        }

        public static bool AlwaysReturnsTrue()
        {
            return true;
        }

        public static object Passthrough(object obj)
        {
            return obj;
        }
    }
}
