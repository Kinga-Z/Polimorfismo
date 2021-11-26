using System;
using System.Collections.Generic;
using System.Text;

namespace Polimorfismo
{
    class Personal : Empleado
    {
        public string SeccionAsignada { get; set; }
        public Personal(string Nombre, string Apellido, int Cedula, string EstadoCivil, int NumeroDespacho, int AñoIncorporacion, string SeccionAsignada) : base(Nombre, Apellido, Cedula, EstadoCivil, NumeroDespacho, AñoIncorporacion)
        {
            this.SeccionAsignada = SeccionAsignada;
        }
        public void MostrarEmpleado()
        {
            Console.WriteLine("----------------\nEMPLEADO\n----------------");
            Console.WriteLine("Nombre: " + Nombre + "\nApellido: " + Apellido);
            Console.WriteLine("Cedula: " + Cedula);
            Console.WriteLine("Estado Civil: " + EstadoCivil);
            Console.WriteLine("Número Despacho: " + NumeroDespacho);
            Console.WriteLine("Año Incorporacion: " + AñoIncorporacion);
            Console.WriteLine("Seccion Asignada: " + SeccionAsignada);
        }
        public override void Cambio()
        {
            string NuevaSeccion;
            Console.WriteLine("Seccion a trasladar ");
            NuevaSeccion = Convert.ToString(Console.ReadLine());
            SeccionAsignada = NuevaSeccion;
            Console.WriteLine("Sección nueva asignada: " + SeccionAsignada);
        }
        public void MostrarNewEmpleado()
        {
            Console.WriteLine("----------------\nEMPLEADO\n----------------");
            Console.WriteLine("Nombre: " + Nombre + "\nApellido: " + Apellido);
            Console.WriteLine("Cedula: " + Cedula);
            Console.WriteLine("Estado Civil: " + EstadoCivil);
            Console.WriteLine("Número Despacho: " + NumeroDespacho);
            Console.WriteLine("Año Incorporacion: " + AñoIncorporacion);
            Console.WriteLine("Seccion Asignada: " + SeccionAsignada);
        }
    }

}
