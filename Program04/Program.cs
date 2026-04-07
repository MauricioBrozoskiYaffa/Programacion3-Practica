using System;

namespace Program04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- TEXTO Y CARACTERES ---");

            // USANDO LAS COMILLAS DOBLES "" //
            string nombre = "Obi Wan";
            Console.WriteLine("TIPO TEXTO (string): ");
            Console.WriteLine(" Valor guardado: " + nombre);

            // USANDO LAS COMILLAS SIMPLRE '' //
            char inicialNombre = 'O';
            Console.WriteLine("TIPO CAR CTER (char): ");
            Console.WriteLine("   Valor guardado: '" + inicialNombre + "'");

            Console.WriteLine("Presiona ENTER para cerrar.");
            Console.ReadLine();
        }
    }
}