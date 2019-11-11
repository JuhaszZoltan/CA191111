using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA191111
{
    class Program
    {
        static Random rnd = new Random();
        static int[] t = new int[20];
        static void Main(string[] args)
        {
            //feltoltes
            for (int i = 0; i < t.Length; i++)
            {
                t[i] = rnd.Next(1, 101);
            }

            //kiir (5 elemenként sortores)
            for (int i = 0; i < t.Length; i++)
            {
                Console.Write("{0, 3} ", t[i]);
                if ((i + 1) % 5 == 0) Console.Write("\n");
            }
            Console.WriteLine("-------------");

            //osszegzes
            int osszeg = 0;
            for (int i = 0; i < t.Length; i++)
            {
                osszeg += t[i];
            }
            Console.WriteLine($"elemek osszege: {osszeg}");
            Console.WriteLine("-------------");
            Console.WriteLine("Átlag: {0:0.00}", osszeg / (float)t.Length);
            Console.WriteLine("-------------");
            int mini = 0;
            for (int i = 1; i < t.Length; i++)
            {
                if (t[i] < t[mini]) mini = i;
            }
            Console.WriteLine($"min érték: {t[mini]}");
            Console.WriteLine($"min index: {mini}");
            Console.WriteLine($"min hely: {mini + 1}");
            Console.WriteLine("-------------");
            int maxi = 0;
            for (int i = 1; i < t.Length; i++)
            {
                if (t[i] > t[maxi]) maxi = i;
            }
            Console.WriteLine($"max érték: {t[maxi]}");
            Console.WriteLine($"max index: {maxi}");
            Console.WriteLine($"max hely: {maxi + 1}");
            Console.WriteLine("-------------");
            int parosDb = 0;
            for (int i = 0; i < t.Length; i++)
            {
                if (t[i] % 2 == 0) parosDb++;
            }
            Console.WriteLine($"páros elemek száma: {parosDb}");
            Console.WriteLine("-------------");
            //eldöntés
            int j = 0;
            while (j < t.Length && t[j] % 7 != 0)
            {
                j++;
            }
            if (j < t.Length) Console.WriteLine("VAN 7el osztható elem");
            else Console.WriteLine("NINCS 7-el osztható elem");
            Console.WriteLine("-------------");
            //lin.keresés
            int k = 0;
            while (k < t.Length && t[k] != 33)
            {
                k++;
            }
            if (k < t.Length) Console.WriteLine($"A 33 a {k + 1}. elem a tömbben");
            else Console.WriteLine("NINCS 33 a tömbben");
            Console.WriteLine("-------------");
            //kiválasztás
            t[rnd.Next(t.Length)] = 300;
            int v = 0;
            while (t[v] != 300)
            {
                v++;
            }
            Console.WriteLine($"A 300 a tömb {v + 1}. eleme");
            Console.WriteLine("-------------");
            //kiválogatás
            int[] g = new int[t.Length];
            int gi = 0;

            for (int i = 0; i < t.Length; i++)
            {
                if(t[i] % 3 == 0)
                {
                    g[gi] = t[i];
                    gi++;
                }
            }

            Console.Write("3al osztható elemek: ");
            for (int i = 0; i < gi; i++)
            {
                Console.Write($"{g[i]} ");
            }
            Console.WriteLine("\n-------------");

            //szétválogatás:
            int[] k50 = new int[t.Length];
            int[] n50 = new int[t.Length];
            int k50i = 0;
            int n50i = 0;

            for (int i = 0; i < t.Length; i++)
            {
                if(t[i] < 50)
                {
                    k50[k50i] = t[i];
                    k50i++;
                }
                else
                {
                    n50[n50i] = t[i];
                    n50i++;
                }
            }
            Console.Write("50nél nem kissebb: ");
            for (int i = 0; i < n50i; i++)
            {
                Console.Write($"{n50[i]} ");
            }
            Console.Write("\n50nél kissebb elemek: ");
            for (int i = 0; i < k50i; i++)
            {
                Console.Write($"{k50[i]} ");
            }
            Console.WriteLine("\n-------------");

            //pl. minde 4essel kezdődő szám legyen piros:

            for (int i = 0; i < t.Length; i++)
            {
                if(t[i] / 10 == 4)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                else Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write("{0, 3} ", t[i]);
                if ((i + 1) % 5 == 0) Console.Write("\n");
            }

            Console.ReadKey();
        }
    }
}
