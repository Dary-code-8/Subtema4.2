using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace faltan_2_semanas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion;
            string codigo = "", carrera = "", bienvenido = "";
            do 
            {
                Console.WriteLine("Menu de opciones");
                Console.WriteLine("1. Leer codigo del estudiante");
                Console.WriteLine("2. Formar una nueva carrera");
                Console.WriteLine("3. Mostrar la longitud de caracteres del codigo");
                Console.WriteLine("4. Mostrar el primero y el ultimo");
                Console.WriteLine("5. Imprimir la carrera caracter");
                Console.WriteLine("6. Crea una nueva etiqueta");
                Console.WriteLine("7. Salir del Menu");
                opcion=int.Parse(Console.ReadLine());

                switch (opcion) 
                {
                    case 1:
                        Console.WriteLine("Ingrese codigo de estudiante:");
                        codigo = Console.ReadLine();
                        Console.WriteLine("Carrera: ");
                        carrera = Console.ReadLine();
                        break;
    
                    case 2:
                        bienvenido = codigo +" | Carrera:"+ carrera;
                        Console.WriteLine("Etiqueta generada:" + bienvenido);
                        break;

                    case 3:
                        Console.WriteLine("La longitud del codigo es:" + codigo.Length);
                        Console.WriteLine("La longitud de la carrera es:" + carrera.Length);
                        Console.WriteLine("La longitud de la carrera es:" + bienvenido.Length);
                        break;

                    case 4: 
                        Console.WriteLine("El primero caracter es:" + carrera[0]);
                        Console.WriteLine("El ultimo caracter es:" + carrera[codigo.Length-1]);
                        break;
                    case 5:

                        for (int i = 0; i<carrera.Length; i++) 
                        {
                            Console.WriteLine(carrera[i]);
                        }
                        break;
                    case 7: Console.WriteLine("Ingrese nombres y apellidos");
                        string alumno = Console.ReadLine();

                        string[] partes = alumno.Split(' ');

                        string primerNombre = partes[0];
                        string iniciales = "";

                        for (int i = 0; i < partes.length; i++) 
                        {
                            iniciales += partes[i].Substring(0, 1);
                        }
                        Console.WriteLine($"{primerNombre}{iniciales}@upn.pe");     
                            ;break;
                    case 8:
                        Console.WriteLine("Saliendo....");
                        
                        break;



                        default: Console.WriteLine("opcion no valido"); break;
                }
                Console.ReadKey();
            
            
            
            
            
            }while (opcion !=7);

        }
    }
}
