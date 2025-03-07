using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consola
{
    internal class Acciones
    {
        Profesor pr = new Profesor();
        Profesor[] arregloprofesor;

        public void AgregarProfesor()
        {
            Console.WriteLine("Cuantos profesores deseas agregar");
            int numprofesores = Convert.ToInt32(Console.ReadLine());

            arregloprofesor = new Profesor[numprofesores];

            for (int i = 0; i < arregloprofesor.Length; i++)
            {
                Console.WriteLine("Nombre");
                pr.Nombre = Console.ReadLine();
                Console.WriteLine("Edad");
                pr.Edad = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Numero de materias");
                pr.NumMaterias = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Año de nacimiento");
                pr.AnioNacimiento = Convert.ToDateTime(Console.ReadLine());
                Console.WriteLine("Clave de profesor");
                pr.ClaveProfesor = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Salario");
                pr.Salario = Convert.ToDouble(Console.ReadLine());

                arregloprofesor[i] = new Profesor(pr.Nombre, pr.Edad, pr.NumMaterias, pr.AnioNacimiento, pr.ClaveProfesor, pr.Salario);
            }
        }
        public void MostrarProfesor()
        {
            foreach (var a in arregloprofesor)
            {
                Console.WriteLine($"Nombre es:{a.Nombre}");
                Console.WriteLine($"La edad es:{a.Edad}");
                Console.WriteLine($"Numero de materias son:{a.NumMaterias}");
                Console.WriteLine($"El año de nacimeiento es:{a.AnioNacimiento}");
                Console.WriteLine($"La clave del profesor es:{a.ClaveProfesor}");
                Console.WriteLine($"El salario es:{a.Salario}");
            }
        }
        public int ContarProfesores()
        {
            return arregloprofesor.Length;
        }
        public void PromedioEdades() 
        {
            double sumapromedio = 0;
            foreach(var p in arregloprofesor)
            {
                sumapromedio = sumapromedio + p.Edad;
            }
            Console.WriteLine($"El promedio es: {sumapromedio/arregloprofesor.Length}");
        }
        public void PromedioSalario()
        {
            double sumapromedio = 0;
            foreach (var p in arregloprofesor)
            {
                sumapromedio = sumapromedio + p.Salario;
            }
            Console.WriteLine($"El promedio es: {sumapromedio + arregloprofesor.Length}");
        }






    }
}
