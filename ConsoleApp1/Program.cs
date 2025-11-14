// See https://aka.ms/new-console-template for more information
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



