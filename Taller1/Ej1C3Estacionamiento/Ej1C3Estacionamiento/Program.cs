using System;

namespace Ej1C3Estacionamiento
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			string mAuto, pat, mPago, mRev;
			int dias;
			double importe, desc, pFinal, km;

			Console.WriteLine("Ing marca del auto, patente, cantidad de dias estacionado y km del auto");

			mAuto = Console.ReadLine();
			pat = Console.ReadLine();
			dias = int.Parse(Console.ReadLine());
			km = double.Parse(Console.ReadLine());

			if (mAuto == "ford")
			{
				importe = 150 * dias;
			}
			else
			{
				importe = 200 * dias;
			}

			if (dias >= 5)
			{
				mPago = "Pago por adelantado";
			}
			else
			{
				mPago = "";
			}

			if (dias >= 15)
			{
				desc = importe * 0.05;
			}
			else
			{
				desc = 0;
			}

			if (km >= 500)
			{
				mRev = "Revision completa";
			}
			else
			{
				mRev = "Revision basica";
			}

			pFinal = importe - desc;

			Console.WriteLine(mPago);
			Console.WriteLine(mRev);
			Console.WriteLine("El precio final es $" + pFinal);

			Console.ReadKey();
		}
	}
}
