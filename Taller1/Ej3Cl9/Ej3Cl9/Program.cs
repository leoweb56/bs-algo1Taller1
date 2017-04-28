using System;

namespace Ej3Cl9
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			int gusto, vMujer, vHombre, cOp1, cOp2, cOp3, cOp4, cOp5, cOp6, cOpTot, cOp15, cMOp263;
			string sexo;
			double prom, porc1;

			cOp1 = 0;
			cOp2 = 0;
			cOp3 = 0;
			cOp4 = 0;
			cOp5 = 0;
			cOp6 = 0;
			cMOp263 = 0;
			cOp15 = 0;
			vMujer = 0;
			vHombre = 0;

			Console.WriteLine("Ingrese su gusto"); 
			Console.WriteLine("1 -> Mirar futbol");
			Console.WriteLine("2 -> Ir al cine");
			Console.WriteLine("3 -> Ir al teatro");
			Console.WriteLine("4 -> Escuchar musica");
			Console.WriteLine("5 -> Hacer turismo");
			Console.WriteLine("6 -> Ir al shopping");

			gusto = int.Parse(Console.ReadLine());

			while (gusto != 0)
			{
				Console.WriteLine("Ingrese el sexo (M) mujer, (H) Hombre");
				sexo = Console.ReadLine();

				switch (gusto)
				{
					case 1:
						cOp1++;
						cOp15++;
						break;
					case 2:
						cOp2++;
						break;
					case 3:
						cOp3++;
						break;
					case 4:
						cOp4++;
						break;
					case 5:
						cOp5++;
						cOp15++;
						break;
					case 6:
						cOp6++;
						break;
					default:
						break;
				}

				if (sexo == "M" && (gusto==2 || gusto == 6 || gusto==3))
				{
					cMOp263++;
				}

				if (sexo == "M")
				{
					vMujer++;
				}
				else
				{
					vHombre++;
				}
				Console.Clear();
				Console.WriteLine("Ingrese su gusto");
				Console.WriteLine("1 -> Mirar futbol");
				Console.WriteLine("2 -> Ir al cine");
				Console.WriteLine("3 -> Ir al teatro");
				Console.WriteLine("4 -> Escuchar musica");
				Console.WriteLine("5 -> Hacer turismo");
				Console.WriteLine("6 -> Ir al shopping");

				gusto = int.Parse(Console.ReadLine());
			}
			Console.Clear();

			cOpTot = cOp1 + cOp2 + cOp3 + cOp4 + cOp5 + cOp6;

			prom = Convert.ToDouble(cOpTot) / 6;

			porc1 = (Convert.ToDouble(cOp1) / cOpTot) * 100;

			Console.WriteLine("Votos opcion 1: " + cOp1);
			Console.WriteLine("Votos opcion 2: " + cOp2);
			Console.WriteLine("Votos opcion 3: " + cOp3);
			Console.WriteLine("Votos opcion 4: " + cOp4);
			Console.WriteLine("Votos opcion 5: " + cOp5);
			Console.WriteLine("Votos opcion 6: " + cOp6);
			Console.WriteLine("Total de votos: " + cOpTot);
			Console.WriteLine("Promedio de votos: " + prom);
			Console.WriteLine("Votos de mujeres: " + vMujer);
			Console.WriteLine("Votos de hombres: " + vHombre);
			Console.WriteLine("Votos opcion 1 o 5: " + cOp15);
			Console.WriteLine("Votos de mujeres, opcion 2 o 3 o 6: " + cMOp263);
			Console.WriteLine("Porcentaje de votos opcion 1: " + porc1);

			Console.ReadKey();

		}
	}
}
