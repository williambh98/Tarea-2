using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosLibroCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Program me = new Program();
            me.Menu();
        }

        public void Menu()
        {
            Capitulo5 Cap5 = new Capitulo5();
            Capitulo6 Cap6 = new Capitulo6();
            Capitulo7 Cap7 = new Capitulo7();
;            Capitulo8 Cap8 = new Capitulo8();
            int op = 0;
            //Menu

            Console.WriteLine("Eliga una opcion para ver lo ejercicio del capitulo \n" +
                "\n1.Capitulo5" +
                "\n2.Capitulo6" +
                "\n3.Capitulo7" +
                "\n4.Capitulo8" +
                "\n5.Salir\n");

            op = Convert.ToInt32(Console.ReadLine());

            switch (op)
            {
                case 1:
                    Cap5.Menu2();
                    break;

                case 2:
                    Cap6.Menu3();
                    break;

                case 3:
                    Cap7.Menu4();
                    break;
                case 4:
                    Cap8.Menu();

                    break;
                case 5:
                    Console.WriteLine("Opcion salir\n" +
                        "Preciones Cual Quier tecla para salir");
                    break;
                default:
                    Console.WriteLine("Opcion no valida");
                    break;


            }

            Console.ReadKey();


        }
    }
}
