using System;
using menuUsuario.MenuUsuario;
using cultivos.Cultivos;
namespace Finca_Robots.ventas
{

    public class Ventas : Cultivos
    {
        float gananciasTotales = 0;
        float gananciasXVenta = 0;
        float gananciasFrijol = 0;
        float gananciasPapa = 0;
        float gananciasCebolla = 0;
        float gananciasMaiz = 0;
        float gananciasTrigo = 0;
        float gananciasYuca = 0;
        string opcion;
        int cantParaVender;
        bool regresar = false;

        public void menuVentas()
        {
            while (regresar == false)
            {
                Console.WriteLine("Haz seleccionado Ventas \n1.Ver ganancias totales\n2.Vender\n0.Volver al menu principal\n");
                opcion = Console.ReadLine();
                if (opcion == "1")
                {
                    ganancias();
                }
                if (opcion == "2")
                {
                    vender();
                }
                if (opcion == "0")
                {
                    MenuUsuario menuPrincipal = new MenuUsuario();
                    menuPrincipal.Menu();

                }
            }
        }
        public void ganancias()
        {
            Console.WriteLine("Ganancias totales: " + gananciasTotales);
            Console.WriteLine("Ganancias venta de frijol: " + gananciasFrijol);
            Console.WriteLine("Ganancias venta de papa: " + gananciasPapa);
            Console.WriteLine("Ganancias venta de cebolla: " + gananciasCebolla);
            Console.WriteLine("Ganancias venta de maiz: " + gananciasMaiz);
            Console.WriteLine("Ganancias venta de trigo: " + gananciasTrigo);
            Console.WriteLine("Ganancias venta de yuca: " + gananciasYuca);
        }
        public void vender()
        {
            Console.WriteLine("Que deseas vender?\n1.Frijol\n2.Papa\n3.Cebolla\n4.Maiz\n5.Trigo\n6.Yuca\n");
            opcion = Console.ReadLine();
            if (opcion == "1")
            {
                Console.WriteLine("Cuantas libras vas a vender?\n");
                cantParaVender = int.Parse(Console.ReadLine());
                gananciasXVenta = cantParaVender * precioFrijol;
                gananciasTotales += gananciasXVenta;
                gananciasFrijol += gananciasXVenta;

                Console.WriteLine("Has obtenido: " + gananciasXVenta + " en esta venta\n");
            }
            if (opcion == "2")
            {
                Console.WriteLine("Cuantas libras vas a vender?\n");
                cantParaVender = int.Parse(Console.ReadLine());
                gananciasXVenta = cantParaVender * precioPapa;
                gananciasTotales += gananciasXVenta;
                gananciasPapa += gananciasXVenta;

                Console.WriteLine("Has obtenido: " + gananciasXVenta + " en esta venta\n");
            }
            if (opcion == "3")
            {
                Console.WriteLine("Cuantas libras vas a vender?\n");
                cantParaVender = int.Parse(Console.ReadLine());
                gananciasXVenta = cantParaVender * precioCebolla;
                gananciasTotales += gananciasXVenta;
                gananciasCebolla += gananciasXVenta;

                Console.WriteLine("Has obtenido: " + gananciasXVenta + " en esta venta\n");
            }
            if (opcion == "4")
            {
                Console.WriteLine("Cuantas libras vas a vender?\n");
                cantParaVender = int.Parse(Console.ReadLine());
                gananciasXVenta = cantParaVender * precioMaiz;
                gananciasTotales += gananciasXVenta;
                gananciasMaiz += gananciasXVenta;

                Console.WriteLine("Has obtenido: " + gananciasXVenta + " en esta venta\n");
            }
            if (opcion == "5")
            {
                Console.WriteLine("Cuantas libras vas a vender?\n");
                cantParaVender = int.Parse(Console.ReadLine());
                gananciasXVenta = cantParaVender * precioTrigo;
                gananciasTotales += gananciasXVenta;
                gananciasTrigo += gananciasXVenta;

                Console.WriteLine("Has obtenido: " + gananciasXVenta + " en esta venta\n");
            }
            if (opcion == "6")
            {
                Console.WriteLine("Cuantas libras vas a vender?\n");
                cantParaVender = int.Parse(Console.ReadLine());
                gananciasXVenta = cantParaVender * precioYuca;
                gananciasTotales += gananciasXVenta;
                gananciasYuca += gananciasXVenta;

                Console.WriteLine("Has obtenido: " + gananciasXVenta + " en esta venta\n");
            }
        }
    }
}