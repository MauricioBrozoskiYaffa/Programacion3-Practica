namespace Program07;

class Program
{
    static void Main(string[] args)
    {
        // CONSTANTE DE CALCULO //

        const decimal MAS_IVA = 0.25m; // 21% fijo
        const bool PRUEBA = true; // control de la seguridad
        const char SIMBOLO = '$';

        Console.WriteLine("--- Facturacion --- ");
        Console.WriteLine("Modo de prueba activado: " + PRUEBA);

        decimal PRECIO = 2500.60m;
        decimal IMPUESTO = PRECIO * MAS_IVA;
        decimal TOTAL = PRECIO + IMPUESTO;

        Console.WriteLine("\n Detalle de la compra realizada: ");
        Console.WriteLine("Precio: " + SIMBOLO + PRECIO);
        Console.WriteLine("IVA (" + (MAS_IVA * 100) + "%): " + SIMBOLO + IMPUESTO);
        Console.WriteLine("Total a pagar: " + SIMBOLO + TOTAL);

        Console.ReadLine();
    }
}
