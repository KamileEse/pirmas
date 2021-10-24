using System;
using System.Collections.Generic;

namespace Task7
{
    class MainClass
    {
        //1. Programa turi pasiūlyti prisijungti arba registruotis
        //2. Jeigu varotojas bando prisijungti reikia patikrinti ar Name ir Password yra teisingi
        //3. Jeigu registruojamas naujas, patikrinti ar Name neegzistuoja ir slaptažodis ilgesnis nei šeši simboliai
        //4. Vartotojai išsaugomi į failą
        //5. Programa turi keletą iš anksto išsaugotų vartotojų

        public static void Main(string[] args)
        {
            
            

        }

        public void UzpildytiVartotojuSarasa(List<Vartotojas> vartotojai)
        {
            for (int i = 0; i < 10; i++)
            {
                var vart = new Vartotojas($"Jonas{i}", $"slaptazodis{i}");

                vartotojai.Add(vart);
            }

            foreach (var i in vartotojai)
            {
                Console.WriteLine(i);
            }
        }
    }
}
