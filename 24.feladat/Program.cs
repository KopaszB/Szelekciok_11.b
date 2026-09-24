using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24.feladat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Olvassa be egy hónap számát, majd írja ki, hogy melyik évszakban van az adott hónap.*/
            Console.Write("Kérem a hónap számát(1-12): ");
            byte honap = byte.Parse(Console.ReadLine());

            if (honap == 12 || honap == 1 || honap == 2)
            {
                Console.WriteLine("Tél van.");
            }
            else if (honap == 3 || honap == 4 || honap == 5) 
            {
                Console.WriteLine("Tavasz van.");
            }
            else if (honap == 6 || honap == 7 || honap == 8)
            {
                Console.WriteLine("Nyár van.");
            }
            else if (honap == 9 || honap == 10 || honap == 11)
            {
                Console.WriteLine("Ősz van.");
            }
            else
            {
                Console.WriteLine("Nincs ilyen hónap.");
            }
            Console.ReadKey();
        }
    }
}
