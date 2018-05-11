using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_6
{
    class Program
    {
        static void Main(string[] args)
        {
            // i++  i=i+1
            int vertiba = 4;
            for (int i = 0; i < vertiba; i++) //nosacijums
            {
                Console.WriteLine(i);
            }

            int skaititajs = 0;
            while (skaititajs!=5)
            {
                Console.WriteLine(skaititajs);
                skaititajs++;
            }

            string izvele = "";
            double rezultats;
            while  (izvele != "iziet") // nosacijumu parbauda sakuma!
            {
                Console.WriteLine("Saskaitit vai iziet?");
                izvele = Console.ReadLine();

                if (izvele == "saskaitit")
                {
                    Console.WriteLine("Ievadiet: ");
                    double sk1 = Convert.ToDouble(Console.ReadLine());
                    double sk2 = Convert.ToDouble(Console.ReadLine());
                    rezultats = Calculator(sk1, sk2);
                    Console.WriteLine("Rezultats: " + rezultats);
                }
            }

            do // nosacijumu parbauda beigas! Vismaz vienu reizi ciklu izpildis!
            {

            }
            while (izvele != "iziet");

            Console.ReadLine();
        }
        static double Calculator (double a, double b)
        {
            return a + b;
        }
    }
}
