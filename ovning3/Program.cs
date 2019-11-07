using System;

namespace ovning3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nSkriv ditt namn:");
            string name = Console.ReadLine();

            Console.Write("\nHej " + name + "!\n\nHur gammal är du?\n");
            string alder = Console.ReadLine();
            int xar = Convert.ToInt32(alder);

            int alderidagar = xar * 365;

            Console.Write("\nDu har levt i " + alderidagar + " dagar.\n");
        }
    }
}
