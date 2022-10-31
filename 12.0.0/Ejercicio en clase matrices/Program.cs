using System;

namespace Ejercicio_en_clase_matrices
{
    class Program
    {

        public static string[,] tablero = new string[3, 3];

        public static void jugar (int numJugador, int fila, int col)
        {
            string pieza = "";
            if (numJugador == 1)
            {
                pieza = "x";
            }
            else if (numJugador==2)
            {
                pieza = "O";
            }
            else
            {
                pieza = "O";
            }
            if (tablero[fila, col] == "") 
            {
                tablero[fila, col] = pieza;
            }
            else
            {
                Console.WriteLine("posición ya ocupada");

            }
        }
        //Mostrar tablero
        public static void mostrarTablero()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int c = 0; c < 3; c++)
                {
                    Console.Write(tablero[i, c] + " | ");
                }
                Console.WriteLine();
            }
        }

        public static void iniciarTablero()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int c = 0; c < 3; c++)
                {
                    tablero[i, c] = "";
                }
            }
            Console.WriteLine();
        }

        //si devuelve 1 o 2 es el jugador si devuelve 0 nadie ganó
        //evaluar vertical
        public static int evaluar()
        {
            for (int f = 0; f < 2; f++)
            {
                if (tablero[f,0]==tablero[f,1] && tablero[f, 1] == tablero[f, 2])
                {
                    if (tablero[f,0]=="x")
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
                if (tablero[0,0] == tablero[1, 1] && tablero[1, 1] == tablero[2,2])
                {
                    if (tablero [0,f] =="x")
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
            return 0;
        }
        static void Main(string[] args)
        {

            iniciarTablero();
            jugar(1, 0, 0);
            mostrarTablero();
            jugar(1, 0, 1);
            mostrarTablero();
            jugar(1, 0, 2);
            mostrarTablero();
            jugar(2, 1, 1);
            mostrarTablero();
            Console.Clear();
            jugar(2, 1, 2);
            mostrarTablero();
            int res = evaluar();
            Console.WriteLine( "El ganador es: "+res);
            Console.ReadKey();
        }

    }
}
