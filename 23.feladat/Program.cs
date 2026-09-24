using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23.feladat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*bekér két számot és a nagyobból kivonja a kisebbet. Az eredményt kiírja a képernyőre.*/
            Console.Write("Első szám: ");
            int szam1 = int.Parse(Console.ReadLine());

            Console.Write("Második szám: ");
            int szam2 = int.Parse(Console.ReadLine());

            if (szam1>szam2)
            {
                Console.WriteLine($"{szam1} - {szam2} = {szam1 - szam2}");
            }
            else if (szam2>szam1)
            {
                Console.WriteLine($"{szam2} - {szam1} = {szam2 - szam1}");
            }
            else
            {
                Console.WriteLine($"{szam1} = {szam2}");
            }

            Console.ReadKey();
        }
    }
}
