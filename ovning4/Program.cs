using System;

namespace ovning4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nÄr det fint väder?\n");
            string svar = Console.ReadLine();
            string svarUp = svar.ToUpper();

            if(svarUp == "J" || svarUp == "JA" || svarUp == "YES" || svarUp == "YEP" || svarUp == "MJO"){
                Console.Write("\nDu ska nog gå på picknick!\n");
            }else if(svarUp == "N" || svarUp == "NEJ" || svarUp == "No" || svarUp == "NOP" || svarUp == "NJA"){
                Console.Write("\nDu borde stanna hemma och läsa en bok om programmering!\n");
            }else {
                Console.Write("\nJag förstår inte riktigt!\n");
            }
        }
    }
}
