using System;
using cultivos.Cultivos;
using Finca_Robots.robots;
using Finca_Robots.ventas;
namespace menuUsuario.MenuUsuario
{
    public class MenuUsuario
    {
        #region Atributos
        public string opcion { get; set; }

        #endregion Atributos

        /*Con esto hacemos que sea posible regresar a
        *un menu anterior
         */
        public bool regresar = false;
        public bool regresar2 = false;

        // Menu principal
        public void Menu()
        {
            Console.WriteLine("Bienvenido a la finca de Robots \nPor favor digita una opcion para realizar la tarea que necesitas:\n1.Cultivos \n2.Robots\n3.Ventas\n0.Salir del programa\n");
            opcion = Console.ReadLine();
            if (opcion == "1")
            {
                Cultivos menuCultivo = new Cultivos();
                menuCultivo.menuCultivos();
                regresar = false;
            }
            if (opcion == "2")
            {
                Robots menuRobots = new Robots();
                menuRobots.menuRobots();
                regresar = false;
            }
            if (opcion == "3")
            {
                Ventas menuVenta = new Ventas();
                menuVenta.menuVentas();
            }
            if (opcion == "0")
            {
                Environment.Exit(0);
                regresar = true;
            }
        }



    }
}