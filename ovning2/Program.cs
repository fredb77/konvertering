using System;

namespace ovning2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("\nSkriv in ett decimal tal:");
            
            double dTal;
            if (double.TryParse(Console.ReadLine(), out dTal)) {
                int x = Convert.ToInt32(dTal);
                Console.Write("\nHeltalet blev: " + x + "\n");             
            }
            
        }
    }
}
