using System;

namespace Ej1Cl7
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			string estado;
			int edad, cod, cAprob, cNoAprob, totA;
			double sal;

			cAprob = 0;
			cNoAprob = 0;

			Console.WriteLine("Ingrese el codigo del cliente");
			cod = int.Parse(Console.ReadLine());

			while (cod != 0)
			{
				Console.WriteLine("Ingrese salario, edad y estado civil (S) soltero (C) casado.");
				sal = double.Parse(Console.ReadLine());
				edad = int.Parse(Console.ReadLine());
				estado = Console.ReadLine();

				if (sal > 20000 && edad >= 18 && estado == "C")
				{
					cAprob++;
					Console.WriteLine("Aprobado");
				}
				else
				{
					cNoAprob++;
					Console.WriteLine("No Aprobado");
				}

				Console.WriteLine("Ingrese el codigo del cliente");
				cod = int.Parse(Console.ReadLine());
			}

			totA = cAprob + cNoAprob;

			Console.WriteLine("Aprobados " + cAprob);
			Console.WriteLine("No Aprobados " + cNoAprob);
			Console.WriteLine("Atendidos " + totA);

			Console.ReadKey();
		}
	}
}
