using System;

namespace L7_OAHB_1088321
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                int num = 0, a = 0, b = 1, c = 1;

                Console.WriteLine("ingrese el número hasta el cual desea ver la secuencia");
                num = int.Parse(Console.ReadLine());

                Console.Clear();
                Console.WriteLine("La secuencia Fibonacci se muestra hasta la secuencia: " + num);
                Console.Write(" "+a);
                Console.Write(" "+b);
                Console.Write(" "+c);
                for (int i = 4; i <= num; i++)
                {
                    a = b;
                    b = c;
                    c = a + b;
                    Console.Write(" " + c);
                }
                Console.ReadKey();
            }
            catch (Exception)
            {
                Console.WriteLine("El dato ingresado no es un número");
                Console.ReadKey();
                
            }
            
            
        }
    }
}
