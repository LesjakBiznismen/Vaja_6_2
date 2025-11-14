using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class pravokotnik
    {
        private double a;
        private double b;
        public pravokotnik()
        {
            a = 1;
            
            b = 1;
        }

        public pravokotnik(double a, double b)
        {
            Console.WriteLine("Vpiši št. a: ");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Vpiši št. b: ");
            b = double.Parse(Console.ReadLine());
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
