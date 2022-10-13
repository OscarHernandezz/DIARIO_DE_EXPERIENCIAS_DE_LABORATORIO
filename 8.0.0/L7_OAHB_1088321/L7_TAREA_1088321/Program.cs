using System;

namespace L7_TAREA_1088321
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                /*Oscar Hernández 1088321 
           Tarea No. 7*/
                int divisor = 0, potencia = 0, contador = 1;
                double suma = 1, suma2 = 1;
                Console.WriteLine("Ingrese el número hasta el cual desea ver la secuencia");
                divisor = int.Parse(Console.ReadLine());

                for (int i = 0; i < divisor; i++)
                {
                    Console.Write("(1/" + suma + ") + ");
                    suma++;
                }

                Console.WriteLine("");
                Console.WriteLine("Ingrese el número hasta el cual desea ver la secuencia");
                potencia = int.Parse(Console.ReadLine());

                for (int i = 0; i < potencia; i++)
                {
                    suma2 = Math.Pow(2, contador);
                    Console.Write(" (1/" + suma2 + ") + ");
                    contador++;
                }

                Console.WriteLine("");
                double x = 0, k = 0, a = 0, n = 0, ope = 0;

                Console.WriteLine("Ingrese el primer número a elevar");
                x = double.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el segundo número a elevar");
                a = double.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el número al cual se elevará el dato ingresado anteriormente");
                n = double.Parse(Console.ReadLine());

                ope = ((Math.Pow(x, k)) * (Math.Pow(a, (n - k))));
                Console.WriteLine("El resultado de su operación es: " + ope);
                Console.ReadKey();
            }
            catch (Exception)
            {
                Console.WriteLine("Ingrese un número entero válido");

                Console.ReadKey();
                throw;
            }
           
        }
    }
}
