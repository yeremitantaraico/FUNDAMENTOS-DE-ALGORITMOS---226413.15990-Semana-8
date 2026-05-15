using System;

namespace ControlAforoLaboratorio
{
    class Program
    {
        // Variable estática para el aforo máximo
        static int aforoMaximo = 30;

        static void Main(string[] args)
        {
            // 1. Leer cuántos estudiantes ingresaron
            Console.Write("Ingrese la cantidad de estudiantes: ");
            int cantidadEstudiantes = int.Parse(Console.ReadLine());

            // 2. Validar si el aforo es permitido (Función con retorno bool)
            bool permitido = ValidarAforo(cantidadEstudiantes);

            // 3. Mostrar el mensaje de autorización o alerta (Función void)
            MostrarResultado(cantidadEstudiantes, permitido);

            // Mantener la consola abierta
            Console.WriteLine("\nPresione cualquier tecla para salir...");
            Console.ReadKey();
        }

        // Función con retorno bool: Valida una condición y devuelve verdadero o falso
        static bool ValidarAforo(int cantidadEstudiantes)
        {
            return cantidadEstudiantes <= aforoMaximo;
        }

        // Función void: Solo muestra el resultado al usuario
        static void MostrarResultado(int cantidadEstudiantes, bool permitido)
        {
            if (permitido)
            {
                Console.WriteLine("Ingreso permitido.");
            }
            else
            {
                Console.WriteLine("Aforo excedido.");
            }
        }
    }
}