using System;

namespace Ej1Cl8
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			int nMes, trim1, trim2, trim3, trim4, totTrim;

			trim1 = 0;
			trim2 = 0;
			trim3 = 0;
			trim4 = 0;

			Console.WriteLine("Ingresar nro mes");
			nMes = int.Parse(Console.ReadLine());

			while (nMes != 0)
			{
				if (nMes == 1 || nMes == 2 || nMes == 3)
				{
					trim1++;
					Console.WriteLine("Trimestre uno");
				}
				else if (nMes == 4 || nMes == 5 || nMes == 6)
				{
					trim2++;
					Console.WriteLine("Trimestre dos");
				}
				else if (nMes == 7 || nMes == 8 || nMes == 9)
				{
					trim3++;
					Console.WriteLine("Trimestre tres");
				}else
				{
					trim4++;
					Console.WriteLine("Trimestre cuatro");
				}

				Console.WriteLine("Ingresar nro mes");
				nMes = int.Parse(Console.ReadLine());
			}

			totTrim = trim1 + trim2 + trim3 + trim4;

			Console.WriteLine("Cantidad de registros ingresados " + totTrim);
			Console.WriteLine("Cantidad de registros del primer trimestre " + trim1);
			Console.WriteLine("Cantidad de registros del segundo trimestre " + trim2);
			Console.WriteLine("Cantidad de registros del tercer trimestre " + trim3);
			Console.WriteLine("Cantidad de registros del cuarto trimestre " + trim4);

			Console.ReadKey();
		}
	}
}
