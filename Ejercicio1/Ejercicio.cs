using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    class Ejercicio
    {
        public delegate void MyDelegate();

        static void MenuGenerator(String[] nombreOpciones, MyDelegate[] opciones)
        {

            if (nombreOpciones.Length != opciones.Length)
            {
                Console.WriteLine("No se ha podido lanzar el menú, la cantidad de opciones no es la misma que la cantidad de casos");
                Console.WriteLine();
            }
            else
            {
                bool repetir = true;
                int opcion;

                while (repetir)
                {
                    // Muestro las opciones que haya en el array de sus nombres
                    for (int i = 0; i < nombreOpciones.Length; i++)
                    {
                        Console.WriteLine(i + 1 + " : " + nombreOpciones[i]);
                    }

                    Console.WriteLine((nombreOpciones.Length + 1) + " : Salir");
                    Console.WriteLine();

                    try
                    {
                        // Le pido al usuario que escoja una opción
                        Console.WriteLine("Qué opción escoges?");
                        opcion = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine();

                        if (opcion > 0 && opcion <= nombreOpciones.Length + 1)
                        {
                            if (opcion == nombreOpciones.Length + 1)
                            {
                                repetir = false;
                                Console.WriteLine("Pulsa Enter para salir");
                            }
                            else
                            {
                                MyDelegate caso = opciones[opcion-1];
                                caso();
                            }
                        }
                        else
                        {
                            Console.WriteLine("No existe esa opción!");
                        }
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("La opción debe ser un número!");
                        Console.WriteLine();
                    }
                }
            }

        }


        static void f1()
        {
            Console.WriteLine("A");
        }
        static void f2()
        {
            Console.WriteLine("B");
        }
        static void f3()
        {
            Console.WriteLine("C");
        }


        static void Main(string[] args)
        {
            MenuGenerator(new string[] { "Op1", "Op2", "Op3" },
            new MyDelegate[] { f1, f2, f3 });
            Console.ReadKey();
        }
    }
}
