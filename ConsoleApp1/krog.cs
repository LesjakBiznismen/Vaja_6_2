using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class krog
    {
        private double r;
        public krog()
        {
            r = 1;
        }
        public krog(double r)
        {
            this.r = r;
        }

        public void NastaviR()
        {
            Console.WriteLine("Vnesi velikost R:");
            r = Convert.ToDouble(Console.ReadLine());
        }

    }
}

        


