using System;

namespace GuiaArreglos
{
    class Ejercicio01
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- EJERCICIO 1: FUNDAMENTOS DE ARREGLOS ---");

            int[] numeros = new int[5];

            numeros[0] = 3;
            numeros[1] = 4;
            numeros[2] = 5;
            numeros[3] = 6;
            numeros[4] = 7;

            Console.WriteLine("Valor en indice 0: " + numeros[0]);
            Console.WriteLine("Valor en indice 1: " + numeros[1]);
            Console.WriteLine("Valor en indice 2: " + numeros[2]);
            Console.WriteLine("Valor en indice 3: " + numeros[3]);
            Console.WriteLine("Valor en indice 4: " + numeros[4]);

            Console.WriteLine("\nPresione ENTER para continuar....");
            Console.ReadLine();

            // -------------------------------------------------- //

            int[] edades = new int[5];

            edades[0] = 18;
            edades[1] = 22;
            edades[2] = 24;
            edades[3] = 26;
            edades[4] = 28;

            Console.WriteLine("Edad 1: " + edades[0]);
            Console.WriteLine("Edad 2: " + edades[1]);
            Console.WriteLine("Edad 3: " + edades[2]);
            Console.WriteLine("Edad 4: " + edades[3]);
            Console.WriteLine("Edad 5: " + edades[4]);
            
            Console.WriteLine("\nPresione ENTER para continuar....");
            Console.ReadLine();


            // -------------------------------------------------- //

            string[] nombres = new string[5];

            nombres[0] = "Juan";
            nombres[1] = "Carla";
            nombres[2] = "Pedro";
            nombres[3] = "Micaela";
            nombres[4] = "Daniel";

            Console.WriteLine("Primer nombre: " + nombres[0]);
            Console.WriteLine("Segundo nombre: " + nombres[1]);
            Console.WriteLine("Tercer nombre: " + nombres[2]);
            Console.WriteLine("Cuarto nombre: " + nombres[3]);
            Console.WriteLine("Quinto nombre: " + nombres[4]);

            Console.WriteLine("\nPresione ENTER para continuar....");
            Console.ReadLine();

            // -------------------------------------------------- //

            char[] categorias = new char[5];

            categorias[0] = 'A';
            categorias[1] = 'B';
            categorias[2] = 'C';
            categorias[3] = 'D';
            categorias[4] = 'E';

            Console.WriteLine("Categoria Inicial: " + categorias[0]);
            Console.WriteLine("Categoria Siguiente: " + categorias[1]);
            Console.WriteLine("Categoria Siguiente: " + categorias[2]);
            Console.WriteLine("Categoria Siguiente: " + categorias[3]);
            Console.WriteLine("Categoria Siguiente: " + categorias[4]);

            Console.WriteLine("\nPresione ENTER para continuar....");
            Console.ReadLine();

            // -------------------------------------------------- //

            int[] años = new int[5];

            años[0] = 2022;
            años[1] = 2023;
            años[2] = 2024;
            años[3] = 2025;
            años[4] = 2026;

            Console.WriteLine("Año inicial: " + años[0]);
            Console.WriteLine("Año siguiente año: " + años[1]);
            Console.WriteLine("Año siguiente año: " + años[2]);
            Console.WriteLine("Año siguiente año: " + años[3]);
            Console.WriteLine("Año actual: " + años[4]);

            Console.WriteLine("\nPresione ENTER para continuar....");
            Console.ReadLine();
        }
    }
}
