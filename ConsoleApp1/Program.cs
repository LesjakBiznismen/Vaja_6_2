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



