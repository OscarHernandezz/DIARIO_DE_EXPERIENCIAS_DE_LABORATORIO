using System;

namespace Retos2_OAHB_JRRA_DASA
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Reto 1 Oscar Hernández 1088321
             Diego Soto 1187921
            José Rodríguez 1087121
             */
            Double suma = Program.Numero();
            Console.WriteLine("La suma de sus número será de: " +suma);

            Console.WriteLine("");

            string nombre = Program.Nombre();
            Console.WriteLine("Su nombre es: " + nombre);
        }

        static double Numero()
        {
            double num1 = 0, num2 = 0, suma = 0;
            
            Console.WriteLine("Ingrese el primer número a sumar");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo número a sumar");
            num2 = Convert.ToDouble(Console.ReadLine());

            suma = num1 + num2;
            return suma;
        }

        static string Nombre()
        {
            string nombre = "";
            Console.WriteLine("Ingrese su nombre");
            nombre = Console.ReadLine();
            return nombre;
        }
        
    }
}
