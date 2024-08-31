namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido a la calculadora");
            Console.WriteLine("Seleccione una operación:");
            Console.WriteLine("1. Suma");
            Console.WriteLine("2. Resta");
            Console.WriteLine("3. Multiplicación");
            Console.WriteLine("4. División");

            int opcion = Convert.ToInt32(Console.ReadLine());

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
                default:
                    Console.WriteLine("Opción no válida");
                    return;
            }

            Console.WriteLine($"El resultado es: {resultado}");

        }

    }
}
