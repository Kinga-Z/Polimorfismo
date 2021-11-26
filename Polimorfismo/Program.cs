using System;

namespace Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            Estudiante Fabricio = new Estudiante("Fabrico", "Chavez", 1314620855, "Soltero", 8);
            Fabricio.MostrarEstudiante();
            Fabricio.Cambio1();
            Fabricio.Cambio();

            Contrato Arturo = new Contrato("Arturo", "Alonso", 13458269, "Soltero", 24, 2021, "Lenguaje");
            Arturo.MostrarContrato();
            Arturo.Cambio();
            Arturo.Cambio1();
            Arturo.Cambio2();

            Fijo Enrique = new Fijo("Enrique", "Segoviano", 1308328569, "Viudo", 34, 2006, "Matemáticas");
            Enrique.MostrarFijo();
            Enrique.Cambio1();
            Enrique.Cambio();
            Enrique.Cambio2();


            Personal Eddu = new Personal("Eddu", "Copiano", 1324571852, "Casado", 10, 2002, "Patio");
            Eddu.MostrarEmpleado();
            Eddu.Cambio1();
            Eddu.Cambio();
            Eddu.Cambio2();

            Fabricio.MostrarNewEstudiante();
            Arturo.MostrarNewContrato();
            Enrique.MostrarNewFijo();
            Eddu.MostrarNewEmpleado();

        }
    }
}
