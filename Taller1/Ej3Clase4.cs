using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            string apellido, sector;
            int codigo, cantEmpA, cantEmpB, cantEmpTot;
            double sueldo, sueldoTotA, sueldoTotB, promSueldos;

            sueldo = 0;
            sueldoTotA = 0;
            sueldoTotB = 0;
            cantEmpA = 0;
            cantEmpB = 0;

            Console.WriteLine("Ing codigo, apellido, sector y sueldo del empleado:");
            codigo = int.Parse(Console.ReadLine());
            apellido = Console.ReadLine();
            sector = Console.ReadLine();
            sueldo = double.Parse(Console.ReadLine());

            while (codigo != 0)
            {
                if (sector == "A")
                {
                    sueldoTotA += sueldo;
                    cantEmpA += 1;
                }
                else
                {
                    sueldoTotB += sueldo;
                    cantEmpB += 1;
                }

                Console.WriteLine("Ing codigo, apellido, sector y sueldo del empleado:");
                codigo = int.Parse(Console.ReadLine());
                apellido = Console.ReadLine();
                sector = Console.ReadLine();
                sueldo = double.Parse(Console.ReadLine());
            }
            cantEmpTot = cantEmpA + cantEmpB;
            promSueldos = (sueldoTotA + sueldoTotB) / cantEmpTot;

            Console.WriteLine("Cantidad de empleados del sector A: " + cantEmpA);

            Console.WriteLine("Cantidad de empleados del sector B: " + cantEmpB);
            Console.WriteLine("Cantidad de empleados: " + cantEmpTot);
            Console.WriteLine("Sueldos del sector A: " + sueldoTotA);
            Console.WriteLine("Sueldos del sector B: " + sueldoTotB);
            Console.WriteLine("Promedio de sueldos: " + promSueldos);

            Console.ReadKey();
        }
    }
}
