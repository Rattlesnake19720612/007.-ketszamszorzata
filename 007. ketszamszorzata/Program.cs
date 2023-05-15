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

/*Két egész számot kér be a felhasználótól, megszorozza őket egymással, majd kiírja az eredményt. Az alábbiakban röviden összefoglalom, hogy a program mit csinál:

A program elindul, és a "using" utasításokkal importálja a szükséges könyvtárakat.

Definiáljuk a "Program" osztályt, amely tartalmazza a "Main" metódust, ami a program belépési pontja.

A "Main" metóduson belül a program egy felugró ablakban megjelenít egy üzenetet, ami arra kéri a felhasználót, hogy írjon be egy számot. A felhasználó által megadott értéket a "Console.ReadLine()" metódus segítségével szövegként olvassuk be, majd az "Convert.ToInt32()" metódussal integerré alakítjuk. Az eredményt a "szam" változóban tároljuk.

A program ugyanazt az eljárást használja a második szám beolvasásához, amelyet a "szam2" változóban tárolunk.

Az első és a második szám szorzata a "szam" és a "szam2" változók szorzásával számolódik ki, az eredményt a "Console.WriteLine()" metódus segítségével kiírjuk a konzolra.

Végül a program várakozik, amíg a felhasználó bármilyen billentyűt meg nem nyom a "Console.ReadKey()" metódus segítségével.

Összességében ez a program egy egyszerű példa arra, hogy hogyan lehet alapvető aritmetikai műveleteket végezni C# nyelven, és hogyan lehet a felhasználóval a konzolon keresztül kommunikálni.*/

