using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tavolugras
{
    class Program
    {
        static string[] UgrokNeve = new string[9];
        static int[] UgrottTav = new int[9];
        static void Main(string[] args)
        {
            Feladat1Feltoltes(); Console.WriteLine("\n----------------------------\n");
            Feladat2(); Console.WriteLine("\n----------------------------\n");
            Feladat3(); Console.WriteLine("\n----------------------------\n");
            Feladat4(); Console.WriteLine("\n----------------------------\n");
            Feladat5(); Console.WriteLine("\n----------------------------\n");
            Feladat6();
            Console.ReadKey();
        }

        private static void Feladat6()
        {
            Console.WriteLine("6.Feladat: Határozza meg hányan ugrottak kisebb távolságot mint 600 cm");
            int db = 0;
            for (int i = 0; i < UgrottTav.Length; i++)
            {
                if(UgrottTav[i]<600)
                {
                    db++;
                }
            }
            Console.WriteLine("Ennyi alkalommal ugrottak kisebb távot mint 600 cm: {0}", db);
        }

        private static void Feladat5()
        {
            Console.WriteLine("5.Feladat: Írjon keresőporgramot mely bármely személyt tud azonosítani a tömbünkben és kiirja az általa ugrott távot");
            int Szamlalo = 0;
            Console.Write("Kérem adja meg a nevet amit szeretne keresni: ");
            string KeresettNev = Console.ReadLine().ToLower().Replace(" ", "");
            while(Szamlalo<UgrokNeve.Length && KeresettNev!=UgrokNeve[Szamlalo].ToLower().Replace(" ", ""))
            {
                Szamlalo++;
            }
            if(Szamlalo==UgrokNeve.Length)
            {
                Console.WriteLine("Sajnos nincs ilyen nevű ugró a tömbben");
            }
            else
            {
                Console.WriteLine("A keresett név: {0}\nTávolság amit ugrott: {1}", UgrokNeve[Szamlalo], UgrottTav[Szamlalo]);
            }
        }

        private static void Feladat4()
        {
            Console.WriteLine("4.Feladat: Keresse meg, hogy Pác János mekkora távolgot ugrott és mekkora az általa ugrott táv és a legkisebb távolság különbsége");
            int MinTav = int.MaxValue;
            int KeresettTav = 0;
            for (int i = 0; i < UgrottTav.Length; i++)
            {
                if(MinTav>UgrottTav[i])
                {
                    MinTav = UgrottTav[i];
                }
            }
            Console.WriteLine("A legkisebb távolság amit ugrottak: {0}", MinTav);
            int Szamlalo = 0;
            string Kulcs = "Pác János";
            while(Szamlalo<UgrokNeve.Length && Kulcs!=UgrokNeve[Szamlalo])
            {
                Szamlalo++;
            }
            if(Szamlalo==UgrokNeve.Length)
            {
                Console.WriteLine("Nincs Pác János nevű ugró");
            }
            else
            {
                KeresettTav = UgrottTav[Szamlalo];
                Console.WriteLine("Pác János ugrott távja: {0}", UgrottTav[Szamlalo]);
            }
            int TavKulonbseg = KeresettTav - MinTav;
            Console.WriteLine("Pác János távolsága és a minimum távolság különbsége: {0}", TavKulonbseg);
        }

        private static void Feladat3()
        {
            Console.WriteLine("3.Feladat: Mekkora az ugrók átlagosan megtett távolsága");
            double Atlag = 0;
            double Osszeg = 0;
            for (int i = 0; i < UgrottTav.Length; i++)
            {
                Osszeg += (double)UgrottTav[i];
            }
            Atlag = Osszeg / UgrottTav.Length;
            Console.WriteLine("Az ugrott távok átlaga: {0:0.00}",Atlag);
        }

        private static void Feladat2()
        {
            Console.WriteLine("2.Felada: Határozza meg ki ugrotta a legnagyobb távolságot és mekkora volt ez a táv ");
            int MaxTav = int.MinValue;
            string MaxNev = "";
            for (int i = 0; i < UgrottTav.Length; i++)
            {
                if (UgrottTav[i] > MaxTav)
                {
                    MaxTav = UgrottTav[i];
                    MaxNev = UgrokNeve[i];
                }
            }            
            Console.WriteLine("A legnagyobb távolság: {0} cm\nA táv ugrója: {1}", MaxTav, MaxNev);
        }

        private static void Feladat1Feltoltes()
        {
            Console.WriteLine("1.Feladat: Adatok feltöltése");
            UgrokNeve = new string[9] { "Ug Imre", "Tóbiás Félix", "Kozma Alfonz", "Csabai Kázmér", "Pác János", "Csonka Elemér", "Örvös Eduárd", "Csősz Béla", "Haragos Csaba" };
            UgrottTav = new int[9] {640, 656,556,659,591,642,575,620,619};
        }
    }
}
