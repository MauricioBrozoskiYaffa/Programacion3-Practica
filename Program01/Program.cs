namespace Program01
{
    class Progeam
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-- INGRESE SUS DATOS --");

            Console.WriteLine("Ingrese el tipo de corte de carne que quiere comprar.");
            string corteDeCarne = Console.ReadLine();

            Console.WriteLine("Ingrese la cantidad de Kg que va a comprar");
            string numeroTexto = Console.ReadLine();
            int kg = int.Parse(numeroTexto);

            Console.WriteLine("Ingrese los gramos del Kg de carne");
            double peso = double.Parse(Console.ReadLine());

            Console.WriteLine("\n--- Ticket de Compra ---");
            Console.WriteLine("Corte elegido: " + corteDeCarne);
            Console.WriteLine("Cantidad de KG comprados: " + kg);
            Console.WriteLine("Gramos del KG comprado: " + peso);

            Console.WriteLine("\n Presine ENTER para volver a pesar.");
            Console.ReadLine();

            // ----------------------------------------- //

            Console.WriteLine("--- FICHA DEL SOCIO ---");

            Console.WriteLine("Ingrese el nombre del socio:");
            string socio = Console.ReadLine();

            Console.WriteLine("Ingrese la edad del socio:");
            string edadTexto = Console.ReadLine();
            int edad = int.Parse(edadTexto);

            Console.WriteLine("Ingrese el peso actual del socio:");
            double pesoSocio = double.Parse(Console.ReadLine());

            Console.WriteLine("--- INFORMACIÓN CARGADA ---");
            Console.WriteLine("Nombre del Socio: " + socio);
            Console.WriteLine("Edad: " + edad);
            Console.WriteLine("Peso: " + pesoSocio);

            Console.WriteLine("\n Presione ENTER para registrar otro.");
            Console.ReadLine();

            // ----------------------------------------- //

            Console.WriteLine("--- CARGA DE COMBUSTIBLE ---");

            Console.WriteLine("Ingrese el tipo de nafta (Súper o Premium):");
            string tipoNafta = Console.ReadLine();

            Console.WriteLine("Ingrese la cantidad de litros:");
            string litrosTexto = Console.ReadLine();
            int litros = int.Parse(litrosTexto);

            Console.WriteLine("Ingrese el costo por litro:");
            double costoLitro = double.Parse(Console.ReadLine());

            Console.WriteLine("--- DETALLE DE CARGA ---");
            Console.WriteLine("Tipo: " + tipoNafta);
            Console.WriteLine("Litros: " + litros);
            Console.WriteLine("Costo por Litro: " + costoLitro);

            Console.WriteLine("\n Presione ENTER para nueva carga.");
            Console.ReadLine();

            // ----------------------------------------- //

            Console.WriteLine("--- VENTA DE EQUIPOS ---");

            Console.WriteLine("Ingrese el modelo de la Laptop:");
            string modelo = Console.ReadLine();

            Console.WriteLine("Ingrese meses de garantía:");
            string garantiaTexto = Console.ReadLine();
            int mesesGarantia = int.Parse(garantiaTexto);

            Console.WriteLine("Ingrese el tamaño de pantalla (pulgadas):");
            double pulgadas = double.Parse(Console.ReadLine());

            Console.WriteLine("--- ESPECIFICACIONES ---");
            Console.WriteLine("Modelo: " + modelo);
            Console.WriteLine("Garantía (meses): " + mesesGarantia);
            Console.WriteLine("Pantalla: " + pulgadas);

            Console.WriteLine("\n Presione ENTER para facturar.");
            Console.ReadLine();

            // ----------------------------------------- //

            Console.WriteLine("--- PEDIDO DE DELIVERY ---");

            Console.WriteLine("Ingrese el gusto de la pizza:");
            string gusto = Console.ReadLine();

            Console.WriteLine("Ingrese el número de mesa o departamento:");
            string deptoTexto = Console.ReadLine();
            int numeroDepto = int.Parse(deptoTexto);

            Console.WriteLine("Ingrese la distancia del envío (Km):");
            double distancia = double.Parse(Console.ReadLine());

            Console.WriteLine("--- TICKET DE SALIDA ---");
            Console.WriteLine("Pedido: " + gusto);
            Console.WriteLine("Ubicación: " + numeroDepto);
            Console.WriteLine("Distancia de envío: " + distancia);

            Console.WriteLine("\n Presione ENTER para enviar pedido.");
            Console.ReadLine();

        }
    }
}
