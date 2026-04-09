using System.Reflection.Metadata;

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

        // ----------------------------------------- //

        const decimal IVA = 0.21m;
        const bool MODO_STOCK = true;
        const char MONEDA = '$';

        Console.WriteLine("--- COMPONENTES PC ---");
        Console.WriteLine("Verificando el stock: " + MODO_STOCK);

        decimal VALOR = 85000.00m;
        decimal VALOR_IMPUESTO = PRECIO * IVA;
        decimal FINAL = VALOR + VALOR_IMPUESTO;

        Console.WriteLine("\n Detalle del hardware: ");
        Console.WriteLine("Precio base: " + MONEDA + VALOR);
        Console.WriteLine("IVA aplicado (" + (IVA * 100) + "%):" + MONEDA + VALOR_IMPUESTO);
        Console.WriteLine("Total con IVA: " + MONEDA + FINAL);

        Console.ReadLine();

        // ----------------------------------------- //

        const decimal CARGO_SERVICIO = 0.05m;
        const bool ESTADO_RED = true;
        const char SIGNO = '$';

        Console.WriteLine("--- Factura de Internet ---");
        Console.WriteLine("Conexion estable: " + ESTADO_RED);

        decimal ABONO_MENSUAL = 18000.00m;
        decimal EXTRA = ABONO_MENSUAL * CARGO_SERVICIO;
        decimal TOTAL_MES = ABONO_MENSUAL + EXTRA;

        Console.WriteLine("\n Detalle del abono: ");
        Console.WriteLine("Abono Basico: " + SIGNO + ABONO_MENSUAL);
        Console.WriteLine("Cargo Extra (" + (CARGO_SERVICIO * 100) + "%):" + SIGNO + EXTRA);
        Console.WriteLine("Total del periodo: " + SIGNO + TOTAL_MES);

        Console.ReadLine();

        // ----------------------------------------- //

        const decimal RETENCION = 0.33m;
        const bool EXPORTA = true;
        const char USD = 'U';

        Console.WriteLine("--- Comercio Exterior ---");
        Console.WriteLine("Permiso de embarque: " + EXPORTA);

        decimal VALOR_TONELADA = 450.00M;
        decimal DESCUENTO_ADUANA = VALOR_TONELADA * RETENCION;
        decimal LIQUIDACION = VALOR_TONELADA - DESCUENTO_ADUANA;

        Console.WriteLine("\n Liquidacion de grano: ");
        Console.WriteLine("Valor Bruto: " + USD + VALOR_TONELADA);
        Console.WriteLine("Retenciones (" + (RETENCION * 100) + "%): " + USD + DESCUENTO_ADUANA);
        Console.WriteLine("Valor Neto a recibir: " + USD + LIQUIDACION);

        Console.ReadLine();

        // ----------------------------------------- //

        const decimal INTERES_TARJETA = 0.10m;
        const bool COBRO_DIGITAL = true;
        const char PESOS = '$';

        Console.WriteLine("--- Indumentaria C8 --- ");
        Console.WriteLine("Posnet activo: " + COBRO_DIGITAL);

        decimal PRECIO_PRENDA = 4500.00m;
        decimal RECARGO = PRECIO_PRENDA * INTERES_TARJETA;
        decimal TOTAL_TARJETA = PRECIO_PRENDA + RECARGO;

        Console.WriteLine("\n Detalle de venta: ");
        Console.WriteLine("Precio Contado: " + PESOS + PRECIO_PRENDA);
        Console.WriteLine("Recargo Financiero (" + (INTERES_TARJETA * 100) + "%): " + PESOS + RECARGO);
        Console.WriteLine("Total en cuotas: " + PESOS + TOTAL_TARJETA);

        Console.ReadLine();

    }
}
