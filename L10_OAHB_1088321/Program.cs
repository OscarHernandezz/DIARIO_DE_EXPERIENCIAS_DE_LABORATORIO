using System;

namespace L10_OAHB_1088321
{
    class Program
    {
        static void Main(string[] args)
        {
            string usuario, contrasena;
            int contador = 0;
            bool inicio;
            while (contador < 3)
            {
                Console.WriteLine("Ingrese su nombre de usuario");
                usuario = Console.ReadLine();
                Console.WriteLine("Ingrese su contraseña");
                contrasena = Console.ReadLine();
                inicio = Login(usuario, contrasena);
                if (inicio == true)
                {
                    contador = 3;
                    Console.Clear();
                    Console.WriteLine();
                    Console.WriteLine("Inicio de sesión exitoso");
                }
                else
                {
                    contador++;
                    Console.Clear();
                    Console.WriteLine("");
                    Console.WriteLine("              Usuario o contraseña incorrectos, intente de nuevo");
                    Console.WriteLine("");
                }
            }
            Console.ReadKey();
        }

        static bool Login (string usuario, string contrasena)
        {

            if (usuario == "usuario1" && contrasena=="asdasd")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
