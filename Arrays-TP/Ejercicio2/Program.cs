using System;

namespace GuiaArreglos
{
    class Ejercicio02
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- EJERCICIO 2: INICIALIZACION DIRECTA Y FOREACH ----");

            string[] frutas = {"Manzana", "Banana", "Sandia", "Uva", "Pera"};

            Console.WriteLine("Lista de frutas...");

            foreach (string fruta in frutas)
            {
                Console.WriteLine("--" + fruta);
            }

            Console.WriteLine("\nPresione ENTER para continuar....");
            Console.ReadLine();


            //------------------------------------------------------//

            int[] sucursales = {101, 102, 104, 105, 109};

            Console.WriteLine("Codigos de sucursales:");

            foreach (int codigo in sucursales)
            {
                Console.WriteLine("Sucursal nro: " + codigo);
            }

            Console.WriteLine("\nPresione ENTER para continuar....");
            Console.ReadLine();

            
            //----------------------------------------------------//

            string[] talles = {"S", "M", "L", "XL", "XXL"};

            Console.WriteLine("Talles disponibles:");

            foreach (string medidas in talles)
            {
                Console.WriteLine("Talles: " + medidas);
            }

            Console.WriteLine("\nPresione ENTER para continuar....");
            Console.ReadLine();

            //-----------------------------------------------------//


            int[] años = {2, 5, 8, 10, 14};

            Console.WriteLine("Antiguedad del empleado (años):");

            foreach (int año in años)
            {
                Console.WriteLine("Tiempo: " + año + " años");
            }

            Console.WriteLine("\nPresione ENTER para continuar....");
            Console.ReadLine();

            //----------------------------------------------------------//

            char[] letras = {'E', 'J', 'G', 'T', 'K'};

            Console.WriteLine("Letras sueltas:");

            foreach (char letra in letras)
            {
                Console.WriteLine("Letras disponibles: " + letra);
            }

            Console.WriteLine("\nPresione ENTER para continuar....");
            Console.ReadLine();

        }
    }
}
