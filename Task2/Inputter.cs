using System;
using System.Collections.Generic;

namespace Task2
{
    public class Inputter
    {
        public static void Nuskaitymas()
        {
            List<int> manoSarasas = new List<int>();
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine($"Iveskite skaiciu {i + 1}");
                string ivestis = Console.ReadLine();
                int skaicius = Convert.ToInt32(ivestis);
                manoSarasas.Add(skaicius); // --Add yra metodas
            }
        }

        public static bool SarasasTeigiamas(List<int> saraselis)
        {
            bool rezultatas = true;   // rezultatas bus true, kol nesutiksiu neigiamo. kai
            //sutiksiu, pakeis i false -->

            if (saraselis == null || saraselis.Count == 0) // -- kai ne metodas, tai be skliaustu
            {
                rezultatas = false;
            }

            foreach(var skaicius in saraselis)
            {
                // jei 1 - nieko nedaro
                // jei -2 - rezultatui priskirs false reiksme

                if (skaicius <= 0)
                {
                    rezultatas = false;
                }
            }
            // rezultatas - false

            return rezultatas; // grazina false
        }
    }
}
