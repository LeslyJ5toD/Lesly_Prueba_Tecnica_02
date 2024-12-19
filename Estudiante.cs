using System;


namespace Lesly_Prueba_Tecnica_02
{
    internal class Estudiante
    {

        public string Nombre { get; set; }

        public int Edad { get; set; }

        public void MostrarMenu()
        {
            Console.Clear();
            Console.WriteLine("---- Menu de opciones ----\n");

        }

        public void CrearRegistro()
        {
            Estudiante estudiante = new Estudiante();

            Console.WriteLine("Cree su nuevo registro:");

            Console.Write("Ingrese su nombre:");
            estudiante.Nombre = Console.ReadLine();

            Console.Write("Ingrese su edad:");
            estudiante.Edad = Convert.ToInt32(Console.ReadLine());

            Asignatura asignatura = new Asignatura();

            Console.Write("Ingrese el nombre de la asignatura:");
            asignatura.Nombre = Console.ReadLine();

            Console.Write("Ingrese la calificacion obtenida:");
            asignatura.Calificacion = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine($"El nombre del estudiante es: {estudiante.Nombre}");
            Console.WriteLine($"La edad del estudiante es: {estudiante.Edad}");
            Console.WriteLine($"El nombre de la asignatura es: {asignatura.Nombre}");
            Console.WriteLine($"La calificacion obtenida es: {asignatura.Calificacion}");

        }

        public void MostrarEjemplo()
        {
            Console.WriteLine("El nombre del estudiante es: Lesly");
            Console.WriteLine("La edad del estudiante es: 15");
            Console.WriteLine("La asignatura es: Analisis y diseño de reportes ");
            Console.WriteLine("La calificacion del estudiante es: 90");

        }
    }
}
