using System;

namespace Proyecto_Intro_a_la_progra
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
             * Oscar Alexander Hernández Barrios 1088321
             * José Roberto Rodríguez Álvarez 1087121
             */
            int op1 = 0;
            Console.WriteLine("     ");
            Console.WriteLine("     ");
            Console.WriteLine("                    Bienvenido a su hogar       ");
            Console.WriteLine("       Ingrese su nombre");
            string nombre = Console.ReadLine();
            Console.WriteLine("      Porfavor seleccione la opción que desea manejar");
            Console.WriteLine("     ");
            Console.WriteLine("                    1. Ventilación");
            Console.WriteLine("                    2. Calefacción");
            Console.WriteLine("                    3. Iluminación");
            Console.WriteLine("                    4. Panel de control");
            op1 = int.Parse(Console.ReadLine()); //Guarda la opción que seleccione el usuario 

            switch (op1) //Se ejecutará la opción seleccionada por el usuario
            {
                case 1: //Sistema de ventilación
                    Console.Clear();
                    int humedad = 68;
                    bool ventilacion = false;
                    string muestra;
                    string horas = "13:00", horas2 = "18:00";
                    if (humedad < 70)
                    {
                        ventilacion = false;
                    }
                    else
                    {
                        ventilacion = true;
                    }
                    if (ventilacion == false )
                    {
                        muestra = "Ventilación apagada";
                    }
                    else
                    {
                        muestra = "ventilación encendida";
                    }
                    Console.WriteLine("");
                    Console.WriteLine( nombre + " las horas de ventilación programadas son: " + horas + " y " +  horas2); //Se muestran las horas predeterminadas programadas
                    Console.WriteLine("La ventilación se encuentra encendida durante una hora");

                    break;

                case 2: //Sistema de calefacción
                    Console.Clear();
                    int op2 = 0;
                    Console.WriteLine(nombre + " ingrese la habitación que desea revisar");
                    Console.WriteLine("  Habitación 1");
                    Console.WriteLine("  Habitación 2");
                    Console.WriteLine("  Habitación 3");
                    Console.WriteLine("  Habitación 4");
                    op2 = int.Parse(Console.ReadLine()); //Se guarda la habitación que el usuario desea revisar

                    switch (op2)
                    {
                        case 1:
                            double temperatura = 0;
                            int hab1 = 19;
                           
                            if (hab1<22)
                            {
                                Console.WriteLine(nombre + " la temperatura de la habitación 1 es de: " + hab1);
                                Console.WriteLine("Se encenderá la calefacción");
                            }
                            break;
                           
                        case 2:
                            int hab2 = 16;
                            if (hab2 < 22)
                            {
                                Console.WriteLine(nombre + " la temperatura de la habitación 2 es de: " + hab2);
                                Console.WriteLine("Se encenderá la calefacción");
                            }
                            break;

                        case 3:
                            int hab3 = 22;
                            if (hab3 == 22)
                            {
                                Console.WriteLine(nombre + " la temperatura de la habitación 3 es de: " + hab3);
                                Console.WriteLine("La temperatura es la adecuada");
                            }
                            break;

                        case 4:
                            int hab4 = 22;
                            if (hab4 == 22)
                            {
                                Console.WriteLine(nombre + " la temperatura de la habitación 4 es de: " + hab4);
                                Console.WriteLine("La temperatura es la adecuada");
                            }
                            break;

                        default:
                            break;
                    }

                    break;

                case 3: //Sistema de iluminación
                    Console.Clear();
                    //En caso la variable bool de cada cuarto muestre un true significa que hay una persona dentro del cuarto, si marca false significa que no hay nadie en el cuarto
                    bool ocupado1 = true;
                    bool ocupado2 = false;
                    bool ocupado3 = true;
                    bool ocupado4 = false;
                    string cuarto1, cuarto2, cuarto3, cuarto4;

                    if (ocupado1 == true)
                    {
                        
                        cuarto1 = "Luz encendida";
                    }
                    else
                    {
                        
                        cuarto1 = "Luz apagada";
                    }
                    if (ocupado2 == true)
                    {
                      
                        cuarto2 = "Luz encendida";
                    }
                    else
                    {
                        
                        cuarto2 = "Luz apagada";
                    }
                    if (ocupado3 == true)
                    {
                        cuarto3 = "Luz encendida";
                    }
                    else
                    {
                        cuarto3 = "Luz apagada";
                    }
                    if (ocupado4 == true)
                    {
                        cuarto4 = "Luz encendida";
                    }
                    else
                    {
                        cuarto4 = "Luz apagada";
                    }

                    Console.WriteLine("");
                    Console.WriteLine(nombre + " los estados de los cuartos son: ");
                    Console.WriteLine("Estado del cuarto 1: " + cuarto1);
                    Console.WriteLine("Estado del cuarto 2: " + cuarto2);
                    Console.WriteLine("Estado del cuarto 3: " + cuarto3);
                    Console.WriteLine("Estado del cuarto 4: " + cuarto4);


                    break;

                case 4: //Sistema de panel de control
                    Console.Clear();
                    int op4 = 0;
                    Console.WriteLine(nombre + " ingrese la opción que desea manejar");
                    Console.WriteLine("                             1. Ventilación");
                    Console.WriteLine("                             2. Temperaturas máximas y mínimas");
                    op4 = int.Parse(Console.ReadLine()); //Se almacena la opción que elija el usuario dentro del panel de control

                    switch (op4)
                    {
                        case 1:
                            Console.WriteLine(nombre +  " ingrese la habitación a la cual desea automatizar la ventilación");
                            Console.WriteLine("       Habitación 1");
                            Console.WriteLine("       Habitación 2"); 
                            Console.WriteLine("       Habitación 3");
                            Console.WriteLine("       Habitación 4");
                            int hab = int.Parse(Console.ReadLine());
                            switch (hab) //Se ejecutárá la habitación que el usuario haya elegido
                            {
                                //Cada habitación tendrá su opción para automatizar la ventilación, una vez se programe al final se mostrarán los datos ingresados
                                case 1:  //Habitación 1
                                    int hora1 = 0;
                                    string hora11;
                                    Console.WriteLine("Ingrese la hora a la que desea programar que el sistema de ventilación se encienda automaticamente");
                                    Console.WriteLine("Ingrese la hora en formato de 12 horas (es decir de 1 a 12)");
                                    hora1 = int.Parse(Console.ReadLine());
                                    Console.WriteLine("Ingrese si la hora es (AM) o (PM)");
                                    hora11 = Console.ReadLine();

                                    Console.WriteLine("La ventilación de la habitación 1 se encenderá a las: " + hora1 + " " + hora11);
                                    break;

                                case 2: //Habitación 2
                                    int hora2 = 0;
                                    string hora22;
                                    Console.WriteLine("Ingrese la hora a la que desea programar que el sistema de ventilación se encienda automaticamente");
                                    Console.WriteLine("Ingrese la hora en formato de 12 horas (es decir de 1 a 12)");
                                    hora2 = int.Parse(Console.ReadLine());
                                    Console.WriteLine("Ingrese si la hora es (AM) o (PM)");
                                    hora22 = Console.ReadLine();

                                    Console.WriteLine("La ventilación de la habitación 2 se encenderá a las: " + hora2 + " " + hora22);
                                    break;

                                case 3: //Habitación 3
                                    int hora3 = 0;
                                    string hora33;
                                    Console.WriteLine("Ingrese la hora a la que desea programar que el sistema de ventilación se encienda automaticamente");
                                    Console.WriteLine("Ingrese la hora en formato de 12 horas (es decir de 1 a 12)");
                                    hora3 = int.Parse(Console.ReadLine());
                                    Console.WriteLine("Ingrese si la hora es (AM) o (PM)");
                                    hora33 = Console.ReadLine();

                                    Console.WriteLine("La ventilación de la habitación 3 se encenderá a las: " + hora3 + " " + hora33);
                                    break;

                                case 4://Habitación 4
                                    int hora4 = 0;
                                    string hora44;
                                    Console.WriteLine("Ingrese la hora a la que desea programar que el sistema de ventilación se encienda automaticamente");
                                    Console.WriteLine("Ingrese la hora en formato de 12 horas (es decir de 1 a 12)");
                                    hora4 = int.Parse(Console.ReadLine());
                                    Console.WriteLine("Ingrese si la hora es (AM) o (PM)");
                                    hora44 = Console.ReadLine();

                                    Console.WriteLine("La ventilación de la habitación 4 se encenderá a las: " + hora4 + " " + hora44);
                                    break;

                                default:
                                    Console.WriteLine("Ingrese una habitación válida entre 1 y 4");
                                    break;
                            }

                            break;

                        case 2:
                            Console.Clear();
                            //Se llenarán los datos para cada habitación haceindo uso de un vector de tamaño 4 representando cada uno un cuarto
                            int[] habitacionesmax = new int[4];
                            double sumamax = 0;
                            for (int i = 0; i < 4; i++) //Se pedirán las temperaturas máximas para llenar el vector
                            {
                                Console.WriteLine("Ingrese la temperatura máxima para la habitación "+(i+1));
                                habitacionesmax[i] = int.Parse(Console.ReadLine());
                                sumamax += habitacionesmax[i]; //Se hace la suma de las 4 temperaturas obtenidas
                                
                            }

                            Console.WriteLine("");
                            int[] habitacionesmin = new int[4];
                            double sumamin = 0;
                            for (int i = 0; i < 4; i++) //Se pedirán las temperaturas mínimas para llenar el vector
                            {
                                Console.WriteLine("Ingrese la temperatura mínima para la habitación " + (i+1));
                                habitacionesmin[i] = int.Parse(Console.ReadLine());
                                sumamin += habitacionesmin[i]; //Se hace la suma de las 4 temperaturas obtenidas
                               
                            }
                            double promediomax = sumamax / 4; //Se obtiene el promedio de las temperaturas mínimas
                            Console.WriteLine(nombre + " el promedio de las temperaturas máximas es de: " + promediomax);
                            double promediomin = sumamin / 4; //Se obtiene el promedio de las temperaturas mínimas
                            Console.WriteLine(nombre + " el promedio de las temperaturas mínimas es de: " + promediomin);
                           
                            break; 

                        default: //En caso de que el usuario ingrese un número que se encuentre entre 1 y 2 se pedirá que ingrese uno correcto
                            Console.WriteLine(nombre + " Porfavor ingrese una opción válida entre 1 y 2");
                            break;
                    }
                    break;

                default: //En caso de que el usuario ingrese un número que se encuentre entre 1 y 4 se pedirá que ingrese uno correcto
                    Console.WriteLine("Ingrese una opción válida entre 1 y 4");
                    break;
            }

            Console.ReadKey();
        }
    }
}