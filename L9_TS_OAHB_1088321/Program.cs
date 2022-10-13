using System;

namespace L9_TS_OAHB_1088321
{
    class Program
    {
        static void Main(string[] args)
        {
            double cambio = 0;
            Console.WriteLine("Ingrese el número de la notación de la conversión a euros que desea realizar");
            Console.WriteLine("         1. libras ");
            Console.WriteLine("         2. dolares");
            Console.WriteLine("         3. yenes ");
            cambio = double.Parse(Console.ReadLine());
            Console.ReadKey();
            ConversionMoneda(cambio);
        }
        
        static void ConversionMoneda(double cambio)
        {
            double  libra = 1.22, dolar = 0.75, yen = 0.009, camblib = 0, resultlib = 0, cambdol = 0, resultdol=0, cambyen = 0, resultyen=0;
           

            switch (cambio)
            {
                case 1:
                    Console.WriteLine("ingrese la cantidad de libras que desea cambiar a euros");
                    camblib = double.Parse(Console.ReadLine());
                    resultlib = camblib * libra;
                    Console.WriteLine("Su cambio en euros será de: " + resultlib);
                    break;

                case 2:
                    Console.WriteLine("ingrese la cantidad de dolares que desea cambiar a euros");
                    cambdol = double.Parse(Console.ReadLine());
                    resultdol = cambdol * dolar;
                    Console.WriteLine("Su cambio en euros será de: " + resultdol);
                    break;

                case 3:
                    Console.WriteLine("ingrese la cantidad de yenes que desea cambiar a euros");
                    cambyen = double.Parse(Console.ReadLine());
                    resultyen = cambyen * yen;
                    Console.WriteLine("Su cambio en euros será de: " + resultyen);
                    break;

                default:
                    Console.WriteLine("ingrese un número válido para crear su conversión");
                    break;
            }


 
        }

    }
}
