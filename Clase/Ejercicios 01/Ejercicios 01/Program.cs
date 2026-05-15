using System;

namespace Ejercicios_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el consumo del cliente:");
            double consumo = double.Parse(Console.ReadLine());

            double propina = CalcularPropina(consumo);
            double total = CalcularTotal(consumo, propina);

            Console.WriteLine($"Consumo: {consumo}");
            Console.WriteLine($"Propina: {propina}");
            Console.WriteLine($"Total a pagar: {total}");
        }

        static double CalcularPropina(double consumo)
        {
            return consumo * 0.10;
        }

        static double CalcularTotal(double consumo, double propina)
        {
            return consumo + propina;
        }
    }
}