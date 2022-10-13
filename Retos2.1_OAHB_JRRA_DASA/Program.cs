using System;

namespace Retos2._1_OAHB_JRRA_DASA
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Oscar Hernández 1088321
            Diego Soto 1187921
            José Rodriguez 1087121*/

            Random Aleatorio = new Random();
            int num;
            num = Aleatorio.Next(1, 101);
            Console.WriteLine("Eliga un número entre 1 y 100");
            int ingresado = Convert.ToInt32(Console.ReadLine());

            do
            {
                Console.WriteLine("Escoga otro número");
                ingresado = Convert.ToInt32(Console.ReadLine());
                if (ingresado<num)
                {
                    Console.WriteLine("Intenta con un número más grande");
                }
                if (ingresado >num)
                {
                    Console.WriteLine("Intenta con un número más pequeño");
                }
                if (ingresado ==num)
                {
                    Console.WriteLine("Felicidades, ha adivinado el número");
                }

            } while (num != ingresado);

            Console.ReadKey();

        }

    }
}
