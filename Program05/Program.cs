namespace Program05;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("--- VALORES LOGICOS ---");

        //SOLO TRUE O FALSE //
        bool tareaPendiente = true;

        Console.WriteLine("BOOLEANO");
        Console.WriteLine("SOLO PODEMOS USAR EL TRUE O FALSE");
        Console.WriteLine("¿TERMINO LA TAREA?  " +  tareaPendiente);
        
        Console.WriteLine("\nPresiona ENTER para finalizar.");
        Console.ReadLine();

        // ----------------------------------------- //

        Console.WriteLine("--- ESTADO DE PAGO ---");

        // SOLO TRUE O FALSE //
        bool facturaPagada = false;

        Console.WriteLine("BOOLEANO");
        Console.WriteLine("Solo se usa True o false");
        Console.WriteLine("¿La factura esta pagada?: "+ facturaPagada);

        Console.WriteLine("\nPresione ENTER para finalizar.");
        Console.ReadLine();

        // ----------------------------------------- //

        Console.WriteLine("--- SISEMA DE ALARMAS ---");

        // SOLO TRUO O FALSE //
        bool puertaAbierta = true;

        Console.WriteLine("BOOLEANO");
        Console.WriteLine("Para saber si el sensor esta activo");
        Console.WriteLine("¿Esta abierta la puerta?: " + puertaAbierta);

        Console.WriteLine("\nPresione ENTER para finalizar.");
        Console.ReadLine();

        // ----------------------------------------- //

        Console.WriteLine("--- CONTROL DE INVENTARIO ---");

        // SOLO TRUE O FALSE //
        bool hayStock = true;

        Console.WriteLine("BOOLEANO");
        Console.WriteLine("Ideal para saber si queda stock en los productos.");
        Console.WriteLine("¿Hay muebles disponibles?: " + hayStock);

        Console.WriteLine("\nPresione ENTER para finalizar.");
        Console.ReadLine();

        // ----------------------------------------- //

        Console.WriteLine("--- ESTADO DE LA RED ---");

        // SOLO TRUE O FALSE //
        bool tieneInternet = true;

        Console.WriteLine("BOOLEANO");
        Console.WriteLine("Verifica si el equipo esta actvo.");
        Console.WriteLine("¿Hay internet?: " + tieneInternet);

        Console.WriteLine("\nPresione ENTER para finalizar.");
        Console.ReadLine();

    }
}
