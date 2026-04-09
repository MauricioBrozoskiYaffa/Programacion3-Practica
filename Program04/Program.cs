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

            // ----------------------------------------- //

            Console.WriteLine("--- DATOS DEL ALUMNO ---");

            // USANDO COMILLAS DOBLES //
            string apellido = "Brozoski";
            Console.WriteLine("Tipo texto string: ");
            Console.WriteLine("Valor guardado: " + apellido);

            // USANDO COMILLAS SIMPLES //
            char division = 'B';
            Console.WriteLine("Tipo caracter char: ");
            Console.WriteLine("Valor guardado: " + division );

            Console.WriteLine("Presina ENTER para cerrar.");
            Console.ReadLine();

            // ----------------------------------------- //

            Console.WriteLine("--- CLASIFICACION DE STOCK ---");

            // USANDO COMILLAS DOBLES //
            string categoria = "Electronica / Computacion";
            Console.WriteLine("Tipo de texto string: ");
            Console.WriteLine("Valor guardado: " + categoria);

            // USANDO COMILLAS SIMPLE //
            char talle = 'L';
            Console.WriteLine("Tipo caracter char: ");
            Console.WriteLine("Valor guardado: " + talle);

            Console.WriteLine("Presina ENTER para cerrar.");
            Console.ReadLine();

            // ----------------------------------------- //

            Console.WriteLine("--- RESULTADO DE EXAMEN ---");

            // USANDO COMILLAS DOBLES //
            string materia = "Programacion III";
            Console.WriteLine("Tipo texto string: ");
            Console.WriteLine("Valor guardado: " + materia);

            // USANDO COMILLAS SIMPLES //
            char notaLetra = 'A';
            Console.WriteLine("Tipo caracter char: ");
            Console.WriteLine("Valor guardado: " + notaLetra);

            Console.WriteLine("Presiona ENTER para cerrar.");
            Console.ReadLine();

            // ----------------------------------------- //

            Console.WriteLine("--- PERFIL DE USUARIO ---");

            // USANDO COMILLAS DOBLES //
            string pais = "Argentina";
            Console.WriteLine("Tipo texto string: ");
            Console.WriteLine("Valor guardado: " + pais);

            // USANDO COMILLAS SIMPLE //
            char genero = 'M';
            Console.WriteLine("Tipo caracter char.");
            Console.WriteLine("Valor guardado: " + genero);

            Console.WriteLine("Presiona ENTER para cerrar.");
            Console.ReadLine();
        }
    }
}