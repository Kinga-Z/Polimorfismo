using System;
using System.Collections.Generic;
using System.Text;

namespace Polimorfismo
{
    class Fijo : Empleado
    {
        public string Departamento { get; set; }
        public Fijo(string Nombre, string Apellido, int Cedula, string EstadoCivil, int NumeroDespacho, int AñoIncorporacion, string Departamento) : base(Nombre, Apellido, Cedula, EstadoCivil, NumeroDespacho, AñoIncorporacion)
        {
            this.Departamento = Departamento;
        }
        int PrecioHora = 13;
        int HorasExtras;
        int Sueldo = 700;

        public void MostrarFijo()
        {
            Console.WriteLine("-----------------\nProfesor Fijo\n-----------------");
            Console.WriteLine("Nombre: " + Nombre + "\nApellido: " + Apellido);
            Console.WriteLine("Cedula: " + Cedula);
            Console.WriteLine("Estado Civil: " + EstadoCivil);
            Console.WriteLine("Despacho: " + NumeroDespacho);
            Console.WriteLine("Año Incorporacion: " + AñoIncorporacion);
            Console.WriteLine("Departamento: " + Departamento);
            Console.WriteLine("Ingrese las Horas Extras trabajadas:");
            HorasExtras = Convert.ToInt32(Console.ReadLine());
            int ValorSuma = HorasExtras * PrecioHora;
            int SueldoT = ValorSuma + Sueldo;
            Console.WriteLine("Sueldo Fijo de " + Sueldo + "$\nHoras Extras " + HorasExtras + "\nValor de la Hora " + PrecioHora + "$\nSueldo Total " + SueldoT + "$");
        }
        public override void Cambio()
        {
            string NuevoDepartamento;
            Console.WriteLine("Departamento al que quiera cambiar");
            NuevoDepartamento = Convert.ToString(Console.ReadLine());
            Departamento = NuevoDepartamento;
            Console.WriteLine("Departamento nuevo: " + Departamento);
        }
        public void MostrarNewFijo()
        {
            int ValorSuma = HorasExtras * PrecioHora;
            int SueldoT = ValorSuma + Sueldo;
            Console.WriteLine("-----------------\nProfesor Fijo\n-----------------");
            Console.WriteLine("Nombre: " + Nombre + "\nApellido: " + Apellido);
            Console.WriteLine("Cedula: " + Cedula);
            Console.WriteLine("Estado Civil: " + EstadoCivil);
            Console.WriteLine("Despacho: " + NumeroDespacho);
            Console.WriteLine("Año Incorporacion: " + AñoIncorporacion);
            Console.WriteLine("Departamento: " + Departamento);
            Console.WriteLine("Sueldo Fijo de " + Sueldo + "$\nHoras Extras " + HorasExtras + "\nValor de la Hora " + PrecioHora + "$\nSueldo Total " + SueldoT + "$");
        }
    }
}
