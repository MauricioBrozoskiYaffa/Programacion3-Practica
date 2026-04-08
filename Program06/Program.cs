namespace Program06;

class Program

{
    static void Main(string[] args)
    {
        // USO DE CONSTANTES DE IDENTIDAD Y REGLAS //

        const string NOMBRE_BAR = "Tamagochi";
        const string AMBIENTE = "SIN TURROS";
        const int EDAD_MINIMA = 18;

        Console.WriteLine("=== " + NOMBRE_BAR + "(" + AMBIENTE + ") ===");
        Console.WriteLine("CARGANDO DISPONIBILIDAD...");
        Console.WriteLine("NO SE PERMITE MENORES DE " + EDAD_MINIMA + " AÑOS.");

        //USO DE LAS CONSTANTES SIN ESTRUCTURA //
        const int EDAD_CLIENTE = 19;
        const bool PUEDE_INGRESAR = EDAD_CLIENTE >= EDAD_MINIMA;

        Console.WriteLine("\n Verificando la edad del cliente: " + EDAD_CLIENTE + " años. ");
        Console.WriteLine("Edad minima: " + EDAD_MINIMA);
        Console.WriteLine("Verificando permiso: " + PUEDE_INGRESAR);

        //CONSTANTES PARA REFORMAR CONCEPTOS //
        Console.WriteLine("Constante NOMBRE_BAR = " + NOMBRE_BAR);
        Console.WriteLine("Constante AMBIENTE = " + AMBIENTE);

        Console.ReadLine();
    }
}
