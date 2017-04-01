using System;

namespace EjercicioPrecioViaje
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			int nroCliente, kmRecorridos;
			double precioViaje;

			Console.WriteLine("Ingrese el nro de cliente y los km recorridos");
			nroCliente = int.Parse(Console.ReadLine());
			kmRecorridos = int.Parse(Console.ReadLine());

			if (kmRecorridos<5)
			{
				precioViaje = 30;
			}else
			{
				precioViaje = kmRecorridos * 10;
			}

			if (kmRecorridos>50)
			{
				precioViaje = precioViaje * 0.9;
			}

			Console.WriteLine("El precio del viaje es $" + precioViaje);
			Console.ReadKey();
		}
	}
}
