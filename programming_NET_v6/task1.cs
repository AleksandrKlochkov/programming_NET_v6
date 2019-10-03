using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programming_NET_v6
{
    class Task1
    {

        public int a;
        public int b;
        public double c;
        public Task1(int numA , int numB) {
            a = numA;
            b = numB;
        }

        public void Exponentiation() {
            //Возведение разности в 3 степень
            this.c = Math.Pow(this.a - this.b, 3);
            Console.WriteLine("Результат: "+ c);
                
        }
    }
}
