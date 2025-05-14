internal class Program
{

	private static void Main(string[] args)
	{
		bool salir = false;

		while (!salir)
		{
			MostrarMenu();
			string opcion = Console.ReadLine();

			switch (opcion)
			{
				case "1":
					RealizarSuma();
					break;
				case "2":
					RealizarResta();
					break;
				case "3":
					RealizarMultiplicacion();
					break;
				case "4":
					RealizarDivision();
					break;
				case "5":
					RealizarPotencia();
					break;
				case "6":
					salir = true;
					Console.WriteLine("Saliendo de la calculadora...");
					break;
				default:
					Console.WriteLine("Opción no válida. Intente nuevamente.");
					break;
			}

			if (!salir)
			{
				Console.WriteLine("\nPresione cualquier tecla para continuar...");
				Console.ReadKey();
				Console.Clear();
			}
		}
	}

	static void MostrarMenu()
	{
		Console.WriteLine("Calculadora");
		Console.WriteLine();
		Console.WriteLine("1-    Suma");
		Console.WriteLine("2-    Resta");
		Console.WriteLine("3-    Multiplicación");
		Console.WriteLine("4-    División");
		Console.WriteLine("5-    Elevar un número a la potencia");
		Console.WriteLine("6-    Salir");
		Console.WriteLine();
		Console.Write("Seleccione una opción: ");
	}

	static void RealizarSuma()
	{
		Console.Clear();
		Console.WriteLine("-- SUMA --");
		Console.Write("Ingrese el primer número: ");
		if (!double.TryParse(Console.ReadLine(), out double num1))
		{
			Console.WriteLine("Valor no válido.");
			return;
		}

		Console.Write("Ingrese el segundo número: ");
		if (!double.TryParse(Console.ReadLine(), out double num2))
		{
			Console.WriteLine("Valor no válido.");
			return;
		}

		double resultado = num1 + num2;
		Console.WriteLine($"El resultado de {num1} + {num2} = {resultado}");
	}

	static void RealizarResta()
	{
		Console.Clear();
		Console.WriteLine("-- RESTA --");
		Console.Write("Ingrese el primer número: ");
		if (!double.TryParse(Console.ReadLine(), out double num1))
		{
			Console.WriteLine("Valor no válido.");
			return;
		}

		Console.Write("Ingrese el segundo número: ");
		if (!double.TryParse(Console.ReadLine(), out double num2))
		{
			Console.WriteLine("Valor no válido.");
			return;
		}

		double resultado = num1 - num2;
		Console.WriteLine($"El resultado de {num1} - {num2} = {resultado}");
	}

	static void RealizarMultiplicacion()
	{
		Console.Clear();
		Console.WriteLine("-- MULTIPLICACIÓN --");
		Console.Write("Ingrese el primer número: ");
		if (!double.TryParse(Console.ReadLine(), out double num1))
		{
			Console.WriteLine("Valor no válido.");
			return;
		}

		Console.Write("Ingrese el segundo número: ");
		if (!double.TryParse(Console.ReadLine(), out double num2))
		{
			Console.WriteLine("Valor no válido.");
			return;
		}

		double resultado = num1 * num2;
		Console.WriteLine($"El resultado de {num1} × {num2} = {resultado}");
	}

	static void RealizarDivision()
	{
		Console.Clear();
		Console.WriteLine("-- DIVISIÓN --");
		Console.Write("Ingrese el dividendo: ");
		if (!double.TryParse(Console.ReadLine(), out double num1))
		{
			Console.WriteLine("Valor no válido.");
			return;
		}

		Console.Write("Ingrese el divisor: ");
		if (!double.TryParse(Console.ReadLine(), out double num2))
		{
			Console.WriteLine("Valor no válido.");
			return;
		}

		if (num2 == 0)
		{
			Console.WriteLine("Error: No es posible dividir por cero.");
			return;
		}

		double resultado = num1 / num2;
		Console.WriteLine($"El resultado de {num1} ÷ {num2} = {resultado}");
	}

	static void RealizarPotencia()
	{
		Console.Clear();
		Console.WriteLine("-- POTENCIA --");
		Console.Write("Ingrese la base: ");
		if (!double.TryParse(Console.ReadLine(), out double baseNum))
		{
			Console.WriteLine("Valor no válido.");
			return;
		}

		Console.Write("Ingrese el exponente: ");
		if (!double.TryParse(Console.ReadLine(), out double exponente))
		{
			Console.WriteLine("Valor no válido.");
			return;
		}

		double resultado = Math.Pow(baseNum, exponente);
		Console.WriteLine($"El resultado de {baseNum}^{exponente} = {resultado}");
	}
}