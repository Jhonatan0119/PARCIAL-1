using c;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PARCIAL_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int Id = 0;
            String Nombre;
            int Edad;
            String control = "Si";
            String control2 = "Si";
            int indice = 0;
            int Nota1;
            int Nota2;
            int Parcial;
            int NotaFinal;
            int Opciones;
            string Cerrar;

            iEstudiantes[] Infoestudiantes = new iEstudiantes[1];


            while (control == "Si")
            {
                Console.WriteLine("Ingrese los siguientes datos:");
                Console.WriteLine("Ingrese el Nombre:");
                Nombre = Console.ReadLine();
                Console.WriteLine("Ingrese la Edad:");
                Edad = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese la Nota1:");
                Nota1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese la Nota2:");
                Nota2 = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese la Nota del Parcial:");
                Parcial = int.Parse(Console.ReadLine());

                NotaFinal = (int)((Nota1 * .3)+ (Nota2 * .3) +(Parcial * .4));

                Infoestudiantes[indice] = new iEstudiantes(Id, Nombre, Edad, Nota1, Nota2, Parcial, NotaFinal);
                Id = Id + 1;
                Console.WriteLine("Desea agregar otro registro (Si, No): ");
                control = Console.ReadLine();
                if (control == "Si")
                {
                    indice = indice + 1;
                    Array.Resize(ref Infoestudiantes, Infoestudiantes.Length + 1);

                }
                else { control = "No"; }
            }


            while (control2 == "Si")
            {
                Console.WriteLine("Desea consultar por Aprobados: Digite 1");
                Console.WriteLine("Desea consultar por Reprobados: Digite 2");
                Opciones = int.Parse(Console.ReadLine());
                if (Opciones == 1)
                {
                    IEnumerable<iEstudiantes> reqEstudiantes = from estudiante in Infoestudiantes
                                                                   where estudiante.NotaFinal >= 6
                                                                   select estudiante;
                    foreach (iEstudiantes consulta in reqEstudiantes)
                    {
                        Console.WriteLine(consulta.Mostrar() + "¡APROBADO!");

                    }
                }
                else if (Opciones == 2)
                {
                    IEnumerable<iEstudiantes> reqEstudiantes = from estudiante in Infoestudiantes
                                                                   where estudiante.NotaFinal < 6
                                                                   select estudiante;
                    foreach (iEstudiantes consulta in reqEstudiantes)
                    {
                        Console.WriteLine(consulta.Mostrar() + "¡REPROBADO!");

                    }
                }
              
                Console.WriteLine("Desea continuar: Si, No");
                Cerrar = Console.ReadLine();
                if (Cerrar == "No")
                {
                    control2 = "No";
                }
            }

            Console.Read();

        }
    }
}
