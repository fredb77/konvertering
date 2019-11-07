using System;

namespace ovning1
{
    class Program
    {
        static void Main(string[] args)
        {
        
            Console.WriteLine("Skriv tal 1: ");
            string x = Console.ReadLine();
            int x1 = Convert.ToInt32(x);

            Console.WriteLine("Skriv tal 2: ");
            string y = Console.ReadLine();
            int y1 = Convert.ToInt32(y);

            int z = x1 + y1;
            
            Console.Write("\nSumma: " + x1 + " + " + y1 + " = " + z + "\n");

        }
    }
}
