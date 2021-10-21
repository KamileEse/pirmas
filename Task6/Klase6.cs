using System;
using System.IO;

namespace Task6
{
    public class Klase6
    {
        public string path = @"/Users/kamileeselinaite/Desktop/C#/test6.txt";

        public static void PatikrintiArEgzistuoja()
        {

        }

        public static void PridetiIsrasa(string Path)
        {
            path = Path;
            using (StreamWriter sw = File.CreateText(Path))
            {
                sw.WriteLine("Hello");
                sw.WriteLine("And");
                sw.WriteLine("Welcome");
            }
        }
    }
}
