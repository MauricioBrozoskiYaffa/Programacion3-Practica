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

        // ----------------------------------------- //

        const string NOMBRE_GYM = "El aguante";
        const string REGLA = "TRAER TOALLA";
        const int PESO_MAX_DISCO = 25;

        Console.WriteLine("=== " + NOMBRE_GYM + "(" + REGLA + ") ===");
        Console.WriteLine("Preparando el box... ");
        Console.WriteLine("El disco mas grande es de: " + PESO_MAX_DISCO + "KG.");

        const int PESO_CLIENTE = 30;
        const bool PUEDE_LEVANTAR = PESO_CLIENTE <= PESO_MAX_DISCO;

        Console.WriteLine("\n Verificando el peso elegido: " + PESO_CLIENTE + "KG.");
        Console.WriteLine("Peso maximo permitido: " + PESO_MAX_DISCO);
        Console.WriteLine("¿Puede usar este disco?: " + PUEDE_LEVANTAR);

        Console.WriteLine("Constante NOMBRE_GYM = " + NOMBRE_GYM);
        Console.WriteLine("Constante REGLA = " + REGLA);

        Console.ReadLine();

        // ----------------------------------------- //

        const string SERVIDOR = "C8-GAMING";
        const string MODO = "HARDCORE";
        const int JUGADORES_MAX = 10;

        Console.WriteLine("=== " + SERVIDOR + "(" + MODO + ") ===");
        Console.WriteLine("INICIANDO PARTIDA... ");
        Console.WriteLine("CAPACIDAD MAXIMA: " + JUGADORES_MAX + " PERSONAS.");

        const int JUGADORES_ACTUALES = 12;
        const bool HAY_LUGAR = JUGADORES_ACTUALES <= JUGADORES_MAX;

        Console.WriteLine("\n Verificando cola de espera: " + JUGADORES_ACTUALES + " queriendo entrar.");
        Console.WriteLine("Limite del server: " + JUGADORES_MAX);
        Console.WriteLine("¿Se puede unir?: " + HAY_LUGAR);

        Console.ReadLine();

        // ----------------------------------------- //

        const string AEROLINEA = "Vuela Alto";
        const string CATEGORIA = "TURISTA";
        const int EQUIPAJE_MAX = 23;

        Console.WriteLine("=== " + AEROLINEA + "(" + CATEGORIA +") ===");
        Console.WriteLine("Pesando Valijas... ");
        Console.WriteLine("Limite por persona: " + EQUIPAJE_MAX + "KG.");

        const int PESO_VALIJA = 25;
        const bool EQUIPAJE_OK = PESO_VALIJA <= EQUIPAJE_MAX;

        Console.WriteLine("\n Verificando el peso de la valija: " + PESO_VALIJA + "KG.");
        Console.WriteLine("Limite permitido: " + EQUIPAJE_MAX);
        Console.WriteLine("¿Despacha sin cargo?: " + EQUIPAJE_OK);

        Console.ReadLine();

        // ----------------------------------------- //

        const string PROVEEDOR = "Fibra-Brozo";
        const string TIPO_CONEXION = "Dedicada";
        const int VELOCIDAD_MINIMA = 100;

        Console.WriteLine("=== " + PROVEEDOR + "(" + TIPO_CONEXION +") ===");
        Console.WriteLine("Testeando Velocidad.... ");
        Console.WriteLine("El contrato exige minimo " + VELOCIDAD_MINIMA + " MBPS.");

        const int VELOCIDAD_ACTUAL = 85;
        const bool CUMPLE_SERVICIO = VELOCIDAD_ACTUAL >= VELOCIDAD_MINIMA;

        Console.WriteLine("\n Medicion realizada: " + VELOCIDAD_ACTUAL + "Mbps.");
        Console.WriteLine("Minimo por contrato: " + VELOCIDAD_MINIMA);
        Console.WriteLine("¿El servicio es correcto?: " + CUMPLE_SERVICIO);

        Console.ReadLine();
    }
}
