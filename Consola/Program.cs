using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Consola
{
    internal class Program
    {
        public enum Menu
        {
            Agregar = 1, Mostrar, Contar, Edades, Salarios
        }
        static void Main(string[] args)
        {
            Acciones acciones = new Acciones();
            while (true)
            {
                switch (Men())
                {
                    case Menu.Agregar:
                        acciones.AgregarProfesor();
                        break;
                    case Menu.Mostrar:
                        acciones.MostrarProfesor();
                        break;
                    case Menu.Contar:
                        Console.WriteLine(acciones.ContarProfesores()); 
                        break;
                    case Menu.Edades:
                        acciones.PromedioEdades();
                        break;
                    case Menu.Salarios:
                        acciones.PromedioSalario();
                        break;
                    default:
                        Environment.Exit(1);
                        break;
                }
            }
        }
        static Menu Men()
        {
            Console.WriteLine("Que deseas hacer");
            Console.WriteLine("1)Agregar profesor");
            Console.WriteLine("2)Mostrar profesor");
            Console.WriteLine("3)Contar profesor");
            Console.WriteLine("4)Edades");
            Console.WriteLine("5)Salarios");
            Console.WriteLine("6)Salir");

            Menu opc = (Menu)Convert.ToInt32(Console.ReadLine());

            return opc;
        }
    }
}