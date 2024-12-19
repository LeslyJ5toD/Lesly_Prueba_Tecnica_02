using System;

namespace Lesly_Prueba_Tecnica_02
{
    internal class Program
    {
        static void Main(string[] args)
        {



            Console.WriteLine("--------------------Registro de Calificaciones--------------------");
            Console.WriteLine();

            Estudiante estudiante = new Estudiante();
            int opcion;

            Console.WriteLine("----------Menu de opciones----------");
            Console.WriteLine();

            do
            {

            Console.WriteLine("2.Crear registro academico");
            Console.WriteLine("3.Ver ejemplo de registro");
            Console.WriteLine("4. Salir");
            Console.Write("\nSeleccione una opción: ");
            opcion = Convert.ToInt32(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    estudiante.MostrarMenu();
                    break;
                case 2:
                    estudiante.CrearRegistro();
                        Console.WriteLine();
                        break;
                case 3:
                        estudiante.MostrarEjemplo();
                        Console.WriteLine();
                        break;
                case 4:
                        Console.WriteLine("Gracias por usar el sistema. ¡Hasta luego!");
                        return;  
                    default:
                        Console.WriteLine("Opción inválida. Intente nuevamente.");
                        Console.WriteLine();
                        break;
                }

        } while (opcion != 4);



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
    }
}
