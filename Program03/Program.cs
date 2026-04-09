using System;
using System.Runtime;

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

            // ----------------------------------------- //

            Console.WriteLine("--- DATOS DE MEDICION ---");

            double estaturaPersona = 1.81;

            Console.WriteLine("Tipo decimal double");
            Console.WriteLine("Para controlar los metros y centimetros.");
            Console.WriteLine("Estatura registrada: " + estaturaPersona + " metros");


            Console.WriteLine("--- DATOS FINANCIEROS ---");

            decimal precioEntrada = 1500.50m;
            Console.WriteLine("Tipo decimal financiero: ");
            Console.WriteLine("Cuando lo utilizamos para dinero se debe usar la 'm'");
            Console.WriteLine("Valor de la entrada: $" + precioEntrada);

            Console.WriteLine("\nPresiona ENTER para cerrar.");
            Console.ReadLine();

            // ----------------------------------------- //

            Console.WriteLine("-- CONTROL DE COMBUSTIBLE ---");

            double litrosCargados = 45.8;
            Console.WriteLine("Tipo deciaml double");
            Console.WriteLine("Ideal para medir volumenes de liquidos.");
            Console.WriteLine("Cantidad de litros: " + litrosCargados);


            Console.WriteLine("--- TARIFA APLICADA ---");

            decimal totalFacturado = 54200.75m;
            Console.WriteLine("Tipo de decimal financiero: ");
            Console.WriteLine("Usamos la 'm'");
            Console.WriteLine("Total a pagar: $" + totalFacturado);

            Console.WriteLine("\nPresiona ENTER para cerrar.");
            Console.ReadLine();

            // ----------------------------------------- //

            Console.WriteLine("--- REPORTE DEL CLIMA ---");

            double temperaturaClima = 24.5;
            Console.WriteLine("Tipo decimal double");
            Console.WriteLine("Usado para los grados de la temperatura.");
            Console.WriteLine("Clima actual: " + temperaturaClima + "°C");


            Console.WriteLine("--- RECIBO DE SUELDO ---");

            decimal sueldoNeto = 850000.00m;
            Console.WriteLine("Tipo decimal financiero.");
            Console.WriteLine("Para contabilidad usamos decimal con la 'm'");
            Console.WriteLine("Sueldo despositado: $" + sueldoNeto);

            Console.WriteLine("\nPresiona ENTER para cerrar.");
            Console.ReadLine();

            // ----------------------------------------- //

            Console.WriteLine("--- INGRESO DE MATERIA PRIMA ---");

            double pesoHarina = 50.25;
            Console.WriteLine("Tipo decimal double");
            Console.WriteLine("Para pesar bolsas en la panaderia.");
            Console.WriteLine("Peso del saco: " + pesoHarina + "Kg");


            Console.WriteLine("--- PRESUPUESTO ASIGNADO ---");

            decimal presupuestoMateriales = 125400.30m;
            Console.WriteLine("Tipo decimal financiero");
            Console.WriteLine("Para perder nada de dinero.");
            Console.WriteLine("Presupuesto total: $" + presupuestoMateriales);

            Console.WriteLine("\nPresiona ENTER para cerrar.");
            Console.ReadLine();
        }
    }
}