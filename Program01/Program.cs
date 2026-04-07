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
            
        }
    }
}
