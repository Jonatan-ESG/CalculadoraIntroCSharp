namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Bienvenido a la calculadora");
                Console.WriteLine("Seleccione una operación:");
                Console.WriteLine("1. Suma");
                Console.WriteLine("2. Resta");
                Console.WriteLine("3. Multiplicación");
                Console.WriteLine("4. División");

                string opcionReadLine = Console.ReadLine();

                int opcion;

                if (int.TryParse(opcionReadLine, out opcion) == false)
                {
                    Console.WriteLine("La opción debe ser un número entero");
                    return;
                }

                Console.WriteLine("Ingrese el primer número:");
                double primerNumero = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Ingrese el segundo número:");
                double segundoNumero = Convert.ToDouble(Console.ReadLine());

                double resultado = 0;

                switch (opcion)
                {
                    case 1:
                        resultado = primerNumero + segundoNumero;
                        break;
                    case 2:
                        resultado = primerNumero - segundoNumero;
                        break;
                    case 3:
                        resultado = primerNumero * segundoNumero;
                        break;
                    case 4:
                        if (segundoNumero != 0)
                        {
                            resultado = primerNumero / segundoNumero;
                        }
                        else
                        {
                            Console.WriteLine("Error: No se puede dividir por cero.");
                            return;
                        }
                        break;
                    default:
                        Console.WriteLine("Opción no válida.");
                        return;
                }

                Console.WriteLine($"El resultado es: {resultado}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

        }

    }
}
