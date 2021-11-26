using System;
using System.Collections.Generic;
using System.Text;

namespace Polimorfismo
{
    class Contrato : Empleado
    {
        int HorasTrabajadas;
        int PrecioHora = 17;

        public string Departamento { get; set; }
        public Contrato(string Nombre, string Apellido, int Cedula, string EstadoCivil, int NumeroDespacho, int AñoIncorporacion, string Departamento) : base(Nombre, Apellido, Cedula, EstadoCivil, NumeroDespacho, AñoIncorporacion)
        {
            this.Departamento = Departamento;
        }
        public void MostrarContrato()

        {

            Console.WriteLine("-----------------\nProfesor Contratado\n-----------------");
            Console.WriteLine("Nombre: " + Nombre + "\nApellido: " + Apellido);
            Console.WriteLine("Cedula: " + Cedula);
            Console.WriteLine("Estado Civil: " + EstadoCivil);
            Console.WriteLine("Despacho: " + NumeroDespacho);
            Console.WriteLine("Año Incorporacion: " + AñoIncorporacion);
            Console.WriteLine("Departamento: " + Departamento);
            Console.WriteLine("Ingrese las horas trabajadas: ");
            HorasTrabajadas = Convert.ToInt32(Console.ReadLine());
            int Total = HorasTrabajadas * PrecioHora;
            Console.WriteLine("Horas Trabajadas: " + HorasTrabajadas + "\nValor de la hora: " + PrecioHora + "$\nSueldo Total " + Total + " $");
        }
        public override void Cambio()
        {
            string NuevoDepartamento;
            Console.WriteLine("Departamento al que quiera cambiar");
            NuevoDepartamento = Convert.ToString(Console.ReadLine());
            Departamento = NuevoDepartamento;
            Console.WriteLine("Departamento nuevo: " + Departamento);
        }
        public void MostrarNewContrato()
        {
            int Total = HorasTrabajadas * PrecioHora;
            Console.WriteLine("-----------------\nProfesor Contratado\n-----------------");
            Console.WriteLine("Nombre: " + Nombre + "\nApellido: " + Apellido);
            Console.WriteLine("Cedula: " + Cedula);
            Console.WriteLine("Estado Civil: " + EstadoCivil);
            Console.WriteLine("Despacho: " + NumeroDespacho);
            Console.WriteLine("Año Incorporacion: " + AñoIncorporacion);
            Console.WriteLine("Departamento: " + Departamento);
            Console.WriteLine("Horas Trabajadas: " + HorasTrabajadas + "\nValor de la hora: " + PrecioHora + "$\nSueldo Total " + Total + " $");
        }
    }
}
