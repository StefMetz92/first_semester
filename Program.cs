/* Második beadandó feladat BevProg 2023
 * Dev by Mészáros István Attila D8OA4Y
 * Milton Friedman University */

using System.Threading.Channels;
using static System.Net.Mime.MediaTypeNames;


int szam=0, maximum=0, elem=0, minimum=256, menu=0, osszeg=0, csere=0;
bool kilepes = false;



Console.Write("Kérem adjon meg egy pozitív egész számot! ");
while (!int.TryParse(Console.ReadLine(), out szam) || szam < 0)
{
    Console.WriteLine("Hiba! Ez nem egy pozitív egész szám!");
    Console.Write("Kérem adjon meg egy pozitív egész számot! ");
}

Console.WriteLine("");
Console.WriteLine("");

int[] tomb = new int[szam];

Random random = new Random();

for (int i = 0; i < szam; i++)
{
    tomb[i] = random.Next(250);
    Console.Write(tomb[i] + " ");
   
}
do
{

    Console.WriteLine("");
    Console.WriteLine("");

    Console.WriteLine("1. Maximum keresés\r\n2. Minimum keresés\r\n3. Összegzés\r\n4. Rendezés\r\n5. A tömb elemeinek megfordítása\r\n6. A 42 és 137 közé eső számok kiválasztása\r\n7. Kilépés\r\n");
    Console.WriteLine("");


    Console.Write("Kérem adja meg az elvégezendő feladat számát (1-7): ");
    while (!int.TryParse(Console.ReadLine(), out menu) || menu < 1 || menu > 7)
    {
        Console.WriteLine("Hiba! Ez nem egy 1 és 7 közé eső szám!");
        Console.WriteLine("");
    }

    switch (menu)
    {
        case 1:

            for (int i = 0; i < szam; i++)
            {
                if (tomb[i] > maximum)
                {
                    maximum = tomb[i];
                    elem = i;
                }
            }
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("A maximális érték = " + maximum);
            Console.WriteLine("A maximális érték a tömb " + elem + ". eleme."); // A tömb a 0. elemmel kezdődik
            Console.WriteLine("");
            for (int i = 0; i < szam; i++)
            {
                if (tomb[i] == maximum && i != elem)
                {
                    Console.WriteLine("A maximum érték továbbá a tömb " + tomb[i] + ". eleme is!");
                }
            }

            break;

        case 2:

            for (int i = 0; i < szam; i++)
            {
                if (tomb[i] < minimum)
                {
                    minimum = tomb[i];
                    elem = i;
                }
            }
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("A minimum érték = " + minimum);
            Console.WriteLine("A minimum érték a tömb " + elem + ". eleme."); // A tömb a 0. elemmel kezdődik
            Console.WriteLine("");
            for (int i = 0; i < szam; i++)
            {
                if (tomb[i] == minimum && i != elem)
                {
                    Console.WriteLine("A minimum érték továbbá a tömb " + tomb[i] + ". eleme is!");
                }
            }

            break;

        case 3:

            for (int i = 0; i < szam; i++)
            {
                osszeg += tomb[i];
            }
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("A tömb elemeinek az összege: " + osszeg);

            break;

        case 4:

            for (int i = 0; i < szam; i++)
                for (int j = i + 1; j < szam; j++)
                {
                    if (tomb[i] > tomb[j])
                    {
                        csere = tomb[j];
                        tomb[j] = tomb[i];
                        tomb[i] = csere;
                    }
                }

            Console.WriteLine("");
            Console.WriteLine("");
            Console.Write("A tömb elemei rendezve: ");
            for (int i = 0; i < szam; i++)
            {
                Console.Write(tomb[i] + " ");
            }


            break;

        case 5:

            for (int i = 0; i < szam / 2; i++)

            {
                csere = tomb[i];
                tomb[i] = tomb[szam - 1 - i];
                tomb[szam - 1 - i] = csere;

            }

            Console.WriteLine("");
            Console.WriteLine("");
            Console.Write("A tömb elemei megfordítva: ");
            for (int i = 0; i < szam; i++)
            {
                Console.Write(tomb[i] + " ");
            }


            break;

        case 6:

            int[] kivalogatas = new int[szam];
            int k = 0;

            for (int i = 0; i < szam; i++)

            {
                if (tomb[i] > 42 && tomb[i] < 137)
                {
                    kivalogatas[k] = tomb[i];
                    k++;
                }

            }

            Console.WriteLine("");
            Console.WriteLine("");
            Console.Write("A kiválasztott elemek: ");
            for (int i = 0; i < k; i++)
            {
                Console.Write(kivalogatas[i] + " ");
            }


            break;

        case 7:

            Environment.Exit(0);


            break;



        default:

            {
                Console.WriteLine("");
                break;
            }
    }

} while (kilepes = true);

Console.WriteLine("");
Console.WriteLine("");
Console.WriteLine("Kérem nyomjon meg egy gombot a kilépéshez!");
Console.ReadKey();
