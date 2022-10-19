using System;

namespace Reto1_Semana11
{
    class Program
    {
        static void Main(string[] args)
        {
            int largo = 0;
            int[] niveles = new int[5];
            int suma = 0;
            int contador = 1, contador2 = 1;
            int mayor, nivel = 1;

            
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Ingrese la cantidad de personas en el nivel " + contador);
                contador++;
                niveles[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("");
            for (int i = 0; i < 5; i++)
            {
                if (niveles[0] > niveles[1] && niveles[0] > niveles[2] && niveles[0] > niveles[3] && niveles[0] > niveles[4])
                {
                    mayor = niveles[0];
                    nivel=1;
                }
                else if (niveles[1] > niveles[0] && niveles[1] > niveles[2] && niveles[1] > niveles[3] && niveles[1] > niveles[4] )
                {
                    mayor = niveles[1];
                    nivel=2;
                }
                else if (niveles[2] > niveles[0] && niveles[2] > niveles[1] && niveles[2] > niveles[3] && niveles[2] > niveles[4] )
                {
                    mayor = niveles[2];
                    nivel=3;
                }
                else if (niveles[3] > niveles[0] && niveles[3] > niveles[1] && niveles[3] > niveles[2] && niveles[3] > niveles[4] )
                {
                    mayor = niveles[3];
                    nivel=4;
                }
                else if (niveles[4] > niveles[0] && niveles[4] > niveles[1] && niveles[4] > niveles[2] && niveles[4] > niveles[3])
                {
                    mayor = niveles[4];
                    nivel = 5;
                }
                else
                {
                    mayor = 0;
                }
            }
            Console.WriteLine("El nivel con más personas es: " + nivel);
            Console.WriteLine("");
            for (int i = 0; i < 5; i++)
            {
                suma += niveles[i];
            }
            Console.WriteLine("La cantidad de personas totales en el edificio es de: " + suma);
            Console.ReadKey();
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("La cantidad de personas en el nivel " + contador2 +" es de: " + niveles[i]);
                contador2++;
            }
        }
    }
}
