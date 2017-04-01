Algoritmo EjercicioPrecioViaje
	Definir nroCleinte, kmRecorridos como entero
	Definir precioViaje como real
	
	Escribir "Inggresar nro clente y km recorridos"
	Leer nroCleinte, kmRecorridos
	
	Si (kmRecorridos < 5) Entonces
		precioViaje <- 30
	Sino
		precioViaje <- (kmRecorridos*10)
	Fin Si
	
	Si (kmRecorridos > 50) Entonces
		precioViaje <- (precioViaje*0.9)
	Fin Si
	
	Escribir "El precio del viaje es ", precioViaje
FinAlgoritmo
