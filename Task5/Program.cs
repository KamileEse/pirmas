using System;
using System.IO;

namespace Task5
{
    class MainClass
    {
        //1. Irašyti į failą iš vartotojo paimtus duomenis (jeigu nutiktų klaida,  parodyti žinutę vartotojui)
        //2. Nuskaityti iš failo jeigu nutiktų klaida, parodyti žinutę vartotojui)

        public static void Main(string[] args)
        {
            string ivestiDuomenys = IvestiDuomenis();
            IrasytiDuomenis(ivestiDuomenys);
        }  

        public static string IvestiDuomenis()
        {
            Console.WriteLine("Iveskite teksta:");
            string duomenys = Console.ReadLine();
            return duomenys;
        }

        public static void IrasytiDuomenis(string duomenys)
        {
            string vieta = "/Users/kamileeselinaite/Desktop/C#/test2.txt";
            DirectoryInfo direktorija = Directory.GetParent(vieta);
            if (direktorija.Exists == true)
            {
                File.WriteAllText(vieta, duomenys);
            }
            else
            {
                Console.WriteLine("Ivyko klaida, vieta neegzistuoja");
            }

        }
    }
}
