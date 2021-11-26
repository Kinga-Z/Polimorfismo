using System;
using System.Collections.Generic;
using System.Text;

namespace Polimorfismo
{
    class Persona
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Cedula { get; set; }
        public string EstadoCivil { get; set; }

        public Persona(string Nombre, string Apellido, int Cedula, string EstadoCivil)
        {
            this.Nombre = Nombre;
            this.Apellido = Apellido;
            this.Cedula = Cedula;
            this.EstadoCivil = EstadoCivil;

        }
        public virtual void Cambio1()
        {
            string NuevoEstadoCivil;
            Console.WriteLine("Actualización de Estado Civil");
            NuevoEstadoCivil = Convert.ToString(Console.ReadLine());
            EstadoCivil = NuevoEstadoCivil;
            Console.WriteLine("Estado Civil actual: " + EstadoCivil);
        }
        public virtual void Cambio()
        {

        }
    }
}
