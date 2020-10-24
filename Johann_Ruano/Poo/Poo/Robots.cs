using System;
using menuUsuario.MenuUsuario;

namespace Finca_Robots.robots
{
    public class Robots
    {
        #region robots
        string robot1 = "Encendido";
        string robot2 = "Encendido";
        string robot3 = "Encendido";
        string robot4 = "Encendido";
        string estadoRobot1 = "Sin tareas";
        string estadoRobot2 = "Sin tareas";
        string estadoRobot3 = "Sin tareas";
        string estadoRobot4 = "Sin tareas";
        #endregion robots
        bool regresar = false;
        string opcion;
        public void menuRobots()
        {
            while (regresar == false)
            {
                Console.WriteLine("Haz seleccionado Robots \n1.Ver estado de los robots \n2.Asignar tareas\n3.Encender un robot\n4.Apagar un robot\n5.Acabar tarea de un robot\n0.Volver al menu principal\n");
                opcion = Console.ReadLine();
                if (opcion == "1")
                {
                    estados();
                }
                if (opcion == "2")
                {
                    tareasRobots();
                }
                if (opcion == "3")
                {
                    encender();
                }
                if (opcion == "4")
                {
                    apagar();
                }
                if (opcion == "5")
                {
                    acabarTarea();
                }
                if (opcion == "0")
                {
                    MenuUsuario menuPrincipal = new MenuUsuario();
                    menuPrincipal.Menu();

                }
            }
        }
        public void estados()
        {
            Console.WriteLine("Estado Robot1: " + robot1 + ", Tareas: " + estadoRobot1);
            Console.WriteLine("Estado Robot2: " + robot2 + ", Tareas: " + estadoRobot2);
            Console.WriteLine("Estado Robot1: " + robot3 + ", Tareas: " + estadoRobot3);
            Console.WriteLine("Estado Robot1: " + robot1 + ", Tareas: " + estadoRobot4);
        }
        public void tareasRobots()
        {
            Console.WriteLine("Elige al robot que debe realizar la tarea:\n1.Robot1\n2.Robot2\n3.Robot3\n4.Robot4\n");
            opcion = Console.ReadLine();
            if (opcion == "1")
            {
                if (robot1 == "Encendido" && estadoRobot1 == "Sin tareas")
                {
                    Console.WriteLine("Que tarea va a realizar?\n1.Cortar maleza\n2.Monitorear estado de los cultivos\n3.Fumigar los cultivos\n4.Recolectar muestras de los cultivos\n");
                    opcion = Console.ReadLine();
                    if (opcion == "1")
                    {
                        estadoRobot1 = "Cortando maleza";
                    }
                    if (opcion == "2")
                    {
                        estadoRobot1 = "Monitoreando los cultivos";

                    }
                    if (opcion == "3")
                    {
                        estadoRobot1 = "Fumigando";
                    }
                    if (opcion == "4")
                    {
                        estadoRobot1 = "Recolectando muestras";
                    }
                }
                else
                {
                    Console.WriteLine("El robot1 ya tiene una tarea asignada\n");
                }
            }
            if (opcion == "2")
            {
                if (robot2 == "Encendido" && estadoRobot2 == "Sin tareas")
                {
                    Console.WriteLine("Que tarea va a realizar?\n1.Cortar maleza\n2.Monitorear estado de los cultivos\n3.Fumigar los cultivos\n4.Recolectar muestras de los cultivos\n");
                    opcion = Console.ReadLine();
                    if (opcion == "1")
                    {
                        estadoRobot2 = "Cortando maleza";
                    }
                    if (opcion == "2")
                    {
                        estadoRobot2 = "Monitoreando los cultivos";

                    }
                    if (opcion == "3")
                    {
                        estadoRobot2 = "Fumigando";
                    }
                    if (opcion == "4")
                    {
                        estadoRobot2 = "Recolectando muestras";
                    }
                }
                else
                {
                    Console.WriteLine("El robot2 ya tiene una tarea asignada\n");
                }
            }
            if (opcion == "3")
            {
                if (robot3 == "Encendido" && estadoRobot3 == "Sin tareas")
                {
                    Console.WriteLine("Que tarea va a realizar?\n1.Cortar maleza\n2.Monitorear estado de los cultivos\n3.Fumigar los cultivos\n4.Recolectar muestras de los cultivos\n");
                    opcion = Console.ReadLine();
                    if (opcion == "1")
                    {
                        estadoRobot3 = "Cortando maleza";
                    }
                    if (opcion == "2")
                    {
                        estadoRobot3 = "Monitoreando los cultivos";

                    }
                    if (opcion == "3")
                    {
                        estadoRobot3 = "Fumigando";
                    }
                    if (opcion == "4")
                    {
                        estadoRobot3 = "Recolectando muestras";
                    }
                }
                else
                {
                    Console.WriteLine("El robot1 ya tiene una tarea asignada\n");
                }
            }
            if (opcion == "4")
            {
                if (robot4 == "Encendido" && estadoRobot4 == "Sin tareas")
                {
                    Console.WriteLine("Que tarea va a realizar?\n1.Cortar maleza\n2.Monitorear estado de los cultivos\n3.Fumigar los cultivos\n4.Recolectar muestras de los cultivos\n");
                    opcion = Console.ReadLine();
                    if (opcion == "1")
                    {
                        estadoRobot4 = "Cortando maleza";
                    }
                    if (opcion == "2")
                    {
                        estadoRobot4 = "Monitoreando los cultivos";

                    }
                    if (opcion == "3")
                    {
                        estadoRobot4 = "Fumigando";
                    }
                    if (opcion == "4")
                    {
                        estadoRobot4 = "Recolectando muestras";
                    }
                }
                else
                {
                    Console.WriteLine("El robot1 ya tiene una tarea asignada\n");
                }
            }
        }
        public void encender()
        {
            Console.WriteLine("Elige al robot que deseas encender:\n1.Robot1\n2.Robot2\n3.Robot3\n4.Robot4\n");
            opcion = Console.ReadLine();
            if (opcion == "1")
            {
                if (robot1 == "Apagado")
                {
                    robot1 = "Encendido";
                }
                else
                {
                    Console.WriteLine("Este robot ya estaba encendido\n");
                }
            }
            if (opcion == "2")
            {
                if (robot2 == "Apagado")
                {
                    robot2 = "Encendido";
                }
                else
                {
                    Console.WriteLine("Este robot ya estaba encendido\n");
                }
            }
            if (opcion == "3")
            {
                if (robot3 == "Apagado")
                {
                    robot3 = "Encendido";
                }
                else
                {
                    Console.WriteLine("Este robot ya estaba encendido\n");
                }
            }
            if (opcion == "4")
            {
                if (robot4 == "Apagado")
                {
                    robot4 = "Encendido";
                }
                else
                {
                    Console.WriteLine("Este robot ya estaba encendido\n");
                }
            }
        }
        public void apagar()
        {
            Console.WriteLine("Elige al robot que deseas apagar:\n1.Robot1\n2.Robot2\n3.Robot3\n4.Robot4\n");
            opcion = Console.ReadLine();
            if (opcion == "1")
            {
                if (robot1 == "Encendido")
                {
                    robot1 = "Apagado";
                    estadoRobot1 = "Sin tareas";
                }
                else
                {
                    Console.WriteLine("Este robot ya estaba pagado\n");
                }
            }
            if (opcion == "2")
            {
                if (robot2 == "Encendido")
                {
                    robot2 = "Apagado";
                    estadoRobot2 = "Sin tareas";
                }
                else
                {
                    Console.WriteLine("Este robot ya estaba pagado\n");
                }
            }
            if (opcion == "3")
            {
                if (robot3 == "Encendido")
                {
                    robot3 = "Apagado";
                    estadoRobot3 = "Sin tareas";
                }
                else
                {
                    Console.WriteLine("Este robot ya estaba pagado\n");
                }
            }
            if (opcion == "4")
            {
                if (robot4 == "Encendido")
                {
                    robot4 = "Apagado";
                    estadoRobot4 = "Sin tareas";
                }
                else
                {
                    Console.WriteLine("Este robot ya estaba pagado\n");
                }
            }
        }
        public void acabarTarea()
        {
            Console.WriteLine("Elige al robot que ya acabo su tarea:\n1.Robot1\n2.Robot2\n3.Robot3\n4.Robot4\n");
            opcion = Console.ReadLine();
            if (opcion == "1")
            {
                if (estadoRobot1 == "Cortando maleza" || estadoRobot1 == "Monitoreando los cultivos" || estadoRobot1 == "Fumigando" || estadoRobot1 == "Recolectando muestras")
                {
                    estadoRobot1 = "Sin tareas";
                    Console.WriteLine("Tarea acabada con exito\n");
                }
                else
                {
                    Console.WriteLine("Este robot no tenia ninguna tarea\n");
                }
            }
            if (opcion == "2")
            {
                if (estadoRobot2 == "Cortando maleza" || estadoRobot2 == "Monitoreando los cultivos" || estadoRobot2 == "Fumigando" || estadoRobot2 == "Recolectando muestras")
                {
                    estadoRobot2 = "Sin tareas";
                    Console.WriteLine("Tarea acabada con exito\n");
                }
                else
                {
                    Console.WriteLine("Este robot no tenia ninguna tarea\n");
                }
            }
            if (opcion == "3")
            {
                if (estadoRobot3 == "Cortando maleza" || estadoRobot3 == "Monitoreando los cultivos" || estadoRobot3 == "Fumigando" || estadoRobot3 == "Recolectando muestras")
                {
                    estadoRobot3 = "Sin tareas";
                    Console.WriteLine("Tarea acabada con exito\n");
                }
                else
                {
                    Console.WriteLine("Este robot no tenia ninguna tarea\n");
                }
            }
            if (opcion == "4")
            {
                if (estadoRobot4 == "Cortando maleza" || estadoRobot4 == "Monitoreando los cultivos" || estadoRobot4 == "Fumigando" || estadoRobot4 == "Recolectando muestras")
                {
                    estadoRobot4 = "Sin tareas";
                    Console.WriteLine("Tarea acabada con exito\n");
                }
                else
                {
                    Console.WriteLine("Este robot no tenia ninguna tarea\n");
                }
            }
        }
    }
}