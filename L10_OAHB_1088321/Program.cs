using System;

namespace L10_OAHB_1088321
{
    class Program
    {
        static void Main(string[] args)
        {
            string usuario, contrasena;
            Console.WriteLine("ingrese su usuario");
            usuario = Console.ReadLine();
            Console.WriteLine("ingrese su contraseña");
            contrasena = Console.ReadLine();

            int inicio = Login("usuario1", "asdasd");

            
            Console.ReadKey();
        }
        public static bool Login(string usuario, string contrasena)
        {
            bool inicio = false;
                int contador = 0;

            if (usuario != "usuario1" && contrasena != "asdasd")
            {
                do
                {
                    Console.WriteLine("ingrese su usuario");
                    usuario = Console.ReadLine();
                    Console.WriteLine("ingrese su contraseña");
                    contrasena = Console.ReadLine();
                    contador++;
                } while (contador < 4);
                inicio = false;
            }
            else if (usuario == "usuario1" && contrasena == "asdasd")
            {
                inicio = true;
            }
            else
            {
                Console.WriteLine("ingrese usuario y contraseña válidos");
            }
            return inicio;
        }
    }
}
