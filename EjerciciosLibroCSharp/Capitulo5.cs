using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosLibroCSharp
{
    class Capitulo5
    {
        public void Menu2()
        {
            Console.Clear();
            Program Me = new Program();
            int op = 0;
            Console.WriteLine("Eliga un ejercicio del cap#5");
            Console.WriteLine("\n1.Ejercicio4" +
                              "\n2.Ejercicio5" +
                              "\n4.Volver al menu\n"
         );

            op = Convert.ToInt32(Console.ReadLine());

            switch (op)
            {
                case 1:
                    Console.Clear();
                    Ejercicio4();
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
                    Console.Clear();

                    Me.Menu();
                    break;

            }
            Console.ReadKey();

        }

        public void Ejercicio4()//Hacer una función que calcule el factorial de un número.
        {
            Console.WriteLine("Digite un numero");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(factorial(num));
            Console.ReadKey();
        }

       public int factorial(int d)
        {
            if (d <=1)
                return d;
            else
                return d * factorial(d - 1);
         
        }

        /*
        public void Ejercicio4()
        {
            int n, i=0;
            int fact=0;
            Console.WriteLine("Digite un numero");
            n = Convert.ToInt32(Console.ReadLine());

            if (n >= 0)
                fact = 1;
            for (i = 1; i <=n; i++)
            {
                fact *= i;
            }
            Console.WriteLine("El Factorial de{0} = {1}",n,fact);
            Console.ReadKey();
            
        }
        */

        public void  Ejercicio5()//Hacer una función que dado un número nos regrese una cadena donde se encuentre escrito en palabras.
        {
            Console.WriteLine("Cadena de Numero Enteros ");
            Console.WriteLine("Ingrese un numero del 1 a 10");
            int num = Convert.ToInt32(Console.ReadLine());

            if(num >10 || num < 0)
            {
                Console.WriteLine("Numero{0}", num," No valido");
                Ejercicio5();
            }
            else
            {
                Cadenadepalabras(num);
            }
            Console.ReadKey();

        }

        public void Cadenadepalabras(int num)
        {
            string[] palabras = new string[] { "Cero","Uno", "Dos", "Tres", "Cuatro", "Cinco", "seis", "siete", "ocho", "Nueve", "Diez" };
            Console.WriteLine("Palabras de cadenas es:{0}", palabras[num]);
            Console.ReadKey();
        }
    }



}
