using System;

namespace MojaVaja
{
    class Program
    {
        static void Main(string[] args)
        {
            Pravokotnik p1 = new Pravokotnik();
            p1.NastaviVrednosti(3, 3);

            Pravokotnik p2 = new Pravokotnik();
            p2.NastaviVrednosti(6, 4);

            Console.WriteLine("Ploščina prvega: " + p1.Ploscina());
            Console.WriteLine("Ploščina drugega: " + p2.Ploscina());

            Console.ReadLine();
        }
    }

    class Pravokotnik
    {
        public double a;
        public double b;

        public void NastaviVrednosti(double novoA, double novoB)
        {
            a = novoA;
            b = novoB;
        }

        public double Obseg()
        {
            return 2 * (a + b);
        }

        public double Ploscina()
        {
            return a * b;
        }
    }
}


