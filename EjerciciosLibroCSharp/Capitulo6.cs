using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosLibroCSharp
{
    class Capitulo6
    {
        public void Menu3()
        {
            Console.Clear();
            Program Me = new Program();
            int op = 0;
            Console.WriteLine("Eliga un ejercicio del Cap#6");
            Console.WriteLine("\n1.Ejercicio1,2,3,4" +
                              "\n2.Ejercicio5"+
                              "\n3.Volver al menu\n"
         );

            op = Convert.ToInt32(Console.ReadLine());

            switch (op)
            {
                case 1:
                    Console.Clear();
                    Ejercicio();
                    Console.Clear();

                    break;

                case 2:
                    Console.Clear();
                    ejercicio5();
                    Me.Menu();
                    break;
                case 3:
                    Me.Menu();
                    break;
            }
            Console.ReadKey();
        
        }

        public void Ejercicio()///Ejercicio 1,2,3,4 Calcule el Promedio, maximo , minimo y Funcion.
        {
            //Variables necesarias
            int cantidad = 0; 
            int salones = 0; 
            int n = 0; 
            int m = 0; 
            string valor = " ";
            // Variables para el promedio
            float suma = 0.0f;
            float promedio = 0.0f;
            float minima = 10.0f; 
            float maxima = 0.0f; 
            // Pedimos la cantidad de salones
            Console.WriteLine("Dame la cantidad de salones");
            valor = Console.ReadLine();
            salones = Convert.ToInt32(valor);
            // Creamos el arreglo
            float[][] calif = new float[salones][];
            // Pedimos los alumnos por salon
            for (n = 0; n < salones; n++) 
            {
                Console.WriteLine("Dame la cantidad de  alumnos para el salon ");
                valor = Console.ReadLine();
                cantidad = Convert.ToInt32(valor);
                // Instanciamos el arreglo
                calif[n] = new float[cantidad];
            }
            // Capturamos la información
            for (n = 0; n < salones; n++) 
            {
                Console.WriteLine("Salon {0}", n);
                for (m = 0; m < calif[n].GetLength(0); m++) //Ciclo alumnos
                {
                    Console.Write("Dame la calificación ");
                    valor = Console.ReadLine();
                    calif[n][m] = Convert.ToSingle(valor);
                }
            }
            // Desplegamos la información
            Console.WriteLine("—— Información ——");
            for (n = 0; n < salones; n++) // Ciclo salones
            {
                Console.WriteLine("Salon {0}", n);
                for (m = 0; m < calif[n].GetLength(0); m++) // Ciclo alumnos
                {
                    Console.WriteLine("El alumno {0} tiene {1} ", m, calif[n][m]);
                }
            }

            //Encontrar el promedio
            for (n = 0; n < salones; n++) 
            {
                for (m = 0; m < cantidad; m++)
                {
                    suma += calif[n][m];

                }

            }

            promedio = suma / (cantidad * salones);

            //Encontramos la calificacion minima
            for (n = 0; n < salones; n++)
            {
                for (m = 0; m < cantidad; m++)
                {
                    if (calif[n][m] < minima)
                    {
                        minima = calif[n][m];
                    }
                }

            }

            //Encontramos la maxima calificacion
            for (n = 0; n < salones; n++)
            {
                for (m = 0; m < cantidad; m++)
                {
                    if (calif[n][m] > maxima)
                    {
                        maxima = calif[n][m];
                    }
                }

            }

            Console.WriteLine("El Promedio es {0}", promedio);
            Console.WriteLine("La calificacion minima es {0}", minima);
            Console.WriteLine("La calificacion maxima es {0}", maxima);
            Console.ReadKey();
        }

        public void ejercicio5()//Un programa que pase un arreglo jagged como parámetro a una función.
        {
            int[] numeros = new int[6];
            int num = 0;
            for(num= 0; num < 6; num++)
            {
                Console.WriteLine("Digite un numero");
                numeros[num] = Convert.ToInt32(Console.ReadLine());
            }

            ArregloFuncion(numeros);
        }

        public void ArregloFuncion(int[] arreglo)
        {
            int num = 0;
            for(num=0;num < 5; num++)
            {
                Console.WriteLine("El numero del arreglo es{0}:", arreglo[num]);
                Console.ReadLine();
            }

        }
    }
}
