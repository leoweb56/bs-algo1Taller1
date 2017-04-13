using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication11
{
    class Program
    {
        static void Main(string[] args)
        {
            string ape;
            int c1, c2, c3, cTot, grado;
            double promA, porcA1, porcA2, porcA3, totC1, totC2, totC3;

            c1 = 0;
            c2 = 0;
            c3 = 0;

            Console.WriteLine("Ing apellido y grado del alumno");
            ape = Console.ReadLine();
            grado = int.Parse(Console.ReadLine());

            while (ape != "zzz")
            {
                if (grado == 1)
                {
                    c1++; //1)
                }else if (grado == 2)
                {
                    c2++; //1)
                }else if (grado == 3)
                {
                    c3++; //1)
                }

                Console.WriteLine("Ing apellido y grado del alumno");
                ape = Console.ReadLine();
                grado = int.Parse(Console.ReadLine());
            }

            cTot = c1 + c2 + c3;

            //2)
            promA = Convert.ToDouble(cTot) / 3;

            //4)
            porcA1 = (Convert.ToDouble(c1) / cTot)*100;
            porcA2 = (Convert.ToDouble(c2) / cTot)*100;
            porcA3 = (Convert.ToDouble(c3) / cTot)*100;

            //3)
            totC1 = 150 * c1;
            totC2 = 200 * c2;
            totC3 = 250 * c3;

            //informe
            Console.WriteLine("Cant de alumnos grado A= {0}, B = {1}, C = {2}", c1, c2, c3);
            Console.WriteLine("Promedio de alumnos {0}", promA);
            Console.WriteLine("Total de cuotas grado A= {0}, B = {1}, C = {2}", totC1, totC2, totC3);
            Console.WriteLine("Porcentaje de alumnos grado A= {0}%, B = {1}%, C = {2}%", porcA1, porcA2, porcA3);

            Console.ReadKey();
        }
    }
}
