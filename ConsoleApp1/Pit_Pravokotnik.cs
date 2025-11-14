using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Pit_Pravokotnik
    {
        private double a;
        private double b;
        private double c;

        public Pit_Pravokotnik(double a, double b, double c)
        {
            this.a = 3; 
            this.b = 4;
            this.c = 5;
        }

        public Pit_Pravokotnik(double a, double b)
        {
            this.a = a;
            this.b = b;
            c = Math.Sqrt(a * a + b * b);
        }

        public double VrniPloscino()
        {
            return a * b / 2;
        }

        public double VrniObseg()
        {
            return a + b + c;
        }
    }
}
