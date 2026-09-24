using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22.feladat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kérek egy számot: ");
            int szam = int.Parse(Console.ReadLine());

            if (szam%3==0)
            {
                Console.WriteLine($"A(z) {szam} osztható 3-al");
            }
            else
            {
                Console.WriteLine($"A(z) {szam} nem osztható 3-al");
            }

            Console.ReadKey();
        }
    }
}
