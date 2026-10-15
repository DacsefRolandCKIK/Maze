namespace szamlalas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1.
            int[] tomb = { 36, 48, 39, -1, 30, 43, -1, 76, 67, 82, 73, 75, 64, 73, 69, 63 };

            // 2. 
            int osszeg = 0;
            for (int i = 0; i < tomb.Length; i++)
            {
                if (tomb[i] != -1)
                {
                    osszeg += tomb[i];
                }
            }

            Console.WriteLine($"2. feladat\nÖsszesen {osszeg} kerékpárost számoltak.\n");

            // 3.
            Console.WriteLine("3.feladat\nÓránkénti mérések:");

            int osszegOra = 0;
            int Ora = 6;

            for (int j = 0; j < tomb.Length; j += 4)
            {
                osszegOra = 0;

                for (int k = 0; k < 4; k++)
                {
                    if (tomb[j + k] != -1)
                    {
                        osszegOra += tomb[j + k];
                    }
                }

                Console.WriteLine($"{Ora} órától {osszegOra} kerékpáros");

                Ora++;
            }

            // 4.

            Console.WriteLine("4. feladat");

            int Maxi = 0;
            int Maxe = 0;
            int Ora2 = 0;
            int Minu = 0;

            for (int l = 0; l < tomb.Length; l++)
            {
                if (tomb[l] > Maxe)
                {
                    Maxe = tomb[l];
                    Maxi = l;
                }
            }

        }
    }
}
