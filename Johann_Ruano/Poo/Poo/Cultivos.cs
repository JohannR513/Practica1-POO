using System;
using menuUsuario.MenuUsuario;
namespace cultivos.Cultivos
{
    public class Cultivos
    {
        #region Semillas
        int semillasFrijol = 0;
        int semillasPapa = 0;
        int semillasCebolla = 0;
        int semillasMaiz = 0;
        int semillasTrigo = 0;
        int semillasYuca = 0;
        int semillasCultivar;
        int semillasRequeridas;
        int agregarSemillas;
        #endregion Semillas

        #region inventarioxlibras
        public int cantFrijol = 0;
        public int cantPapa = 0;
        public int cantCebolla = 0;
        public int cantMaiz = 0;
        public int cantTrigo = 0;
        public int cantYuca = 0;
        public int cantCosechada;
        #endregion inventarioxlibras

        #region precioxLibra
        public float precioFrijol = 3890;
        public float precioPapa = 2860;
        public float precioCebolla = 2525;
        public float precioMaiz = 3250;
        public float precioTrigo = 900;
        public float precioYuca = 4200;
        #endregion precioxLibra

        #region LotesParaCultivar
        string lote1 = "Sin siembras";
        string lote2 = "Sin siembras";
        string lote3 = "Sin siembras";
        string lote4 = "Sin siembras";
        string lote5 = "Sin siembras";
        string lote6 = "Sin siembras";
        #endregion LotesParaCultivar

        #region estadoLotes
        string estadoLote1 = "Disponible";
        string estadoLote2 = "Disponible";
        string estadoLote3 = "Disponible";
        string estadoLote4 = "Disponible";
        string estadoLote5 = "Disponible";
        string estadoLote6 = "Disponible";
        #endregion estadoLotes

        #region banderasMenu
        bool regresar = false;
        bool regresar2 = false;
        string opcion { get; set; }

        #endregion banderasMenu

