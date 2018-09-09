using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosLibroCSharp
{
    class Capitulo8
    {
        public void Menu()
        {
            Console.Clear();
            Program Me = new Program();
            int op = 0;
            Console.WriteLine("Eliga un ejercicio del Cap#4");
            Console.WriteLine("\n1.Ejercicio3" +
                              "\n2.Ejercicio5" +
                              "\n4.Volver al menu\n"
         );

            op = Convert.ToInt32(Console.ReadLine());

            switch (op)
            {
                case 1:
                    Console.Clear();
                    Ejercicio3();
                    Console.Clear();
                    Me.Menu();

                    break;
                case 2:
                    {
                        Console.Clear();
                        Ejercicio5();
                        Console.Clear();
                        Me.Menu();
                        break;
                    }
                case 3:
                    {
                        Console.Clear();
                        
                        Console.Clear();
                        Me.Menu();
                        break;
                    }
                case 4:
                    Console.Clear();
                    Me.Menu();
                    break;

            }
            Console.ReadKey();

        }

        public void Ejercicio3()//Hacer un programa que muestre la hora del día en formato AM/FM seguida del año, el día y el mes actual.
        {
            string hora, fecha;

            hora = DateTime.Now.ToString("h:mm:ss tt");
            fecha = DateTime.Now.ToString("yyy/dd/MM");
            Console.WriteLine("La Hora es:{0}", hora);
            Console.WriteLine("La Fecha es:{0}", fecha);
            Console.ReadKey();


        }
        public void Ejercicio5()//Hacer un programa que le solicite al usuario dos cadenas y luego las muestre en orden alfabético.
        {
            
            ArrayList cadenas = new ArrayList();

            Console.WriteLine("Digite la Cadena");
            string cad = Console.ReadLine();
            cadenas.Add(cad);
           
            Console.WriteLine("Digite la Cadena");
            string cade = Console.ReadLine();
            cadenas.Add(cade);
            cadenas.Sort();

            foreach (string caden in cadenas)
            {
                Console.WriteLine("{0}", caden);
            }
            Console.ReadKey();
        }
    
    }
}
