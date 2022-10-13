using System;

namespace L5_OAHB_1088321
{
    class Program
    {
        static void Main(string[] args)
        {


            int num;
            Console.WriteLine("Ejercicio 1");
            Console.WriteLine("Ingrese un Número entero: ");
            num = Convert.ToInt32(Console.ReadLine());

           
                if (num < 0)
                {
                    Console.WriteLine("Número negativo");

                }
                else if (num == 0)
                {
                    Console.WriteLine("El número es cero");
                }
                else if (num > 0)
                {
                    Console.WriteLine("Número positivo");
                }
                else
                {
                    Console.WriteLine("Ingrese un número entero");
                }
            
                Console.WriteLine("Ingrese un número");
                
            
            

            Console.ReadKey();
        }
    }
}
