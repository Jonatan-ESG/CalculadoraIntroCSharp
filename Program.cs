namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                SaludoInicial();
                string opcionReadLine = Console.ReadLine();

                int opcion;

                if (int.TryParse(opcionReadLine, out opcion) == false)
                {
                    Console.WriteLine("La opción debe ser un número entero");
                    return;
                }

                Console.WriteLine("Ingrese el primer número:");

                double primerNumero;
                double segundoNumero;

                if (double.TryParse(Console.ReadLine(), out primerNumero) == false)
                {
                    Console.WriteLine("El primer número debe ser un número entero o decimal");
                    return;
                }

                Console.WriteLine("Ingrese el segundo número:");
                if (double.TryParse(Console.ReadLine(), out segundoNumero) == false)
                {
                    Console.WriteLine("El primer número debe ser un número entero o decimal");
                    return;
                }

                double resultado = 0;

                switch (opcion)
                {
                    case 1:
                        resultado = Suma(primerNumero, segundoNumero);
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

        public static double Suma(double primerNumero, double segundoNumero) {
            double resultado = primerNumero + segundoNumero;
            return resultado;        
        }

        public static void SaludoInicial()
        {
            Console.WriteLine("Bienvenido a la calculadora");
            Console.WriteLine("Seleccione una operación:");
            Console.WriteLine("1. Suma");
            Console.WriteLine("2. Resta");
            Console.WriteLine("3. Multiplicación");
            Console.WriteLine("4. División");
        }

    }
}
