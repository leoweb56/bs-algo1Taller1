using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication16
{
    class Program
    {
        static void Main(string[] args)
        {
            string prod, vend;
            int cu, cOpA, cOpG, cOpR, cUnG, cUnH, cUnA, cUnL, totUn, totOp;
            double precio, facG, facH, facA, facL;

            cOpA = 0;
            cOpG = 0;
            cOpR = 0;
            cUnA = 0;
            cUnG = 0;
            cUnH = 0;
            cUnL = 0;

            Console.Write("Ingresar el producto (A) arroz, (H) harina, (G) gaseosa, (L) lavandina. Ingresas (zzz) para terminar la carga: ");
            prod = Console.ReadLine();

            while (prod != "zzz")
            {
                Console.WriteLine("Ingresar la cantidad vendidad y su vendedor (A) Aparicio, (G) Guerrero, (R) Ramos: ");
                cu = int.Parse(Console.ReadLine());
                vend = Console.ReadLine();

                if (prod == "G")
                {
                    cUnG+=cu;
                    precio = cu*10;
                }
                else if (prod == "H")
                {
                    cUnH+=cu;
                    precio = cu*9;
                }
                else if (prod == "A")
                {
                    cUnA+=cu;
                    precio = cu*8;
                }
                else if (prod == "L")
                {
                    cUnL+=cu;
                    precio = cu*7;
                }
                else
                {
                    precio = 0;
                }

                Console.WriteLine("El precio es $" + precio);

                if (vend == "A")
                {
                    cOpA++;
                }
                else if (vend == "G")
                {
                    cOpG++;
                }
                else if (vend == "R")
                {
                    cOpR++;
                }

                Console.Write("Ingresar el producto (A) arroz, (H) harina, (G) gaseosa, (L) lavandina. Ingresas (zzz) para terminar la carga: ");
                prod = Console.ReadLine();
            }

            facG = cUnG * 10;
            facH = cUnH * 9;
            facA = cUnA * 8;
            facL = cUnL * 7;

            totOp = cOpA + cOpG + cOpR;

            totUn = cUnA + cUnG + cUnH + cUnL;

            Console.WriteLine("Cantidad de operaciones por vendedor: {0}(A), {1}(G), {2}(R)", cOpA, cOpG, cOpR);
            Console.WriteLine("Cantidad de unidades comprados por cada producto: {0}(A), {1}(H), {2}(G), {3}(L)", cUnA, cUnH, cUnG, cUnL);
            Console.WriteLine("Total de unidades compradas" + totUn);
            Console.WriteLine("Facturacion por producto: ${0}(A), ${1}(H), ${2}(G), ${3}(L)", facA, facH, facG, facL);
            Console.WriteLine("Total de operaciones " + totOp);

            Console.ReadKey();
        }
    }
}
