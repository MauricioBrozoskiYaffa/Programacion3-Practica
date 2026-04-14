using System;

namespace GuiaArreglos
{
    class Ejercicio03
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- EJERCICIO 3: USO DE .LENGTH Y BUCLE FOR ---");

            int[] edades = { 15, 25, 33, 42, 51 };

            int cantidadElementos = edades.Length;
            Console.WriteLine("El arreglo tiene " + cantidadElementos + " elementos");
            Console.WriteLine("------------------------");

            for (int i = 0; i < edades.Length; i++)
            {
                Console.WriteLine("Indice " + i + ": La edad es " + edades[i]);
            }

            Console.WriteLine("\nPresione ENTER para continuar....");
            Console.ReadLine();

            //---------------------------------------------------//

            int[] puntajes = {15, 49, 67, 81, 150};

            int cantidadPuntos = puntajes.Length;
            Console.WriteLine("El participante tiene: " + cantidadPuntos + " puntaje");
            Console.WriteLine("-----------------------");

            for (int i = 0; i < puntajes.Length; i++)
            {
                Console.WriteLine("Participante: " + i + ": Tiene un total de puntaje: " + puntajes[i]);
            }

            Console.WriteLine("\nPresione ENTER para continuar....");
            Console.ReadLine();

            //--------------------------------------------------------//

            string[] jugadores = {"Merentiel", "Bareiro", "Paredes", "Di Lolo", "El chango Zeballos", "Tomas Aranda"};

            int cantidadDeJugadores = jugadores.Length;
            Console.WriteLine("Jugadores de Boquita: " + cantidadDeJugadores + " jugadores");
            Console.WriteLine("---------------------");

            for (int i = 1; i < jugadores.Length; i++)
            {
                Console.WriteLine("Jugadores: " + i + " Titulares: " + jugadores[i]);
            }

            Console.WriteLine("\nPresione ENTER para continuar....");
            Console.ReadLine();

            //-----------------------------------------------------//

            string[] estados = {"Recibido", "Pendiente", "En Proceso", "Eviando", "Entragado", "Cancelado"};

            int pedidoEstado = estados.Length;
            Console.WriteLine("Estados de los pedidos: " + pedidoEstado + " Su pedido esta");
            Console.WriteLine("------------------------");

            for (int i = 0; i < estados.Length; i++)
            {
                Console.WriteLine("Pedido: " + i + " Tu pedido se encuentra: " + estados[i]);
            }

            Console.WriteLine("\nPresione ENTER para continuar....");
            Console.ReadLine();

            //----------------------------------------------------//

            int[] codigos = {4000, 3500, 0297, 2350, 9000};

            int provinciasCodigos = codigos.Length;
            Console.WriteLine("Numero de Provincia " + provinciasCodigos + " Su codigo posta es:");
            Console.WriteLine("------------------");

            for ( int i = 0; i < codigos.Length; i++)
            {
            Console.WriteLine("Nro: " + i + " Codigo de Provincia: " + codigos[i]);    
            }

            Console.WriteLine("\nPresione ENTER para continuar....");
            Console.ReadLine();
        } 
    } 
}
