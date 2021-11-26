using System;
using System.Collections.Generic;
using System.Text;

namespace Polimorfismo
{
    class Estudiante : Persona
    {
        public int Curso { get; set; }
        public Estudiante(string Nombre, string Apellido, int Cedula, string EstadoCivil, int Curso) : base(Nombre, Apellido, Cedula, EstadoCivil)
        {
            this.Curso = Curso;
        }
        public void MostrarEstudiante()
        {
            Console.WriteLine("----------------------\n     ESTUDIANTE    \n----------------------");
            Console.WriteLine("Nombre: " + Nombre + "\nApellido: " + Apellido);
            Console.WriteLine("Cedula: " + Cedula);
            Console.WriteLine("Estado Civil: " + EstadoCivil);
            Console.WriteLine("Curso: " + Curso);
        }
        public override void Cambio()
        {
            int NewCurso;
            Console.WriteLine("Curso a Matricular");
            NewCurso = Convert.ToInt32(Console.ReadLine());
            Curso = NewCurso;
            Console.WriteLine("Curso nuevo: " + Curso);
        }
        public void MostrarNewEstudiante()
        {
            Console.WriteLine("----------------------\n   DATOS ACTUALIZADOS\n----------------------");
            Console.WriteLine("----------------------\n     ESTUDIANTE    \n----------------------");
            Console.WriteLine("Nombre: " + Nombre + "\nApellido: " + Apellido);
            Console.WriteLine("Cedula: " + Cedula);
            Console.WriteLine("Estado Civil: " + EstadoCivil);
            Console.WriteLine("Curso: " + Curso);

        }
    }
}