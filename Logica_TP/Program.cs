using System;

namespace Array
{
    class Ejercicio
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Datos de usuarios...");

            string[] nombre = new string[20];
            int[] edad = new int[20];

            Console.WriteLine("Ingrese su Nombre: ");
            nombre[0] = Console.ReadLine();

            Console.WriteLine("Ingrese su Edad: ");
            edad[0] = int.Parse(Console.ReadLine());

            Console.WriteLine("Validando datos del cliente....");


            for (int i = 0; i < 1; i++)
            {
                if (edad[i] >= 18) {
                    Console.WriteLine(nombre[i] + " Puede ingrresar al Boliche.");
                } else
                {
                    Console.WriteLine(nombre[i] + " Vaya para la casa CAPO.");
                }
            }

            Console.ReadLine();
        }
    }
}
