using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _14_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            TelTotTien(30);
            //int teruggegevenResultaat = Vermenigvuldigen();
            Console.WriteLine((Vermenigvuldigen(4, 9)));
            Console.ReadLine();
        }

        static void TelTotTien(int max)
        {
            for (int i = 0; i <= max; i++)
            {
                Console.WriteLine(i);
            }
        }

        static string Vermenigvuldigen(int getal1, int getal2)
        {
            string resultaat = "Het resultaat is: " + getal1 * getal2;
            return resultaat;
        }
    }

    
}
