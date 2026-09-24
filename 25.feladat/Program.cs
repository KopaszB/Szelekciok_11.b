using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25.feladat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Kérjen be 2 számot és a nagyobbat ossza el a kisebbel! Az eredményt 2 tizedesjegy
pontossággal írja ki! (Nullával nem lehet osztani!)*/

            Console.Write("Első szám: ");
            int szam1 = int.Parse(Console.ReadLine());

            Console.Write("Második szám: ");
            int szam2 = int.Parse(Console.ReadLine());

            if (szam1 > szam2)
            {
                Console.WriteLine($"{szam1} / {szam2} = {(double)szam1 / szam2:F2}");
            }
            else if (szam2 > szam1)
            {
                Console.WriteLine($"{szam2} / {szam1} = {(double)szam2 / szam1:F2}");
            }
            else
            {
                Console.WriteLine($"{szam1} = {szam2}");
            }

            Console.ReadKey();
        }
    }
}
