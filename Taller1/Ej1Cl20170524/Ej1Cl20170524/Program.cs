using System;

namespace Ej1Cl20170524
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			int nHC, op, cNP1, cNP2, cNP3, cNP4, cNoP1, cNoP2, cNoP3, cNoP4, cant, pTot;
			string sexo, sMax;
			double pMax, peso, pNo, pNa;

			cNP1 = 0;
			cNP2 = 0;
			cNP3 = 0;
			cNP4 = 0;
			cNoP1 = 0;
			cNoP2 = 0;
			cNoP3 = 0;
			cNoP4 = 0;
			pMax = -99;

			do
			{
				Console.WriteLine("Ingresar el numero de historia clinica, sexo y peso.");
				nHC = int.Parse(Console.ReadLine());
				sexo = Console.ReadLine();
				peso = double.Parse(Console.ReadLine());

				if (nHC != 0)
				{
					if (peso <= 10)
					{
						op = 1;
					}else if (peso <= 20)
					{
						op = 2;
					}else if (peso <= 30)
					{
						op = 3;
					}else
					{
						op = 4;
					}

					switch (op)
					{
						case 1:
							if (sexo=="F")
							{
								cNP1++;
							}else
							{
								cNoP1++;
							}
							break;
						case 2:
							if (sexo == "F")
							{
								cNP2++;
							}
							else
							{
								cNoP2++;
							}
							break;
						case 3:
							if (sexo == "F")
							{
								cNP3++;
							}
							else
							{
								cNoP3++;
							}
							break;
						default:
							if (sexo == "F")
							{
								cNP4++;
							}
							else
							{
								cNoP4++;
							}
							break;
					}

					if (peso > pMax)
					{
						//7
						pMax = peso;
						sMax = sexo;
					}

				}

			} while (nHC != 0);

			cant = cNP1 + cNP2 + cNP3 + cNP4 + cNoP1 + cNoP2 + cNoP3 + cNoP4; //5

			pNo = (Convert.ToDouble(cNoP1 + cNoP2 + cNoP3 + cNoP4) / cant) * 100; //6
			pNa = (Convert.ToDouble(cNP1 + cNP2 + cNP3 + cNP4) / cant) * 100; //6

			Console.WriteLine("Cantidad de niñas con peso menor a 10: " + cNP1);
			Console.WriteLine("Cantidad de niñas con peso entre 11 a 20: " + cNP2);
			Console.WriteLine("Cantidad de niñas con peso entre 21 a 30: " + cNP3);
			Console.WriteLine("Cantidad de niñas con peso mayor a 30: " + cNP4);

			Console.WriteLine("Cantidad de niños con peso menor a 10: " + cNoP1);
			Console.WriteLine("Cantidad de niños con peso entre 11 a 20: " + cNoP2);
			Console.WriteLine("Cantidad de niños con peso entre 21 a 30: " + cNoP3);
			Console.WriteLine("Cantidad de niños con peso mayor a 30: " + cNoP4);

			Console.WriteLine("Cantidad de niñas y niños: " + cant);

			Console.WriteLine("Porcentaje de niños: " + pNo);
			Console.WriteLine("Porcentaje de niñas: " + pNa);

			Console.WriteLine((sexo == "F" ? "La niña " : "El niño ") + "con mas peso tiene: " + pMax + "kg.");
			Console.ReadKey();

		}
	}
}