        public void menuCultivos()
        {
            while (regresar == false)
            {
                Console.WriteLine("Haz seleccionado cultivos \n1.Opciones semillas \n2.Opciones cultivos   \n0.Volver al menu principal\n");
                opcion = Console.ReadLine();
                if (opcion == "1")
                {
                    semillas();
                }
                if (opcion == "2")
                {
                    opcionCultivos();
                }
                if (opcion == "0")
                {
                    MenuUsuario menuPrincipal = new MenuUsuario();
                    menuPrincipal.Menu();

                }
            }
        }
        public void semillas()
        {
            Console.Write("Selecciona una opción:\n");
            Console.WriteLine("\n1.Cantidad de semillas\n2.Agregar semillas\n");
            switch (Console.Read())
            {
                case '1':
                    Console.WriteLine("\nLa cantidad de semillas en el inventario es: ");
                    Console.WriteLine("Frijol: " + semillasFrijol);
                    Console.WriteLine("Papa: " + semillasPapa);
                    Console.WriteLine("Cebolla: " + semillasCebolla);
                    Console.WriteLine("Maiz: " + semillasMaiz);
                    Console.WriteLine("Trigo: " + semillasTrigo);
                    Console.WriteLine("Yuca: " + semillasYuca);
                    break;
                case '2':
                    Console.WriteLine("¿Que tipo de semillas deseas agregar? \n1.Frijol \n2.Papa\n3.Cebolla\n4.Maiz\n5.trigo\n6.Yuca\n");
                    opcion = Console.ReadLine();
                    if (opcion == "1")
                    {
                        Console.WriteLine("¿Cuantas semillas de Frijol vas agregar?\n");
                        agregarSemillas = int.Parse(Console.ReadLine());
                        semillasFrijol += agregarSemillas;
                        Console.WriteLine("Las nuevas semillas han sido agregadas exitosamente");
                    }
                    if (opcion == "2")
                    {
                        Console.WriteLine("¿Cuantas semillas de Papa vas agregar?\n");
                        agregarSemillas = int.Parse(Console.ReadLine());
                        semillasPapa += agregarSemillas;
                        Console.WriteLine("Las nuevas semillas han sido agregadas exitosamente");
                    }
                    if (opcion == "3")
                    {
                        Console.WriteLine("¿Cuantas semillas de Cebolla vas agregar?\n");
                        agregarSemillas = int.Parse(Console.ReadLine());
                        semillasCebolla += agregarSemillas;
                        Console.WriteLine("Las nuevas semillas han sido agregadas exitosamente");
                    }
                    if (opcion == "4")
                    {
                        Console.WriteLine("¿Cuantas semillas de Maiz vas agregar?\n");
                        agregarSemillas = int.Parse(Console.ReadLine());
                        semillasMaiz += agregarSemillas;
                        Console.WriteLine("Las nuevas semillas han sido agregadas exitosamente");
                    }
                    if (opcion == "5")
                    {
                        Console.WriteLine("¿Cuantas semillas de Trigo vas agregar?\n");
                        agregarSemillas = int.Parse(Console.ReadLine());
                        semillasTrigo += agregarSemillas;
                        Console.WriteLine("Las nuevas semillas han sido agregadas exitosamente");
                    }
                    if (opcion == "6")
                    {
                        Console.WriteLine("¿Cuantas semillas de Yuca vas agregar?\n");
                        agregarSemillas = int.Parse(Console.ReadLine());
                        semillasYuca += agregarSemillas;
                        Console.WriteLine("Las nuevas semillas han sido agregadas exitosamente");
                    }
                    break;
            }

        }
        public void opcionCultivos()
        {
            Console.Write("Selecciona una opción:\n");
            Console.WriteLine("\n1.Estado de los lotes\n2.Sembrar\n3.Cosechar\n4.Mostrar inventario en bodega\n");
            switch (Console.Read())
            {
                case '1':
                    Console.WriteLine("\nEstos son los estados de los lotes en la finca:\n");
                    Console.WriteLine("Estado Lote1: " + estadoLote1 + ", " + lote1);
                    Console.WriteLine("Estado Lote2: " + estadoLote2 + ", " + lote2);
                    Console.WriteLine("Estado Lote3: " + estadoLote3 + ", " + lote3);
                    Console.WriteLine("Estado Lote4: " + estadoLote4 + ", " + lote4);
                    Console.WriteLine("Estado Lote5: " + estadoLote5 + ", " + lote5);
                    Console.WriteLine("Estado Lote6: " + estadoLote6 + ", " + lote6);
                    break;

                case '2':
                    Console.WriteLine("\nEn que lote deseas cultivar?:\n1.Lote1\n2.Lote2\n3.Lote3\n4.Lote4\n5.Lote5\n6.Lote6\n");
                    opcion = Console.ReadLine();
                    if (opcion == "1" && estadoLote1 == "Ocupado")
                    {
                        Console.WriteLine("Este lote esta ocupado por otra siembra");
                    }
                    else if (opcion == "1" && estadoLote1 == "Disponible")
                    {
                        Console.WriteLine("\nQue deseas cultivar?:\n1.Frijol \n2.Papa\n3.Cebolla\n4.Maiz\n5.trigo\n6.Yuca\n");
                        opcion = Console.ReadLine();
                        if (opcion == "1")
                        {
                            Console.WriteLine("Cuantas semillas vas a cultivar?\n");
                            semillasCultivar = int.Parse(Console.ReadLine());
                            semillasRequeridas = semillasFrijol - semillasCultivar;

                            if ((semillasFrijol < 0) || (0 > semillasRequeridas))
                            {
                                Console.WriteLine("Necesitas agregar mas semillas para poder sembrar el numero que deseas");
                            }
                            else if (semillasFrijol >= 0 || semillasRequeridas >= 0)
                            {
                                lote1 = "Cultivo de Frijol";
                                estadoLote1 = "Ocupado";
                                semillasFrijol -= semillasCultivar;
                                Console.WriteLine("Se ha sembrado frijol en el lote 1\n");
                            }
                        }
                        if (opcion == "2")
                        {
                            Console.WriteLine("Cuantas semillas vas a cultivar?\n");
                            semillasCultivar = int.Parse(Console.ReadLine());
                            semillasRequeridas = semillasPapa - semillasCultivar;

                            if ((semillasPapa < 0) || (0 > semillasRequeridas))
                            {
                                Console.WriteLine("Necesitas agregar mas semillas para poder sembrar el numero que deseas");
                            }
                            else if (semillasPapa >= 0 || semillasRequeridas >= 0)
                            {
                                lote1 = "Cultivo de Papa";
                                estadoLote1 = "Ocupado";
                                semillasPapa -= semillasCultivar;
                                Console.WriteLine("Se ha sembrado papa en el lote 1\n");
                            }
                        }
                        if (opcion == "3")
                        {
                            Console.WriteLine("Cuantas semillas vas a cultivar?\n");
                            semillasCultivar = int.Parse(Console.ReadLine());
                            semillasRequeridas = semillasCebolla - semillasCultivar;

                            if ((semillasCebolla < 0) || (0 > semillasRequeridas))
                            {
                                Console.WriteLine("Necesitas agregar mas semillas para poder sembrar el numero que deseas");
                            }
                            else if (semillasCebolla >= 0 || semillasRequeridas >= 0)
                            {
                                lote1 = "Cultivo de cebolla";
                                estadoLote1 = "Ocupado";
                                semillasCebolla -= semillasCultivar;
                                Console.WriteLine("Se ha sembrado cebolla en el lote 1\n");
                            }
                        }
                        if (opcion == "4")
                        {
                            Console.WriteLine("Cuantas semillas vas a cultivar?\n");
                            semillasCultivar = int.Parse(Console.ReadLine());
                            semillasRequeridas = semillasMaiz - semillasCultivar;

                            if ((semillasMaiz < 0) || (0 > semillasRequeridas))
                            {
                                Console.WriteLine("Necesitas agregar mas semillas para poder sembrar el numero que deseas");
                            }
                            else if (semillasMaiz >= 0 || semillasRequeridas >= 0)
                            {
                                lote1 = "Cultivo de maiz";
                                estadoLote1 = "Ocupado";
                                semillasMaiz -= semillasCultivar;
                                Console.WriteLine("Se ha sembrado maiz en el lote 1\n");
                            }
                        }
                        if (opcion == "5")
                        {
                            Console.WriteLine("Cuantas semillas vas a cultivar?\n");
                            semillasCultivar = int.Parse(Console.ReadLine());
                            semillasRequeridas = semillasTrigo - semillasCultivar;

                            if ((semillasTrigo < 0) || (0 > semillasRequeridas))
                            {
                                Console.WriteLine("Necesitas agregar mas semillas para poder sembrar el numero que deseas");
                            }
                            else if (semillasTrigo >= 0 || semillasRequeridas >= 0)
                            {
                                lote1 = "Cultivo de trigo";
                                estadoLote1 = "Ocupado";
                                semillasTrigo -= semillasCultivar;
                                Console.WriteLine("Se ha sembrado trigo en el lote 1\n");
                            }
                        }
                        if (opcion == "6")
                        {
                            Console.WriteLine("Cuantas semillas vas a cultivar?\n");
                            semillasCultivar = int.Parse(Console.ReadLine());
                            semillasRequeridas = semillasYuca - semillasCultivar;

                            if ((semillasYuca < 0) || (0 > semillasRequeridas))
                            {
                                Console.WriteLine("Necesitas agregar mas semillas para poder sembrar el numero que deseas");
                            }
                            else if (semillasYuca >= 0 || semillasRequeridas >= 0)
                            {
                                lote1 = "Cultivo de yuca";
                                estadoLote1 = "Ocupado";
                                semillasYuca -= semillasCultivar;
                                Console.WriteLine("Se ha sembrado yuca en el lote 1\n");
                            }
                        }
                    }
                    if (opcion == "2" && estadoLote2 == "Ocupado")
                    {
                        Console.WriteLine("Este lote esta ocupado por otra siembra");
                    }
                    else if (opcion == "2" && estadoLote2 == "Disponible")
                    {
                        Console.WriteLine("\nQue deseas cultivar?:\n1.Frijol \n2.Papa\n3.Cebolla\n4.Maiz\n5.trigo\n6.Yuca\n");
                        opcion = Console.ReadLine();
                        if (opcion == "1")
                        {
                            Console.WriteLine("Cuantas semillas vas a cultivar?\n");
                            semillasCultivar = int.Parse(Console.ReadLine());
                            semillasRequeridas = semillasFrijol - semillasCultivar;

                            if ((semillasFrijol < 0) || (0 > semillasRequeridas))
                            {
                                Console.WriteLine("Necesitas agregar mas semillas para poder sembrar el numero que deseas");
                            }
                            else if (semillasFrijol >= 0 || semillasRequeridas >= 0)
                            {
                                lote2 = "Cultivo de Frijol";
                                estadoLote2 = "Ocupado";
                                semillasFrijol -= semillasCultivar;
                                Console.WriteLine("Se ha sembrado frijol en el lote 2\n");
                            }
                        }
                        if (opcion == "2")
                        {
                            Console.WriteLine("Cuantas semillas vas a cultivar?\n");
                            semillasCultivar = int.Parse(Console.ReadLine());
                            semillasRequeridas = semillasPapa - semillasCultivar;

                            if ((semillasPapa < 0) || (0 > semillasRequeridas))
                            {
                                Console.WriteLine("Necesitas agregar mas semillas para poder sembrar el numero que deseas");
                            }
                            else if (semillasPapa >= 0 || semillasRequeridas >= 0)
                            {
                                lote2 = "Cultivo de Papa";
                                estadoLote2 = "Ocupado";
                                semillasPapa -= semillasCultivar;
                                Console.WriteLine("Se ha sembrado papa en el lote 2\n");
                            }
                        }
                        if (opcion == "3")
                        {
                            Console.WriteLine("Cuantas semillas vas a cultivar?\n");
                            semillasCultivar = int.Parse(Console.ReadLine());
                            semillasRequeridas = semillasCebolla - semillasCultivar;

                            if ((semillasCebolla < 0) || (0 > semillasRequeridas))
                            {
                                Console.WriteLine("Necesitas agregar mas semillas para poder sembrar el numero que deseas");
                            }
                            else if (semillasCebolla >= 0 || semillasRequeridas >= 0)
                            {
                                lote2 = "Cultivo de cebolla";
                                estadoLote2 = "Ocupado";
                                semillasCebolla -= semillasCultivar;
                                Console.WriteLine("Se ha sembrado cebolla en el lote 2\n");
                            }
                        }
                        if (opcion == "4")
                        {
                            Console.WriteLine("Cuantas semillas vas a cultivar?\n");
                            semillasCultivar = int.Parse(Console.ReadLine());
                            semillasRequeridas = semillasMaiz - semillasCultivar;

                            if ((semillasMaiz < 0) || (0 > semillasRequeridas))
                            {
                                Console.WriteLine("Necesitas agregar mas semillas para poder sembrar el numero que deseas");
                            }
                            else if (semillasMaiz >= 0 || semillasRequeridas >= 0)
                            {
                                lote2 = "Cultivo de maiz";
                                estadoLote2 = "Ocupado";
                                semillasMaiz -= semillasCultivar;
                                Console.WriteLine("Se ha sembrado maiz en el lote 2\n");
                            }
                        }
                        if (opcion == "5")
                        {
                            Console.WriteLine("Cuantas semillas vas a cultivar?\n");
                            semillasCultivar = int.Parse(Console.ReadLine());
                            semillasRequeridas = semillasTrigo - semillasCultivar;

                            if ((semillasTrigo < 0) || (0 > semillasRequeridas))
                            {
                                Console.WriteLine("Necesitas agregar mas semillas para poder sembrar el numero que deseas");
                            }
                            else if (semillasTrigo >= 0 || semillasRequeridas >= 0)
                            {
                                lote2 = "Cultivo de trigo";
                                estadoLote2 = "Ocupado";
                                semillasTrigo -= semillasCultivar;
                                Console.WriteLine("Se ha sembrado trigo en el lote 2\n");
                            }
                        }
                        if (opcion == "6")
                        {
                            Console.WriteLine("Cuantas semillas vas a cultivar?\n");
                            semillasCultivar = int.Parse(Console.ReadLine());
                            semillasRequeridas = semillasYuca - semillasCultivar;

                            if ((semillasYuca < 0) || (0 > semillasRequeridas))
                            {
                                Console.WriteLine("Necesitas agregar mas semillas para poder sembrar el numero que deseas");
                            }
                            else if (semillasYuca >= 0 || semillasRequeridas >= 0)
                            {
                                lote2 = "Cultivo de yuca";
                                estadoLote2 = "Ocupado";
                                semillasYuca -= semillasCultivar;
                                Console.WriteLine("Se ha sembrado yuca en el lote 2\n");
                            }
                        }
                    }
                    if (opcion == "3" && estadoLote3 == "Ocupado")
                    {
                        Console.WriteLine("Este lote esta ocupado por otra siembra");
                    }
                    else if (opcion == "3" && estadoLote3 == "Disponible")
                    {
                        Console.WriteLine("\nQue deseas cultivar?:\n1.Frijol \n2.Papa\n3.Cebolla\n4.Maiz\n5.trigo\n6.Yuca\n");
                        opcion = Console.ReadLine();
                        if (opcion == "1")
                        {
                            Console.WriteLine("Cuantas semillas vas a cultivar?\n");
                            semillasCultivar = int.Parse(Console.ReadLine());
                            semillasRequeridas = semillasFrijol - semillasCultivar;

                            if ((semillasFrijol < 0) || (0 > semillasRequeridas))
                            {
                                Console.WriteLine("Necesitas agregar mas semillas para poder sembrar el numero que deseas");
                            }
                            else if (semillasFrijol >= 0 || semillasRequeridas >= 0)
                            {
                                lote3 = "Cultivo de Frijol";
                                estadoLote3 = "Ocupado";
                                semillasFrijol -= semillasCultivar;
                                Console.WriteLine("Se ha sembrado frijol en el lote 3\n");
                            }
                        }
                        if (opcion == "2")
                        {
                            Console.WriteLine("Cuantas semillas vas a cultivar?\n");
                            semillasCultivar = int.Parse(Console.ReadLine());
                            semillasRequeridas = semillasPapa - semillasCultivar;

                            if ((semillasPapa < 0) || (0 > semillasRequeridas))
                            {
                                Console.WriteLine("Necesitas agregar mas semillas para poder sembrar el numero que deseas");
                            }
                            else if (semillasPapa >= 0 || semillasRequeridas >= 0)
                            {
                                lote3 = "Cultivo de Papa";
                                estadoLote3 = "Ocupado";
                                semillasPapa -= semillasCultivar;
                                Console.WriteLine("Se ha sembrado papa en el lote 3\n");
                            }
                        }
                        if (opcion == "3")
                        {
                            Console.WriteLine("Cuantas semillas vas a cultivar?\n");
                            semillasCultivar = int.Parse(Console.ReadLine());
                            semillasRequeridas = semillasCebolla - semillasCultivar;

                            if ((semillasCebolla < 0) || (0 > semillasRequeridas))
                            {
                                Console.WriteLine("Necesitas agregar mas semillas para poder sembrar el numero que deseas");
                            }
                            else if (semillasCebolla >= 0 || semillasRequeridas >= 0)
                            {
                                lote3 = "Cultivo de cebolla";
                                estadoLote3 = "Ocupado";
                                semillasCebolla -= semillasCultivar;
                                Console.WriteLine("Se ha sembrado cebolla en el lote 3\n");
                            }
                        }
                        if (opcion == "4")
                        {
                            Console.WriteLine("Cuantas semillas vas a cultivar?\n");
                            semillasCultivar = int.Parse(Console.ReadLine());
                            semillasRequeridas = semillasMaiz - semillasCultivar;

                            if ((semillasMaiz < 0) || (0 > semillasRequeridas))
                            {
                                Console.WriteLine("Necesitas agregar mas semillas para poder sembrar el numero que deseas");
                            }
                            else if (semillasMaiz >= 0 || semillasRequeridas >= 0)
                            {
                                lote3 = "Cultivo de maiz";
                                estadoLote3 = "Ocupado";
                                semillasMaiz -= semillasCultivar;
                                Console.WriteLine("Se ha sembrado maiz en el lote 3\n");
                            }
                        }
                        if (opcion == "5")
                        {
                            Console.WriteLine("Cuantas semillas vas a cultivar?\n");
                            semillasCultivar = int.Parse(Console.ReadLine());
                            semillasRequeridas = semillasTrigo - semillasCultivar;

                            if ((semillasTrigo < 0) || (0 > semillasRequeridas))
                            {
                                Console.WriteLine("Necesitas agregar mas semillas para poder sembrar el numero que deseas");
                            }
                            else if (semillasTrigo >= 0 || semillasRequeridas >= 0)
                            {
                                lote3 = "Cultivo de trigo";
                                estadoLote3 = "Ocupado";
                                semillasTrigo -= semillasCultivar;
                                Console.WriteLine("Se ha sembrado trigo en el lote 3\n");
                            }
                        }
                        if (opcion == "6")
                        {
                            Console.WriteLine("Cuantas semillas vas a cultivar?\n");
                            semillasCultivar = int.Parse(Console.ReadLine());
                            semillasRequeridas = semillasYuca - semillasCultivar;

                            if ((semillasYuca < 0) || (0 > semillasRequeridas))
                            {
                                Console.WriteLine("Necesitas agregar mas semillas para poder sembrar el numero que deseas");
                            }
                            else if (semillasYuca >= 0 || semillasRequeridas >= 0)
                            {
                                lote3 = "Cultivo de yuca";
                                estadoLote3 = "Ocupado";
                                semillasYuca -= semillasCultivar;
                                Console.WriteLine("Se ha sembrado yuca en el lote 3\n");
                            }
                        }
                    }
                    if (opcion == "4" && estadoLote4 == "Ocupado")
                    {
                        Console.WriteLine("Este lote esta ocupado por otra siembra");
                    }
                    else if (opcion == "4" && estadoLote4 == "Disponible")
                    {
                        Console.WriteLine("\nQue deseas cultivar?:\n1.Frijol \n2.Papa\n3.Cebolla\n4.Maiz\n5.trigo\n6.Yuca\n");
                        opcion = Console.ReadLine();
                        if (opcion == "1")
                        {
                            Console.WriteLine("Cuantas semillas vas a cultivar?\n");
                            semillasCultivar = int.Parse(Console.ReadLine());
                            semillasRequeridas = semillasFrijol - semillasCultivar;

                            if ((semillasFrijol < 0) || (0 > semillasRequeridas))
                            {
                                Console.WriteLine("Necesitas agregar mas semillas para poder sembrar el numero que deseas");
                            }
                            else if (semillasFrijol >= 0 || semillasRequeridas >= 0)
                            {
                                lote4 = "Cultivo de Frijol";
                                estadoLote4 = "Ocupado";
                                semillasFrijol -= semillasCultivar;
                                Console.WriteLine("Se ha sembrado frijol en el lote 4\n");
                            }
                        }
                        if (opcion == "2")
                        {
                            Console.WriteLine("Cuantas semillas vas a cultivar?\n");
                            semillasCultivar = int.Parse(Console.ReadLine());
                            semillasRequeridas = semillasPapa - semillasCultivar;

                            if ((semillasPapa < 0) || (0 > semillasRequeridas))
                            {
                                Console.WriteLine("Necesitas agregar mas semillas para poder sembrar el numero que deseas");
                            }
                            else if (semillasPapa >= 0 || semillasRequeridas >= 0)
                            {
                                lote4 = "Cultivo de Papa";
                                estadoLote4 = "Ocupado";
                                semillasPapa -= semillasCultivar;
                                Console.WriteLine("Se ha sembrado papa en el lote 4\n");
                            }
                        }
                        if (opcion == "3")
                        {
                            Console.WriteLine("Cuantas semillas vas a cultivar?\n");
                            semillasCultivar = int.Parse(Console.ReadLine());
                            semillasRequeridas = semillasCebolla - semillasCultivar;

                            if ((semillasCebolla < 0) || (0 > semillasRequeridas))
                            {
                                Console.WriteLine("Necesitas agregar mas semillas para poder sembrar el numero que deseas");
                            }
                            else if (semillasCebolla >= 0 || semillasRequeridas >= 0)
                            {
                                lote4 = "Cultivo de cebolla";
                                estadoLote4 = "Ocupado";
                                semillasCebolla -= semillasCultivar;
                                Console.WriteLine("Se ha sembrado cebolla en el lote 4\n");
                            }
                        }
                        if (opcion == "4")
                        {
                            Console.WriteLine("Cuantas semillas vas a cultivar?\n");
                            semillasCultivar = int.Parse(Console.ReadLine());
                            semillasRequeridas = semillasMaiz - semillasCultivar;

                            if ((semillasMaiz < 0) || (0 > semillasRequeridas))
                            {
                                Console.WriteLine("Necesitas agregar mas semillas para poder sembrar el numero que deseas");
                            }
                            else if (semillasMaiz >= 0 || semillasRequeridas >= 0)
                            {
                                lote4 = "Cultivo de maiz";
                                estadoLote4 = "Ocupado";
                                semillasMaiz -= semillasCultivar;
                                Console.WriteLine("Se ha sembrado maiz en el lote 4\n");
                            }
                        }
                        if (opcion == "5")
                        {
                            Console.WriteLine("Cuantas semillas vas a cultivar?\n");
                            semillasCultivar = int.Parse(Console.ReadLine());
                            semillasRequeridas = semillasTrigo - semillasCultivar;

                            if ((semillasTrigo < 0) || (0 > semillasRequeridas))
                            {
                                Console.WriteLine("Necesitas agregar mas semillas para poder sembrar el numero que deseas");
                            }
                            else if (semillasTrigo >= 0 || semillasRequeridas >= 0)
                            {
                                lote4 = "Cultivo de trigo";
                                estadoLote4 = "Ocupado";
                                semillasTrigo -= semillasCultivar;
                                Console.WriteLine("Se ha sembrado trigo en el lote 4 \n");
                            }
                        }
                        if (opcion == "6")
                        {
                            Console.WriteLine("Cuantas semillas vas a cultivar?\n");
                            semillasCultivar = int.Parse(Console.ReadLine());
                            semillasRequeridas = semillasYuca - semillasCultivar;

                            if ((semillasYuca < 0) || (0 > semillasRequeridas))
                            {
                                Console.WriteLine("Necesitas agregar mas semillas para poder sembrar el numero que deseas");
                            }
                            else if (semillasYuca >= 0 || semillasRequeridas >= 0)
                            {
                                lote4 = "Cultivo de yuca";
                                estadoLote4 = "Ocupado";
                                semillasYuca -= semillasCultivar;
                                Console.WriteLine("Se ha sembrado yuca en el lote 4\n");
                            }
                        }
                    }
                    if (opcion == "5" && estadoLote5 == "Ocupado")
                    {
                        Console.WriteLine("Este lote esta ocupado por otra siembra");
                    }
                    else if (opcion == "5" && estadoLote5 == "Disponible")
                    {
                        Console.WriteLine("\nQue deseas cultivar?:\n1.Frijol \n2.Papa\n3.Cebolla\n4.Maiz\n5.trigo\n6.Yuca\n");
                        opcion = Console.ReadLine();
                        if (opcion == "1")
                        {
                            Console.WriteLine("Cuantas semillas vas a cultivar?\n");
                            semillasCultivar = int.Parse(Console.ReadLine());
                            semillasRequeridas = semillasFrijol - semillasCultivar;

                            if ((semillasFrijol < 0) || (0 > semillasRequeridas))
                            {
                                Console.WriteLine("Necesitas agregar mas semillas para poder sembrar el numero que deseas");
                            }
                            else if (semillasFrijol >= 0 || semillasRequeridas >= 0)
                            {
                                lote5 = "Cultivo de Frijol";
                                estadoLote5 = "Ocupado";
                                semillasFrijol -= semillasCultivar;
                                Console.WriteLine("Se ha sembrado frijol en el lote 5\n");
                            }
                        }
                        if (opcion == "2")
                        {
                            Console.WriteLine("Cuantas semillas vas a cultivar?\n");
                            semillasCultivar = int.Parse(Console.ReadLine());
                            semillasRequeridas = semillasPapa - semillasCultivar;

                            if ((semillasPapa < 0) || (0 > semillasRequeridas))
                            {
                                Console.WriteLine("Necesitas agregar mas semillas para poder sembrar el numero que deseas");
                            }
                            else if (semillasPapa >= 0 || semillasRequeridas >= 0)
                            {
                                lote5 = "Cultivo de Papa";
                                estadoLote5 = "Ocupado";
                                semillasPapa -= semillasCultivar;
                                Console.WriteLine("Se ha sembrado papa en el lote 5\n");
                            }
                        }
                        if (opcion == "3")
                        {
                            Console.WriteLine("Cuantas semillas vas a cultivar?\n");
                            semillasCultivar = int.Parse(Console.ReadLine());
                            semillasRequeridas = semillasCebolla - semillasCultivar;

                            if ((semillasCebolla < 0) || (0 > semillasRequeridas))
                            {
                                Console.WriteLine("Necesitas agregar mas semillas para poder sembrar el numero que deseas");
                            }
                            else if (semillasCebolla >= 0 || semillasRequeridas >= 0)
                            {
                                lote5 = "Cultivo de cebolla";
                                estadoLote5 = "Ocupado";
                                semillasCebolla -= semillasCultivar;
                                Console.WriteLine("Se ha sembrado cebolla en el lote 5\n");
                            }
                        }
                        if (opcion == "4")
                        {
                            Console.WriteLine("Cuantas semillas vas a cultivar?\n");
                            semillasCultivar = int.Parse(Console.ReadLine());
                            semillasRequeridas = semillasMaiz - semillasCultivar;

                            if ((semillasMaiz < 0) || (0 > semillasRequeridas))
                            {
                                Console.WriteLine("Necesitas agregar mas semillas para poder sembrar el numero que deseas");
                            }
                            else if (semillasMaiz >= 0 || semillasRequeridas >= 0)
                            {
                                lote5 = "Cultivo de maiz";
                                estadoLote5 = "Ocupado";
                                semillasMaiz -= semillasCultivar;
                                Console.WriteLine("Se ha sembrado maiz en el lote 5\n");
                            }
                        }
                        if (opcion == "5")
                        {
                            Console.WriteLine("Cuantas semillas vas a cultivar?\n");
                            semillasCultivar = int.Parse(Console.ReadLine());
                            semillasRequeridas = semillasTrigo - semillasCultivar;

                            if ((semillasTrigo < 0) || (0 > semillasRequeridas))
                            {
                                Console.WriteLine("Necesitas agregar mas semillas para poder sembrar el numero que deseas");
                            }
                            else if (semillasTrigo >= 0 || semillasRequeridas >= 0)
                            {
                                lote5 = "Cultivo de trigo";
                                estadoLote5 = "Ocupado";
                                semillasTrigo -= semillasCultivar;
                                Console.WriteLine("Se ha sembrado trigo en el lote 5\n");
                            }
                        }
                        if (opcion == "6")
                        {
                            Console.WriteLine("Cuantas semillas vas a cultivar?\n");
                            semillasCultivar = int.Parse(Console.ReadLine());
                            semillasRequeridas = semillasYuca - semillasCultivar;

                            if ((semillasYuca < 0) || (0 > semillasRequeridas))
                            {
                                Console.WriteLine("Necesitas agregar mas semillas para poder sembrar el numero que deseas");
                            }
                            else if (semillasYuca >= 0 || semillasRequeridas >= 0)
                            {
                                lote5 = "Cultivo de yuca";
                                estadoLote5 = "Ocupado";
                                semillasYuca -= semillasCultivar;
                                Console.WriteLine("Se ha sembrado yuca en el lote 5\n");
                            }
                        }
                    }
                    if (opcion == "1" && estadoLote1 == "Ocupado")
                    {
                        Console.WriteLine("Este lote esta ocupado por otra siembra");
                    }
                    else if (opcion == "6" && estadoLote6 == "Disponible")
                    {
                        Console.WriteLine("\nQue deseas cultivar?:\n1.Frijol \n2.Papa\n3.Cebolla\n4.Maiz\n5.trigo\n6.Yuca\n");
                        opcion = Console.ReadLine();
                        if (opcion == "1")
                        {
                            Console.WriteLine("Cuantas semillas vas a cultivar?\n");
                            semillasCultivar = int.Parse(Console.ReadLine());
                            semillasRequeridas = semillasFrijol - semillasCultivar;

                            if ((semillasFrijol < 0) || (0 > semillasRequeridas))
                            {
                                Console.WriteLine("Necesitas agregar mas semillas para poder sembrar el numero que deseas");
                            }
                            else if (semillasFrijol >= 0 || semillasRequeridas >= 0)
                            {
                                lote6 = "Cultivo de Frijol";
                                estadoLote6 = "Ocupado";
                                semillasFrijol -= semillasCultivar;
                                Console.WriteLine("Se ha sembrado frijol en el lote 6\n");
                            }
                        }
                        if (opcion == "2")
                        {
                            Console.WriteLine("Cuantas semillas vas a cultivar?\n");
                            semillasCultivar = int.Parse(Console.ReadLine());
                            semillasRequeridas = semillasPapa - semillasCultivar;

                            if ((semillasPapa < 0) || (0 > semillasRequeridas))
                            {
                                Console.WriteLine("Necesitas agregar mas semillas para poder sembrar el numero que deseas");
                            }
                            else if (semillasPapa >= 0 || semillasRequeridas >= 0)
                            {
                                lote6 = "Cultivo de Papa";
                                estadoLote6 = "Ocupado";
                                semillasPapa -= semillasCultivar;
                                Console.WriteLine("Se ha sembrado papa en el lote 6\n");
                            }
                        }
                        if (opcion == "3")
                        {
                            Console.WriteLine("Cuantas semillas vas a cultivar?\n");
                            semillasCultivar = int.Parse(Console.ReadLine());
                            semillasRequeridas = semillasCebolla - semillasCultivar;

                            if ((semillasCebolla < 0) || (0 > semillasRequeridas))
                            {
                                Console.WriteLine("Necesitas agregar mas semillas para poder sembrar el numero que deseas");
                            }
                            else if (semillasCebolla >= 0 || semillasRequeridas >= 0)
                            {
                                lote6 = "Cultivo de cebolla";
                                estadoLote6 = "Ocupado";
                                semillasCebolla -= semillasCultivar;
                                Console.WriteLine("Se ha sembrado cebolla en el lote 6\n");
                            }
                        }
                        if (opcion == "4")
                        {
                            Console.WriteLine("Cuantas semillas vas a cultivar?\n");
                            semillasCultivar = int.Parse(Console.ReadLine());
                            semillasRequeridas = semillasMaiz - semillasCultivar;

                            if ((semillasMaiz < 0) || (0 > semillasRequeridas))
                            {
                                Console.WriteLine("Necesitas agregar mas semillas para poder sembrar el numero que deseas");
                            }
                            else if (semillasMaiz >= 0 || semillasRequeridas >= 0)
                            {
                                lote6 = "Cultivo de maiz";
                                estadoLote6 = "Ocupado";
                                semillasMaiz -= semillasCultivar;
                                Console.WriteLine("Se ha sembrado maiz en el lote 6\n");
                            }
                        }
                        if (opcion == "5")
                        {
                            Console.WriteLine("Cuantas semillas vas a cultivar?\n");
                            semillasCultivar = int.Parse(Console.ReadLine());
                            semillasRequeridas = semillasTrigo - semillasCultivar;

                            if ((semillasTrigo < 0) || (0 > semillasRequeridas))
                            {
                                Console.WriteLine("Necesitas agregar mas semillas para poder sembrar el numero que deseas");
                            }
                            else if (semillasTrigo >= 0 || semillasRequeridas >= 0)
                            {
                                lote6 = "Cultivo de trigo";
                                estadoLote6 = "Ocupado";
                                semillasTrigo -= semillasCultivar;
                                Console.WriteLine("Se ha sembrado trigo en el lote 6\n");
                            }
                        }
                        if (opcion == "6")
                        {
                            Console.WriteLine("Cuantas semillas vas a cultivar?\n");
                            semillasCultivar = int.Parse(Console.ReadLine());
                            semillasRequeridas = semillasYuca - semillasCultivar;

                            if ((semillasYuca < 0) || (0 > semillasRequeridas))
                            {
                                Console.WriteLine("Necesitas agregar mas semillas para poder sembrar el numero que deseas");
                            }
                            else if (semillasYuca >= 0 || semillasRequeridas >= 0)
                            {
                                lote6 = "Cultivo de yuca";
                                estadoLote6 = "Ocupado";
                                semillasYuca -= semillasCultivar;
                                Console.WriteLine("Se ha sembrado yuca en el lote 6\n");
                            }
                        }
                    }
                    break;
                case '3':
                    Console.WriteLine("\nEn que lote deseas cosechar?:\n1.Lote1\n2.Lote2\n3.Lote3\n4.Lote4\n5.Lote5\n6.Lote6\n");
                    opcion = Console.ReadLine();
                    if (opcion == "1" && estadoLote1 == "Disponible")
                    {
                        Console.WriteLine("No hay nada sembrado en este lote");
                    }
                    else if (opcion == "1" && estadoLote1 == "Ocupado")
                    {
                        if (lote1 == "Cultivo de Frijol")
                        {
                            Console.WriteLine("Cuantas libras se cosecharon?");
                            cantCosechada = int.Parse(Console.ReadLine());
                            cantFrijol += cantCosechada;
                            lote1 = "Sin siembras";
                            estadoLote1 = "Disponible";
                        }
                        if (lote1 == "Cultivo de Papa")
                        {
                            Console.WriteLine("Cuantas libras se cosecharon?");
                            cantCosechada = int.Parse(Console.ReadLine());
                            cantPapa += cantCosechada;
                            lote1 = "Sin siembras";
                            estadoLote1 = "Disponible";
                        }
                        if (lote1 == "Cultivo de cebolla")
                        {
                            Console.WriteLine("Cuantas libras se cosecharon?");
                            cantCosechada = int.Parse(Console.ReadLine());
                            cantCebolla += cantCosechada;
                            lote1 = "Sin siembras";
                            estadoLote1 = "Disponible";
                        }
                        if (lote1 == "Cultivo de maiz")
                        {
                            Console.WriteLine("Cuantas libras se cosecharon?");
                            cantCosechada = int.Parse(Console.ReadLine());
                            cantMaiz += cantCosechada;
                            lote1 = "Sin siembras";
                            estadoLote1 = "Disponible";
                        }
                        if (lote1 == "Cultivo de trigo")
                        {
                            Console.WriteLine("Cuantas libras se cosecharon?");
                            cantCosechada = int.Parse(Console.ReadLine());
                            cantTrigo += cantCosechada;
                            lote1 = "Sin siembras";
                            estadoLote1 = "Disponible";
                        }
                        if (lote1 == "Cultivo de yuca")
                        {
                            Console.WriteLine("Cuantas libras se cosecharon?");
                            cantCosechada = int.Parse(Console.ReadLine());
                            cantYuca += cantCosechada;
                            lote1 = "Sin siembras";
                            estadoLote1 = "Disponible";
                        }
                    }
                    if (opcion == "2" && estadoLote2 == "Disponible")
                    {
                        Console.WriteLine("No hay nada sembrado en este lote");
                    }
                    else if (opcion == "2" && estadoLote2 == "Ocupado")
                    {
                        if (lote2 == "Cultivo de Frijol")
                        {
                            Console.WriteLine("Cuantas libras se cosecharon?");
                            cantCosechada = int.Parse(Console.ReadLine());
                            cantFrijol += cantCosechada;
                            lote2 = "Sin siembras";
                            estadoLote2 = "Disponible";
                        }
                        if (lote2 == "Cultivo de Papa")
                        {
                            Console.WriteLine("Cuantas libras se cosecharon?");
                            cantCosechada = int.Parse(Console.ReadLine());
                            cantPapa += cantCosechada;
                            lote2 = "Sin siembras";
                            estadoLote2 = "Disponible";
                        }
                        if (lote2 == "Cultivo de cebolla")
                        {
                            Console.WriteLine("Cuantas libras se cosecharon?");
                            cantCosechada = int.Parse(Console.ReadLine());
                            cantCebolla += cantCosechada;
                            lote2 = "Sin siembras";
                            estadoLote2 = "Disponible";
                        }
                        if (lote2 == "Cultivo de maiz")
                        {
                            Console.WriteLine("Cuantas libras se cosecharon?");
                            cantCosechada = int.Parse(Console.ReadLine());
                            cantMaiz += cantCosechada;
                            lote2 = "Sin siembras";
                            estadoLote2 = "Disponible";
                        }
                        if (lote2 == "Cultivo de trigo")
                        {
                            Console.WriteLine("Cuantas libras se cosecharon?");
                            cantCosechada = int.Parse(Console.ReadLine());
                            cantTrigo += cantCosechada;
                            lote2 = "Sin siembras";
                            estadoLote2 = "Disponible";
                        }
                        if (lote2 == "Cultivo de yuca")
                        {
                            Console.WriteLine("Cuantas libras se cosecharon?");
                            cantCosechada = int.Parse(Console.ReadLine());
                            cantYuca += cantCosechada;
                            lote2 = "Sin siembras";
                            estadoLote2 = "Disponible";
                        }
                    }
                    if (opcion == "3" && estadoLote3 == "Disponible")
                    {
                        Console.WriteLine("No hay nada sembrado en este lote");
                    }
                    else if (opcion == "3" && estadoLote3 == "Ocupado")
                    {
                        if (lote3 == "Cultivo de Frijol")
                        {
                            Console.WriteLine("Cuantas libras se cosecharon?");
                            cantCosechada = int.Parse(Console.ReadLine());
                            cantFrijol += cantCosechada;
                            lote3 = "Sin siembras";
                            estadoLote3 = "Disponible";
                        }
                        if (lote3 == "Cultivo de Papa")
                        {
                            Console.WriteLine("Cuantas libras se cosecharon?");
                            cantCosechada = int.Parse(Console.ReadLine());
                            cantPapa += cantCosechada;
                            lote3 = "Sin siembras";
                            estadoLote3 = "Disponible";
                        }
                        if (lote3 == "Cultivo de cebolla")
                        {
                            Console.WriteLine("Cuantas libras se cosecharon?");
                            cantCosechada = int.Parse(Console.ReadLine());
                            cantCebolla += cantCosechada;
                            lote3 = "Sin siembras";
                            estadoLote3 = "Disponible";
                        }
                        if (lote3 == "Cultivo de maiz")
                        {
                            Console.WriteLine("Cuantas libras se cosecharon?");
                            cantCosechada = int.Parse(Console.ReadLine());
                            cantMaiz += cantCosechada;
                            lote3 = "Sin siembras";
                            estadoLote3 = "Disponible";
                        }
                        if (lote3 == "Cultivo de trigo")
                        {
                            Console.WriteLine("Cuantas libras se cosecharon?");
                            cantCosechada = int.Parse(Console.ReadLine());
                            cantTrigo += cantCosechada;
                            lote3 = "Sin siembras";
                            estadoLote3 = "Disponible";
                        }
                        if (lote3 == "Cultivo de yuca")
                        {
                            Console.WriteLine("Cuantas libras se cosecharon?");
                            cantCosechada = int.Parse(Console.ReadLine());
                            cantYuca += cantCosechada;
                            lote3 = "Sin siembras";
                            estadoLote3 = "Disponible";
                        }
                    }
                    if (opcion == "4" && estadoLote4 == "Disponible")
                    {
                        Console.WriteLine("No hay nada sembrado en este lote");
                    }
                    else if (opcion == "4" && estadoLote4 == "Ocupado")
                    {
                        if (lote4 == "Cultivo de Frijol")
                        {
                            Console.WriteLine("Cuantas libras se cosecharon?");
                            cantCosechada = int.Parse(Console.ReadLine());
                            cantFrijol += cantCosechada;
                            lote4 = "Sin siembras";
                            estadoLote4 = "Disponible";
                        }
                        if (lote4 == "Cultivo de Papa")
                        {
                            Console.WriteLine("Cuantas libras se cosecharon?");
                            cantCosechada = int.Parse(Console.ReadLine());
                            cantPapa += cantCosechada;
                            lote4 = "Sin siembras";
                            estadoLote4 = "Disponible";
                        }
                        if (lote4 == "Cultivo de cebolla")
                        {
                            Console.WriteLine("Cuantas libras se cosecharon?");
                            cantCosechada = int.Parse(Console.ReadLine());
                            cantCebolla += cantCosechada;
                            lote4 = "Sin siembras";
                            estadoLote4 = "Disponible";
                        }
                        if (lote4 == "Cultivo de maiz")
                        {
                            Console.WriteLine("Cuantas libras se cosecharon?");
                            cantCosechada = int.Parse(Console.ReadLine());
                            cantMaiz += cantCosechada;
                            lote4 = "Sin siembras";
                            estadoLote4 = "Disponible";
                        }
                        if (lote4 == "Cultivo de trigo")
                        {
                            Console.WriteLine("Cuantas libras se cosecharon?");
                            cantCosechada = int.Parse(Console.ReadLine());
                            cantTrigo += cantCosechada;
                            lote4 = "Sin siembras";
                            estadoLote4 = "Disponible";
                        }
                        if (lote4 == "Cultivo de yuca")
                        {
                            Console.WriteLine("Cuantas libras se cosecharon?");
                            cantCosechada = int.Parse(Console.ReadLine());
                            cantYuca += cantCosechada;
                            lote4 = "Sin siembras";
                            estadoLote4 = "Disponible";
                        }
                    }
                    if (opcion == "5" && estadoLote5 == "Disponible")
                    {
                        Console.WriteLine("No hay nada sembrado en este lote");
                    }
                    else if (opcion == "5" && estadoLote5 == "Ocupado")
                    {
                        if (lote5 == "Cultivo de Frijol")
                        {
                            Console.WriteLine("Cuantas libras se cosecharon?");
                            cantCosechada = int.Parse(Console.ReadLine());
                            cantFrijol += cantCosechada;
                            lote5 = "Sin siembras";
                            estadoLote5 = "Disponible";
                        }
                        if (lote5 == "Cultivo de Papa")
                        {
                            Console.WriteLine("Cuantas libras se cosecharon?");
                            cantCosechada = int.Parse(Console.ReadLine());
                            cantPapa += cantCosechada;
                            lote5 = "Sin siembras";
                            estadoLote5 = "Disponible";
                        }
                        if (lote5 == "Cultivo de cebolla")
                        {
                            Console.WriteLine("Cuantas libras se cosecharon?");
                            cantCosechada = int.Parse(Console.ReadLine());
                            cantCebolla += cantCosechada;
                            lote5 = "Sin siembras";
                            estadoLote5 = "Disponible";
                        }
                        if (lote5 == "Cultivo de maiz")
                        {
                            Console.WriteLine("Cuantas libras se cosecharon?");
                            cantCosechada = int.Parse(Console.ReadLine());
                            cantMaiz += cantCosechada;
                            lote5 = "Sin siembras";
                            estadoLote5 = "Disponible";
                        }
                        if (lote5 == "Cultivo de trigo")
                        {
                            Console.WriteLine("Cuantas libras se cosecharon?");
                            cantCosechada = int.Parse(Console.ReadLine());
                            cantTrigo += cantCosechada;
                            lote5 = "Sin siembras";
                            estadoLote5 = "Disponible";
                        }
                        if (lote5 == "Cultivo de yuca")
                        {
                            Console.WriteLine("Cuantas libras se cosecharon?");
                            cantCosechada = int.Parse(Console.ReadLine());
                            cantYuca += cantCosechada;
                            lote5 = "Sin siembras";
                            estadoLote5 = "Disponible";
                        }
                    }
                    if (opcion == "6" && estadoLote6 == "Disponible")
                    {
                        Console.WriteLine("No hay nada sembrado en este lote");
                    }
                    else if (opcion == "6" && estadoLote6 == "Ocupado")
                    {
                        if (lote6 == "Cultivo de Frijol")
                        {
                            Console.WriteLine("Cuantas libras se cosecharon?");
                            cantCosechada = int.Parse(Console.ReadLine());
                            cantFrijol += cantCosechada;
                            lote6 = "Sin siembras";
                            estadoLote6 = "Disponible";
                        }
                        if (lote6 == "Cultivo de Papa")
                        {
                            Console.WriteLine("Cuantas libras se cosecharon?");
                            cantCosechada = int.Parse(Console.ReadLine());
                            cantPapa += cantCosechada;
                            lote6 = "Sin siembras";
                            estadoLote6 = "Disponible";
                        }
                        if (lote6 == "Cultivo de cebolla")
                        {
                            Console.WriteLine("Cuantas libras se cosecharon?");
                            cantCosechada = int.Parse(Console.ReadLine());
                            cantCebolla += cantCosechada;
                            lote6 = "Sin siembras";
                            estadoLote6 = "Disponible";
                        }
                        if (lote6 == "Cultivo de maiz")
                        {
                            Console.WriteLine("Cuantas libras se cosecharon?");
                            cantCosechada = int.Parse(Console.ReadLine());
                            cantMaiz += cantCosechada;
                            lote6 = "Sin siembras";
                            estadoLote6 = "Disponible";
                        }
                        if (lote6 == "Cultivo de trigo")
                        {
                            Console.WriteLine("Cuantas libras se cosecharon?");
                            cantCosechada = int.Parse(Console.ReadLine());
                            cantTrigo += cantCosechada;
                            lote6 = "Sin siembras";
                            estadoLote6 = "Disponible";
                        }
                        if (lote6 == "Cultivo de yuca")
                        {
                            Console.WriteLine("Cuantas libras se cosecharon?");
                            cantCosechada = int.Parse(Console.ReadLine());
                            cantYuca += cantCosechada;
                            lote6 = "Sin siembras";
                            estadoLote6 = "Disponible";
                        }
                    }
                    break;
                case '4':
                    Console.WriteLine("\nLibras de frijol: " + cantFrijol);
                    Console.WriteLine("Libras de papa: " + cantPapa);
                    Console.WriteLine("Libras de cebolla: " + cantCebolla);
                    Console.WriteLine("Libras de maiz: " + cantMaiz);
                    Console.WriteLine("Libras de trigo: " + cantTrigo);
                    Console.WriteLine("Libras de yuca: " + cantYuca);
                    break;
            }
        }
    }

}