using System;

namespace L15_OAHB_1088321
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0;
            Console.WriteLine("    Bienvenido, ingrese la opción que desee trabajar");
            Console.WriteLine("            1. Promedio de edades ");
            Console.WriteLine("            2. Promedio de notas ");
            Console.WriteLine("            3. Salir del programa");
            opcion = int.Parse(Console.ReadLine());
            Console.Clear();
            switch (opcion)
            {
                
                case 1:
                    string[] nombres = new string[5];
                    int[]edades = new int[5];
                    int[] promedio = new int[5];
                    double promeda = 0;
                    string mayor;
                    for (int i = 0; i < 5; i++)
                    {
                        Console.WriteLine("Ingrese el nombre de la persona");
                        nombres[i] = Console.ReadLine();
                        Console.WriteLine("Ingrese la edad de la persona");
                        edades[i] = int.Parse(Console.ReadLine());
                        promeda += edades[i];
                    }
                    promeda = promeda / 5;

                   if (edades[0]>edades[1] && edades[0] > edades[2] && edades[3] > edades[3] && edades[0] > edades[4])
                    {
                        mayor = nombres[0];
                    }
                    else if (edades[1] > edades[0] && edades[1] > edades[2] && edades[1] > edades[3] && edades[1] > edades[4])
                    {
                        mayor = nombres[1];
                    }
                    else if (edades[2] > edades[0] && edades[2] > edades[1] && edades[2] > edades[3] && edades[2] > edades[4])
                    {
                        mayor = nombres[2];
                    }
                    else if (edades[3] > edades[0] && edades[3] > edades[1] && edades[3] > edades[2] && edades[3] > edades[4])
                    {
                        mayor = nombres[3];
                    }
                    else
                    {
                        mayor = nombres[4];
                    }

                    Console.WriteLine("");
                    Console.WriteLine("La persona con mayor edad es: " + mayor);
                   
                    Console.WriteLine("");
                    for (int i = 0; i < 5; i++)
                    {
                        Console.WriteLine(nombres[i] + " tiene: " + edades[i] + " años");
                    }
                    Console.WriteLine("El promedio de edades es de: " + promeda);
                    break;

                case 2:
                    string []nombresn = new string[5];
                    string [] apellidos = new string[5];
                    double[] notas = new double[5];
                    double promedioNotas = 0;
                    for (int i = 0; i < 5; i++)
                    {
                        Console.WriteLine("Ingrese el nombre de la persona");
                        nombresn[i] = Console.ReadLine();
                        Console.WriteLine("Ingrese el apellido de la persona");
                        apellidos[i] = Console.ReadLine();
                        Console.WriteLine("Ingrese la nota de " + nombresn[i] + " "+apellidos[i]);
                        notas[i] = double.Parse(Console.ReadLine());
                        promedioNotas += notas[i];
                    }

                    string mayorn;

                    if (notas[0] > notas[1] && notas[0] > notas[2] && notas[0] > notas[3] && notas[0] > notas[4])
                    {
                        mayorn = nombresn[0];
                    }
                    else if (notas[1] > notas[0] && notas[1] > notas[2] && notas[1] > notas[3] && notas[1] > notas[4])
                    {
                        mayorn = nombresn[1];
                    }
                    else if (notas[2] > notas[1] && notas[2] > notas[0] && notas[2] > notas[3] && notas[2] > notas[4])
                    {
                        mayorn = nombresn[2];
                    }
                    else if (notas[3] > notas[1] && notas[3] > notas[0] && notas[3] > notas[2] && notas[3] > notas[4])
                    {
                        mayorn = nombresn[3];
                    }
                    else
                    {
                        mayorn = nombresn[4];
                    }
                   
                    string menor;
                    if (notas[0] < notas[1] && notas[0] < notas[2] && notas[0] < notas[3] && notas[0] < notas[4])
                    {
                        menor = nombresn[0];
                    }
                    else if (notas[1] < notas[0] && notas[1] < notas[2] && notas[1] < notas[3] && notas[1] < notas[4])
                    {
                        menor = nombresn[1];
                    }
                    else if (notas[2] < notas[1] && notas[2] < notas[0] && notas[2] < notas[3] && notas[2] < notas[4])
                    {
                        menor = nombresn[2];
                    }
                    else if (notas[3] < notas[1] && notas[3] < notas[0] && notas[3] < notas[2] && notas[3] < notas[4])
                    {
                        menor = nombresn[3];
                    }
                    else
                    {
                        menor = nombresn[4];
                    }

                    string[] aprovado = new string[5];
                    for (int i = 0; i < 5; i++)
                    {
                        if (notas[i] >=71)
                        {
                            aprovado[i] = "aprovado";
                        }
                        else
                        {
                            aprovado[i] = "reprobado";
                        }
                    }

                    Console.WriteLine("");
                    Console.WriteLine("La persona con mayor nota es: " + mayorn);
                    Console.WriteLine("La persona con menor nota es: " + menor);
                    Console.WriteLine("");
                    promedioNotas = promedioNotas / 5;
                    Console.WriteLine("El promedio de las notas es de: " + promedioNotas);

                    for (int i = 0; i < 5; i++)
                    {
                        Console.WriteLine(nombresn[i] + ": " +aprovado[i]);
                    }

                    break;

                case 3:
                    Environment.Exit(0);
                    break;


                default:
                    Console.WriteLine("Ingrese una opción válida de 1 a 3");
                    break;

            }

            Console.ReadKey();
        }
    }
}
