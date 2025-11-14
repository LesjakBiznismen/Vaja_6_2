// See https://aka.ms/new-console-template for more information
using ConsoleApp1;

Console.WriteLine("Hello, World!");
Pit_Pravokotnik pravokotnik = new Pit_Pravokotnik(6, 8);
Console.WriteLine(pravokotnik.VrniPloscino());
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Krog krog1 = new Krog(5);
            Console.WriteLine(krog1.Ploscina());

            Krog krog2 = new Krog(6);
            Console.WriteLine(krog2.Ploscina());
        }
    }
}



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


