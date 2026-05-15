using System;

namespace CalculoDelivery
{
    class Program
    {
        // 1. Variable estática/global: Representa una regla fija del negocio
        static double limiteCercano = 5;

        static void Main(string[] args)
        {
            // Entrada de datos
            Console.Write("Ingrese la distancia del pedido (en km): ");
            double distancia = double.Parse(Console.ReadLine());

            // 2. Llamada a la función con retorno
            double costoDelivery = CalcularDelivery(distancia);

            // Salida de resultados
            Console.WriteLine($"El costo del delivery es: S/{costoDelivery:F2}");

            // Pausa para ver el resultado
        }

        // 3. Función con retorno y condicional
        static double CalcularDelivery(double distancia)
        {
            if (distancia <= limiteCercano)
            {
                return 6.00; // Costo para 5km o menos
            }
            else
            {
                return 10.00; // Costo si supera los 5km
            }
        }
    }
}