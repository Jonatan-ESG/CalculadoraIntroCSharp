namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int opcion = SolicitarOpcion();
                double primerNumero;
                double segundoNumero;

                if (opcion == 0) return;

                Console.WriteLine("Ingrese el primer número:");
                
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
                        resultado = Sumar(primerNumero, segundoNumero);
                        break;
                    case 2:
                        resultado = Restar(primerNumero, segundoNumero);
                        break;
                    case 3:
                        resultado = Multiplicar(primerNumero, segundoNumero);
                        break;
                    case 4:
                        resultado = Dividir(primerNumero, segundoNumero);
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

        public static double Sumar(double primerNumero, double segundoNumero)
        {
            double resultado = primerNumero + segundoNumero;
            return resultado;
        }
        public static double Restar(double primerNumero, double segundoNumero)
        {
            double resultado = primerNumero - segundoNumero;
            return resultado;
        }
        public static double Multiplicar(double primerNumero, double segundoNumero)
        {
            double resultado = primerNumero * segundoNumero;
            return resultado;
        }
        public static double Dividir(double primerNumero, double segundoNumero)
        {
            double resultado = 0;
            if (segundoNumero == 0)
            {
                Console.WriteLine("Error: No se puede dividir por cero.");
            }
            else
            {
                resultado = primerNumero / segundoNumero;
            }
            return resultado;
        }

        public static int SolicitarOpcion()
        {
            Console.WriteLine("Bienvenido a la calculadora");
            Console.WriteLine("Seleccione una operación:");
            Console.WriteLine("1. Suma");
            Console.WriteLine("2. Resta");
            Console.WriteLine("3. Multiplicación");
            Console.WriteLine("4. División");

            int opcion = 0;

            string opcionReadLine = Console.ReadLine();

            if (int.TryParse(opcionReadLine, out opcion) == false)
            {
                Console.WriteLine("La opción debe ser un número entero");
            }

            return opcion;

        }

    }
}
