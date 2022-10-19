using System;

namespace L12_OAHB_1088321
{
    class Program
    {
        static void Main(string[] args)
        {
            Puntos pn = new Puntos();
            pn.datos();
            pn.Imprimir();
        }
        class Puntos
        {
            private int[] notas;
            public int suma = 0;
            public int promedio = 0;
            public int conteo = 0;
            public void datos()
            {
                
                notas = new int[15];
                for (int i = 0; i < 15; i++)
                {
                    if (notas[i] <= 100)
                    {
                        Console.WriteLine("Ingrese la nota");
                        string linea;
                        linea = Console.ReadLine();
                        notas[i] = int.Parse(linea);
                        suma += notas[i];
                        promedio = suma / 15;
                    }
                    else
                    {
                        Console.WriteLine("Ingrese una nota válida entre 0 y 100");
                    }
                }
            }

            public void Imprimir()
            {
                for (int i = 0; i < 15; i++)
                {
                    Console.WriteLine("La nota es: "+notas[i]);
                }
                Console.WriteLine("La suma de las notas es de: "+suma);
                Console.WriteLine("La promedio de las notas es de: " + promedio);
                Console.ReadKey();
            }
        }
    }
}
