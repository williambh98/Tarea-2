using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosLibroCSharp
{
    class Capitulo7
    {
        public void Menu4()
        {
            Console.Clear();
            Program Me = new Program();
            int op = 0;
            Console.WriteLine("Eliga un ejercicio del Cap#4");
            Console.WriteLine("\n1.Ejercicio1" +
                              "\n2.Ejercicio2" +
                              "\n3.Ejercicio5" +
                              "\n4.Volver al menu\n"
         );

            op = Convert.ToInt32(Console.ReadLine());

            switch (op)
            {
                case 1:
                    Console.Clear();
                    Ejercicio1();
                    Console.Clear();
                    Me.Menu();

                    break;
                case 2:
                    {
                        Console.Clear();
                        Ejercicio2();
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

        public void Ejercicio1()//Promedio, calificación máxima y mínima en un salón de clases usando el ArrayList
        {
            int calificaciones;
            int promedio = 0, maxima = 0, minima = 0;
            string calif;
            ArrayList clase = new ArrayList();;
            Console.WriteLine("Cantidad de Estudiantes: ");
            int n =Convert.ToInt32(Console.ReadLine());
            for (int x = 0; x < n; x++)
            {
                Console.WriteLine("Digite calificaciones");
                calif = Console.ReadLine();
                calificaciones = Convert.ToInt32(calif);
                if (calificaciones == 0)
                    break;
                clase.Add(calificaciones);

            }

            foreach (int datos in clase)
            {

                promedio += datos;
                if (minima == 0)
                    minima = datos;
                if (datos > maxima)
                    maxima = datos;
                if (minima > datos)
                    minima = datos;
            }

            Console.WriteLine("Promedio:{0} ",promedio);
            Console.WriteLine("Maximo:{0} " ,maxima);
            Console.WriteLine("Menor:{0} " ,minima);
            Console.ReadKey();
        }

        public void Ejercicio2()//Hacer un programa que funcione como un diccionario, con palabra y definición, usando el Hashtable.
        {
            Hashtable Dic = new Hashtable();
            string palabras;

            Dic.Add("Lunes", "Dia de la semana");
            Dic.Add("Enero", "Mes del anos");
            Dic.Add("1998", "Anos de mi cumpleanos");

            Console.WriteLine("Palabras: Lunes, Enero y anos");
            Console.WriteLine("Eliga una palabras");
            palabras = Console.ReadLine();
            foreach (DictionaryEntry pal in Dic)
            {
                if(palabras ==(string)pal.Key)
                {
                    Console.WriteLine("La palabras definida {0} es: {1}", pal.Key, pal.Value);
                    break;
                }
            }
            Console.ReadKey();

        }

        /*
        public struct agendas
        {
            public string nom;
            public string tel;
        }

        
         public void Ejercicio5()//agenda telefónica y que guarde el nombre de la persona y su número telefónico.
        {
            ArrayList Ang = new ArrayList();
            agendas c = new agendas();

            for(int i=0; ;i++)
            {
                Console.WriteLine("Ingrese el nombre");
                c.nom = Console.ReadLine();
                Console.WriteLine("Ingrese el numero de telefono");
                c.tel = (Console.ReadLine());

                Ang.Add(c);
                break;
            }

            foreach(agendas cont in Ang)
            {
                Console.Write("Contacto:{0} {1} {2} {3}", "Nombre:", cont.nom, "Numero", cont.tel);
            }

            Console.ReadKey();

        }
        */



    }
}
