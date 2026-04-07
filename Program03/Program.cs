using System;

namespace Program03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- NUMEROS DECIMALES ---");

            double pesoAzucar = 10.5;
            Console.WriteLine(" Tipo decimal Double");
            Console.WriteLine(" Para controlar los numeros que tienen coma.");
            Console.WriteLine(" Peso total del Azuca: " + pesoAzucar);


            Console.WriteLine("--- OTRO FORMA DECIMAL ---");

            decimal precioProducto = 199.99m;
            Console.WriteLine(" TIPO DECIMAL FINANCIERO: ");
            Console.WriteLine(" Cuando lo utilizamos para dinero debemos poner 'm'");
            Console.WriteLine("   Valor guardado: $" + precioProducto);

            Console.WriteLine("\nPresiona ENTER para cerrar.");
            Console.ReadLine();
        }
    }
}