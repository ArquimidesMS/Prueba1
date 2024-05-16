using System;

namespace CalculadoraMatematica
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculadora Matemática - Multiplicación");

            try
            {
                Console.Write("Ingrese el primer número: ");
                decimal num1 = decimal.Parse(Console.ReadLine());

                Console.Write("Ingrese el segundo número: ");
                decimal num2 = decimal.Parse(Console.ReadLine());

                // Crear una instancia de la operación de Multiplicación
                OperacionMatematica.Operacion operacion = new OperacionMatematica.Multiplicacion();

                // Calcular el resultado utilizando polimorfismo
                decimal resultado = operacion.Calcular(num1, num2);

                Console.WriteLine($"El resultado de la multiplicación es: {resultado}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Entrada inválida. Por favor ingrese un número válido.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}