using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consola
{
    internal class Profesor
    {

        public Profesor(string nombre, int edad, int nummaterias, DateTime anionacimiento, int claveprofesor, double salario) 
        {
            Nombre = nombre;
            Edad = edad;
            NumMaterias = nummaterias;
            AnioNacimiento = anionacimiento;
            ClaveProfesor = claveprofesor;
            Salario = salario;
        }
        public Profesor() { }
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public int NumMaterias { get; set; }
        public DateTime AnioNacimiento { get; set; }
        public int ClaveProfesor { get; set; }  
        public double Salario { get; set; }
    }
}
