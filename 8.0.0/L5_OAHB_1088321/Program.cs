using System;

namespace L5_2_OAHB_1088321
{
    class Program
    {
        static void Main(string[] args)
        {

            int dia;
            Console.WriteLine("Ingrese el número del día de la semana");
            dia = Convert.ToInt32(Console.ReadLine());

            if ( dia == 1)
            {
                Console.WriteLine("DIA: Lunes");
            } else if (dia == 2)
            {
                Console.WriteLine("DIA: Martes");
            }
            else if (dia == 3)
            {
                Console.WriteLine("DIA: Miércoles");
            }
            else if (dia == 4)
            {
                Console.WriteLine("DIA: Jueves");
            }
            else if (dia == 5)
            {
                Console.WriteLine("DIA: Viernes");
            }
            else if (dia == 6)
            {
                Console.WriteLine("DIA: Sábado");
            }
            else if (dia == 7)
            {
                Console.WriteLine("DIA: Domingo");
            }
            else
            {
                Console.WriteLine("Error: El número ingresado debe estar contenido entre 1 y 7");
            }

            Console.ReadKey();
        }
    }
}
