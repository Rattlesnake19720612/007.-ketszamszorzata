using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _007.ketszamszorzata
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kérek egy számot! ");
            int szam = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Kérek még egy számot! ");
            int szam2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("A két szám szorzata: " + szam * szam2 + ".");

            Console.ReadKey();
        }
    }
}
