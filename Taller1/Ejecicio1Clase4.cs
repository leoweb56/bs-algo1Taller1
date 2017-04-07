using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            int suma, cont, num;
            double prom;

            suma = 0;
            cont = 0;
            Console.WriteLine("Ing un numero");
            num = int.Parse(Console.ReadLine());

            while (num < 30)
            {
                suma += num;
                cont += 1;

                Console.WriteLine("Ing un numero");
                num = int.Parse(Console.ReadLine());
            }
            prom = Convert.ToDouble(suma) / cont;
            Console.WriteLine("La suma es " + suma);
            Console.WriteLine("La cantidad de numeros es " + cont);
            Console.WriteLine("El promedio es " + prom);

            Console.ReadKey();
        }
    }
}
