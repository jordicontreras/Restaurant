using System;
using System.Collections.Generic;

namespace Restaurant
{
    class Program
    {
        static void Main(string[] args)
        {

            //********* FASE 1 *********
            //int[] billetes = new int[] {5, 10, 20, 50, 100, 200, 500};
            //Creamos las variables para los diferentes billetes
            int billete1 = 5;
            int billete2 = 10;
            int billete3 = 20;
            int billete4 = 50;
            int billete5 = 100;
            int billete6 = 200;
            int billete7 = 500;
            
            //Creamos la variable para el precio total de la comida
            double precioTotal = 0.00;

            //Creamos los arrays de los platos y sus precios del menú
            string[] menuPlatos = new string[5];
            double[] preciosPlatos = new double[5];


            //********* FASE 2 *********
            Console.WriteLine("********* FASE 2 *********");
            Console.WriteLine("");
            Console.WriteLine("Hola camarero, introduce los platos a continuación");
            
            //Bucle donde pedimos al camarero que nos introduzca los platos y sus precios y los guardamos en un array
            for(int i = 0; i < menuPlatos.Length; i++)
            {
                Console.WriteLine("Introduce el plato " +(i+1));
                menuPlatos[i] = Console.ReadLine();

                Console.WriteLine("Introduce su precio");
                preciosPlatos[i] = double.Parse(Console.ReadLine(), System.Globalization.NumberStyles.AllowDecimalPoint, System.Globalization.NumberFormatInfo.InvariantInfo);
            }

            Console.WriteLine("");
            Console.WriteLine("Bienvenidos, los platos que disponemos y sus precios son los siguientes:");
            Console.WriteLine("");

            //Bucle donde mostramos los platos almacenados en el array junto a sus precios
            for (int i = 0; i < menuPlatos.Length; i++)
            {
                Console.WriteLine(menuPlatos[i]);

                Console.WriteLine("su precio es: " + preciosPlatos[i]);
            }

            //Creamos la lista para los platos que van a pedir
            var platosPedidos = new List<string>();

            Console.WriteLine("Queréis comer?");
            var respuesta = Console.ReadLine();

            while(respuesta.ToLower() == "sí" || respuesta.ToLower() == "si")
            {
                Console.WriteLine("Qué plato queréis pedir?");
                platosPedidos.Add(Console.ReadLine());

                Console.WriteLine("Queréis pedir más cosas?");
                respuesta = Console.ReadLine();
            }



            //********* FASE 3 *********
            Console.WriteLine("********* FASE 3 *********");
            Console.WriteLine("");
            Console.WriteLine("Habéis pedido los siguientes platos:");
            foreach (string plato in platosPedidos)
            {
                Console.WriteLine(plato);
            }

            foreach(string plato in platosPedidos) 
            {
                var coincidencia = false;
                for(int i = 0; i < menuPlatos.Length; i++)
                {
                    if(plato == menuPlatos[i])
                    {
                        Console.WriteLine("coincide, tu plato es " + plato);
                        coincidencia = true;
                        precioTotal += preciosPlatos[i];
                    }
                }
                if (!coincidencia)
                {
                    Console.WriteLine($"No tenemmos {plato} en el menú");
                }
            }

            Console.WriteLine($"El precio total son: {precioTotal}");
        }
    }
}
