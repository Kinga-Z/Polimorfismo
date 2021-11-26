using System;
using System.Collections.Generic;
using System.Text;

namespace Polimorfismo
{
    class Empleado : Persona
    {
        public int NumeroDespacho { get; set; }
        public int AñoIncorporacion { get; set; }
        public Empleado(string Nombre, string Apellido, int Cedula, string EstadoCivil, int NumeroDespacho, int AñoIncorporacion) : base(Nombre, Apellido, Cedula, EstadoCivil)
        {
            this.NumeroDespacho = NumeroDespacho;
            this.AñoIncorporacion = AñoIncorporacion;
        }
        public virtual void Cambio2()
        {
            int NuevoDespacho;
            Console.WriteLine("Reasignacion de Despacho de " + NumeroDespacho + " a:");
            NuevoDespacho = Convert.ToInt32(Console.ReadLine());
            NumeroDespacho = NuevoDespacho;
            Console.WriteLine("Nuevo despacho: " + NumeroDespacho);
        }
    }
}
