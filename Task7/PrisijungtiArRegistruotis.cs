using System;
namespace Task7
{
    public class PrisijungtiArRegistruotis
    {
        public PrisijungtiArRegistruotis()
        {
            Console.WriteLine("Jei norite prisijungti - iveskite 1, " +
                "jei norite registruotis - iveskite 2");

            int pasirinkimas = Convert.ToInt32(Console.ReadLine());

            if (pasirinkimas == 1)
            {
                Console.WriteLine("Iveskite vartotojo varda:");
                string vardas = Console.ReadLine();

                Console.WriteLine("Iveskite slaptazodi:");
                string slaptazodis = Console.ReadLine();
            }
            else if (pasirinkimas == 2)
            {
                Console.WriteLine("Iveskite naujo vartotojo varda:");
                string vardasReg = Console.ReadLine();

                Console.WriteLine("Iveskite naujo vartotojo slaptazodi:");
                string slaptazodisReg = Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Klaida!");
            }
        }


    }
}
