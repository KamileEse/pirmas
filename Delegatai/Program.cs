using System;

namespace Delegatai
{
    public delegate void ManoDelegatas(string manoTekstoEilute);

    class MainClass
    {
        private static ManoDelegatas manoPrivatusDelegatas;

        public static void Main(string[] args)
        {
            manoPrivatusDelegatas += Console.WriteLine;
            manoPrivatusDelegatas += betKoksMetodas;

            SavotiskaiPasisveikinti("lab dien");
            Console.ReadLine();
        }

        public static void SavotiskaiPasisveikinti(string fraze)
        {
            manoPrivatusDelegatas(fraze);
        }

        public static void betKoksMetodas(string parama)
        {
            Console.WriteLine("mano metodas");
        }
    }
}
