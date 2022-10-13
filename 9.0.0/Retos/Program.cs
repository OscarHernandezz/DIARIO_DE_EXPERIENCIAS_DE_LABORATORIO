using System;

namespace Retos
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Oscar Hernández 1088321
             José Rodríguez 1087121
             Diego Soto 1187921
             */

            //Reto 1
            string a = "On the", b = " day of christmas", c = ", my true love sent to me", d = "Three french hends", e = "Six geese a-laying";
            string f = "A partridge in a pear tree ", g = "Four calling birds", h = "Two turtles doves", i = "Five golden rings", j = "Seven swans a-swimming";
            string k = "Eight maids a-milking", l = "Nine ladies dancing", m = "Ten lords a-leaping", n = "Eleven pipers pipping", o = "Twelve Drummers drumming ";
            string uno = " first", dos = " second", tres = " third", cuatro = " forth", cinco = " fifth", seis = " sixth", siete = " seventh", ocho = " eighth", nueve = " ninth";
            string diez = " tenth", once = " eleventh", doce = " twelfht";

            Console.WriteLine("Reto 1");
            Console.WriteLine(a + uno + b + c);
            Console.WriteLine(f);
            Console.WriteLine("");
            Console.WriteLine(a + dos + b + c);
            Console.WriteLine(h);
            Console.WriteLine(f);
            Console.WriteLine("");
            Console.WriteLine(a + tres + b + c);
            Console.WriteLine(d);
            Console.WriteLine(h);
            Console.WriteLine(f);
            Console.WriteLine("");
            Console.WriteLine(a + cuatro + b + c);
            Console.WriteLine(g);
            Console.WriteLine(d);
            Console.WriteLine(h);
            Console.WriteLine(f);
            Console.WriteLine("");
            Console.WriteLine(a + cinco + b + c);
            Console.WriteLine(i);
            Console.WriteLine(g);
            Console.WriteLine(d);
            Console.WriteLine(h);
            Console.WriteLine(f);
            Console.WriteLine("");
            Console.WriteLine(a + seis + b + c);
            Console.WriteLine(e);
            Console.WriteLine(i);
            Console.WriteLine(g);
            Console.WriteLine(d);
            Console.WriteLine(h);
            Console.WriteLine(f);
            Console.WriteLine("");
            Console.WriteLine(a + siete + b + c);
            Console.WriteLine(j);
            Console.WriteLine(e);
            Console.WriteLine(i);
            Console.WriteLine(g);
            Console.WriteLine(d);
            Console.WriteLine(h);
            Console.WriteLine(f);
            Console.WriteLine("");
            Console.WriteLine(a + ocho + b + c);
            Console.WriteLine(k);
            Console.WriteLine(j);
            Console.WriteLine(e);
            Console.WriteLine(i);
            Console.WriteLine(g);
            Console.WriteLine(d);
            Console.WriteLine(h);
            Console.WriteLine(f);
            Console.WriteLine("");
            Console.WriteLine(a + nueve + b + c);
            Console.WriteLine(l);
            Console.WriteLine(k);
            Console.WriteLine(j);
            Console.WriteLine(e);
            Console.WriteLine(i);
            Console.WriteLine(g);
            Console.WriteLine(d);
            Console.WriteLine(h);
            Console.WriteLine(f);
            Console.WriteLine("");
            Console.WriteLine(a + diez + b + c);
            Console.WriteLine(m);
            Console.WriteLine(l);
            Console.WriteLine(k);
            Console.WriteLine(j);
            Console.WriteLine(e);
            Console.WriteLine(i);
            Console.WriteLine(g);
            Console.WriteLine(d);
            Console.WriteLine(h);
            Console.WriteLine(f);
            Console.WriteLine("");
            Console.WriteLine(a + once + b + c);
            Console.WriteLine(n);
            Console.WriteLine(m);
            Console.WriteLine(l);
            Console.WriteLine(k);
            Console.WriteLine(j);
            Console.WriteLine(e);
            Console.WriteLine(i);
            Console.WriteLine(g);
            Console.WriteLine(d);
            Console.WriteLine(h);
            Console.WriteLine(f);
            Console.WriteLine("");
            Console.WriteLine(a + doce + b + c);
            Console.WriteLine(o);
            Console.WriteLine(n);
            Console.WriteLine(m);
            Console.WriteLine(l);
            Console.WriteLine(k);
            Console.WriteLine(j);
            Console.WriteLine(e);
            Console.WriteLine(i);
            Console.WriteLine(g);
            Console.WriteLine(d);
            Console.WriteLine(h);
            Console.WriteLine(f);
            Console.WriteLine("");
            Console.WriteLine("");


            //Reto 2
            Console.WriteLine("Reto 2");
            int num = 0;
            Console.WriteLine("Ingrese el número de estrofa hasta el cual desea ver la canción");
            num = int.Parse(Console.ReadLine());

            if (num == 1)
            {
                Console.WriteLine(a + uno + b + c);
                Console.WriteLine(f);
            }
            else if (num == 2)
            {

                Console.WriteLine(a + dos + b + c);
                Console.WriteLine(h);
                Console.WriteLine(f);
                Console.WriteLine("");
            }
            else if (num == 3)
            {
                Console.WriteLine(a + uno + b + c);
                Console.WriteLine(f);
                Console.WriteLine("");
                Console.WriteLine(a + dos + b + c);
                Console.WriteLine(h);
                Console.WriteLine(f);
                Console.WriteLine("");
                Console.WriteLine(a + tres + b + c);
                Console.WriteLine(d);
                Console.WriteLine(h);
                Console.WriteLine(f);
                Console.WriteLine("");
            }
            else if (num == 4)
            {
                Console.WriteLine(a + uno + b + c);
                Console.WriteLine(f);
                Console.WriteLine("");
                Console.WriteLine(a + dos + b + c);
                Console.WriteLine(h);
                Console.WriteLine(f);
                Console.WriteLine("");
                Console.WriteLine(a + tres + b + c);
                Console.WriteLine(d);
                Console.WriteLine(h);
                Console.WriteLine(f);
                Console.WriteLine("");
                Console.WriteLine(a + cuatro + b + c);
                Console.WriteLine(g);
                Console.WriteLine(d);
                Console.WriteLine(h);
                Console.WriteLine(f);
            }
            else if (num == 5)
            {
                Console.WriteLine(a + uno + b + c);
                Console.WriteLine(f);
                Console.WriteLine("");
                Console.WriteLine(a + dos + b + c);
                Console.WriteLine(h);
                Console.WriteLine(f);
                Console.WriteLine("");
                Console.WriteLine(a + tres + b + c);
                Console.WriteLine(d);
                Console.WriteLine(h);
                Console.WriteLine(f);
                Console.WriteLine("");
                Console.WriteLine(a + cuatro + b + c);
                Console.WriteLine(g);
                Console.WriteLine(d);
                Console.WriteLine(h);
                Console.WriteLine(f);
                Console.WriteLine("");
                Console.WriteLine(a + cinco + b + c);
                Console.WriteLine(i);
                Console.WriteLine(g);
                Console.WriteLine(d);
                Console.WriteLine(h);
                Console.WriteLine(f);
                Console.WriteLine("");
            }
            else if (num == 6)
            {
                Console.WriteLine(a + uno + b + c);
                Console.WriteLine(f);
                Console.WriteLine("");
                Console.WriteLine(a + dos + b + c);
                Console.WriteLine(h);
                Console.WriteLine(f);
                Console.WriteLine("");
                Console.WriteLine(a + tres + b + c);
                Console.WriteLine(d);
                Console.WriteLine(h);
                Console.WriteLine(f);
                Console.WriteLine("");
                Console.WriteLine(a + cuatro + b + c);
                Console.WriteLine(g);
                Console.WriteLine(d);
                Console.WriteLine(h);
                Console.WriteLine(f);
                Console.WriteLine("");
                Console.WriteLine(a + cinco + b + c);
                Console.WriteLine(i);
                Console.WriteLine(g);
                Console.WriteLine(d);
                Console.WriteLine(h);
                Console.WriteLine(f);
                Console.WriteLine("");
                Console.WriteLine(a + seis + b + c);
                Console.WriteLine(e);
                Console.WriteLine(i);
                Console.WriteLine(g);
                Console.WriteLine(d);
                Console.WriteLine(h);
                Console.WriteLine(f);
                Console.WriteLine("");
            }
            else if (num == 7)
            {
                Console.WriteLine(a + uno + b + c);
                Console.WriteLine(f);
                Console.WriteLine("");
                Console.WriteLine(a + dos + b + c);
                Console.WriteLine(h);
                Console.WriteLine(f);
                Console.WriteLine("");
                Console.WriteLine(a + tres + b + c);
                Console.WriteLine(d);
                Console.WriteLine(h);
                Console.WriteLine(f);
                Console.WriteLine("");
                Console.WriteLine(a + cuatro + b + c);
                Console.WriteLine(g);
                Console.WriteLine(d);
                Console.WriteLine(h);
                Console.WriteLine(f);
                Console.WriteLine("");
                Console.WriteLine(a + cinco + b + c);
                Console.WriteLine(i);
                Console.WriteLine(g);
                Console.WriteLine(d);
                Console.WriteLine(h);
                Console.WriteLine(f);
                Console.WriteLine("");
                Console.WriteLine(a + seis + b + c);
                Console.WriteLine(e);
                Console.WriteLine(i);
                Console.WriteLine(g);
                Console.WriteLine(d);
                Console.WriteLine(h);
                Console.WriteLine(f);
                Console.WriteLine("");
                Console.WriteLine(a + siete + b + c);
                Console.WriteLine(j);
                Console.WriteLine(e);
                Console.WriteLine(i);
                Console.WriteLine(g);
                Console.WriteLine(d);
                Console.WriteLine(h);
                Console.WriteLine(f);
                Console.WriteLine("");
            }
            else if (num == 8)
            {
                Console.WriteLine(a + uno + b + c);
                Console.WriteLine(f);
                Console.WriteLine("");
                Console.WriteLine(a + dos + b + c);
                Console.WriteLine(h);
                Console.WriteLine(f);
                Console.WriteLine("");
                Console.WriteLine(a + tres + b + c);
                Console.WriteLine(d);
                Console.WriteLine(h);
                Console.WriteLine(f);
                Console.WriteLine("");
                Console.WriteLine(a + cuatro + b + c);
                Console.WriteLine(g);
                Console.WriteLine(d);
                Console.WriteLine(h);
                Console.WriteLine(f);
                Console.WriteLine("");
                Console.WriteLine(a + cinco + b + c);
                Console.WriteLine(i);
                Console.WriteLine(g);
                Console.WriteLine(d);
                Console.WriteLine(h);
                Console.WriteLine(f);
                Console.WriteLine("");
                Console.WriteLine(a + seis + b + c);
                Console.WriteLine(e);
                Console.WriteLine(i);
                Console.WriteLine(g);
                Console.WriteLine(d);
                Console.WriteLine(h);
                Console.WriteLine(f);
                Console.WriteLine("");
                Console.WriteLine(a + siete + b + c);
                Console.WriteLine(j);
                Console.WriteLine(e);
                Console.WriteLine(i);
                Console.WriteLine(g);
                Console.WriteLine(d);
                Console.WriteLine(h);
                Console.WriteLine(f);
                Console.WriteLine("");
                Console.WriteLine(a + ocho + b + c);
                Console.WriteLine(k);
                Console.WriteLine(j);
                Console.WriteLine(e);
                Console.WriteLine(i);
                Console.WriteLine(g);
                Console.WriteLine(d);
                Console.WriteLine(h);
                Console.WriteLine(f);
                Console.WriteLine("");
            }
            else if (num == 9)
            {
                Console.WriteLine(a + uno + b + c);
                Console.WriteLine(f);
                Console.WriteLine("");
                Console.WriteLine(a + dos + b + c);
                Console.WriteLine(h);
                Console.WriteLine(f);
                Console.WriteLine("");
                Console.WriteLine(a + tres + b + c);
                Console.WriteLine(d);
                Console.WriteLine(h);
                Console.WriteLine(f);
                Console.WriteLine("");
                Console.WriteLine(a + cuatro + b + c);
                Console.WriteLine(g);
                Console.WriteLine(d);
                Console.WriteLine(h);
                Console.WriteLine(f);
                Console.WriteLine("");
                Console.WriteLine(a + cinco + b + c);
                Console.WriteLine(i);
                Console.WriteLine(g);
                Console.WriteLine(d);
                Console.WriteLine(h);
                Console.WriteLine(f);
                Console.WriteLine("");
                Console.WriteLine(a + seis + b + c);
                Console.WriteLine(e);
                Console.WriteLine(i);
                Console.WriteLine(g);
                Console.WriteLine(d);
                Console.WriteLine(h);
                Console.WriteLine(f);
                Console.WriteLine("");
                Console.WriteLine(a + siete + b + c);
                Console.WriteLine(j);
                Console.WriteLine(e);
                Console.WriteLine(i);
                Console.WriteLine(g);
                Console.WriteLine(d);
                Console.WriteLine(h);
                Console.WriteLine(f);
                Console.WriteLine("");
                Console.WriteLine(a + ocho + b + c);
                Console.WriteLine(k);
                Console.WriteLine(j);
                Console.WriteLine(e);
                Console.WriteLine(i);
                Console.WriteLine(g);
                Console.WriteLine(d);
                Console.WriteLine(h);
                Console.WriteLine(f);
                Console.WriteLine("");
                Console.WriteLine(a + nueve + b + c);
                Console.WriteLine(l);
                Console.WriteLine(k);
                Console.WriteLine(j);
                Console.WriteLine(e);
                Console.WriteLine(i);
                Console.WriteLine(g);
                Console.WriteLine(d);
                Console.WriteLine(h);
                Console.WriteLine(f);
                Console.WriteLine("");
            }
            else if (num == 10)
            {
                Console.WriteLine(a + uno + b + c);
                Console.WriteLine(f);
                Console.WriteLine("");
                Console.WriteLine(a + dos + b + c);
                Console.WriteLine(h);
                Console.WriteLine(f);
                Console.WriteLine("");
                Console.WriteLine(a + tres + b + c);
                Console.WriteLine(d);
                Console.WriteLine(h);
                Console.WriteLine(f);
                Console.WriteLine("");
                Console.WriteLine(a + cuatro + b + c);
                Console.WriteLine(g);
                Console.WriteLine(d);
                Console.WriteLine(h);
                Console.WriteLine(f);
                Console.WriteLine("");
                Console.WriteLine(a + cinco + b + c);
                Console.WriteLine(i);
                Console.WriteLine(g);
                Console.WriteLine(d);
                Console.WriteLine(h);
                Console.WriteLine(f);
                Console.WriteLine("");
                Console.WriteLine(a + seis + b + c);
                Console.WriteLine(e);
                Console.WriteLine(i);
                Console.WriteLine(g);
                Console.WriteLine(d);
                Console.WriteLine(h);
                Console.WriteLine(f);
                Console.WriteLine("");
                Console.WriteLine(a + siete + b + c);
                Console.WriteLine(j);
                Console.WriteLine(e);
                Console.WriteLine(i);
                Console.WriteLine(g);
                Console.WriteLine(d);
                Console.WriteLine(h);
                Console.WriteLine(f);
                Console.WriteLine("");
                Console.WriteLine(a + ocho + b + c);
                Console.WriteLine(k);
                Console.WriteLine(j);
                Console.WriteLine(e);
                Console.WriteLine(i);
                Console.WriteLine(g);
                Console.WriteLine(d);
                Console.WriteLine(h);
                Console.WriteLine(f);
                Console.WriteLine("");
                Console.WriteLine(a + nueve + b + c);
                Console.WriteLine(l);
                Console.WriteLine(k);
                Console.WriteLine(j);
                Console.WriteLine(e);
                Console.WriteLine(i);
                Console.WriteLine(g);
                Console.WriteLine(d);
                Console.WriteLine(h);
                Console.WriteLine(f);
                Console.WriteLine("");
                Console.WriteLine(a + diez + b + c);
                Console.WriteLine(m);
                Console.WriteLine(l);
                Console.WriteLine(k);
                Console.WriteLine(j);
                Console.WriteLine(e);
                Console.WriteLine(i);
                Console.WriteLine(g);
                Console.WriteLine(d);
                Console.WriteLine(h);
                Console.WriteLine(f);
                Console.WriteLine("");
            }
            else if (num == 11)
            {
                Console.WriteLine(a + uno + b + c);
                Console.WriteLine(f);
                Console.WriteLine("");
                Console.WriteLine(a + dos + b + c);
                Console.WriteLine(h);
                Console.WriteLine(f);
                Console.WriteLine("");
                Console.WriteLine(a + tres + b + c);
                Console.WriteLine(d);
                Console.WriteLine(h);
                Console.WriteLine(f);
                Console.WriteLine("");
                Console.WriteLine(a + cuatro + b + c);
                Console.WriteLine(g);
                Console.WriteLine(d);
                Console.WriteLine(h);
                Console.WriteLine(f);
                Console.WriteLine("");
                Console.WriteLine(a + cinco + b + c);
                Console.WriteLine(i);
                Console.WriteLine(g);
                Console.WriteLine(d);
                Console.WriteLine(h);
                Console.WriteLine(f);
                Console.WriteLine("");
                Console.WriteLine(a + seis + b + c);
                Console.WriteLine(e);
                Console.WriteLine(i);
                Console.WriteLine(g);
                Console.WriteLine(d);
                Console.WriteLine(h);
                Console.WriteLine(f);
                Console.WriteLine("");
                Console.WriteLine(a + siete + b + c);
                Console.WriteLine(j);
                Console.WriteLine(e);
                Console.WriteLine(i);
                Console.WriteLine(g);
                Console.WriteLine(d);
                Console.WriteLine(h);
                Console.WriteLine(f);
                Console.WriteLine("");
                Console.WriteLine(a + ocho + b + c);
                Console.WriteLine(k);
                Console.WriteLine(j);
                Console.WriteLine(e);
                Console.WriteLine(i);
                Console.WriteLine(g);
                Console.WriteLine(d);
                Console.WriteLine(h);
                Console.WriteLine(f);
                Console.WriteLine("");
                Console.WriteLine(a + nueve + b + c);
                Console.WriteLine(l);
                Console.WriteLine(k);
                Console.WriteLine(j);
                Console.WriteLine(e);
                Console.WriteLine(i);
                Console.WriteLine(g);
                Console.WriteLine(d);
                Console.WriteLine(h);
                Console.WriteLine(f);
                Console.WriteLine("");
                Console.WriteLine(a + diez + b + c);
                Console.WriteLine(m);
                Console.WriteLine(l);
                Console.WriteLine(k);
                Console.WriteLine(j);
                Console.WriteLine(e);
                Console.WriteLine(i);
                Console.WriteLine(g);
                Console.WriteLine(d);
                Console.WriteLine(h);
                Console.WriteLine(f);
                Console.WriteLine("");
                Console.WriteLine(a + once + b + c);
                Console.WriteLine(n);
                Console.WriteLine(m);
                Console.WriteLine(l);
                Console.WriteLine(k);
                Console.WriteLine(j);
                Console.WriteLine(e);
                Console.WriteLine(i);
                Console.WriteLine(g);
                Console.WriteLine(d);
                Console.WriteLine(h);
                Console.WriteLine(f);
                Console.WriteLine("");
            }
            else if (num == 12)
            {
                Console.WriteLine(a + uno + b + c);
                Console.WriteLine(f);
                Console.WriteLine("");
                Console.WriteLine(a + dos + b + c);
                Console.WriteLine(h);
                Console.WriteLine(f);
                Console.WriteLine("");
                Console.WriteLine(a + tres + b + c);
                Console.WriteLine(d);
                Console.WriteLine(h);
                Console.WriteLine(f);
                Console.WriteLine("");
                Console.WriteLine(a + cuatro + b + c);
                Console.WriteLine(g);
                Console.WriteLine(d);
                Console.WriteLine(h);
                Console.WriteLine(f);
                Console.WriteLine("");
                Console.WriteLine(a + cinco + b + c);
                Console.WriteLine(i);
                Console.WriteLine(g);
                Console.WriteLine(d);
                Console.WriteLine(h);
                Console.WriteLine(f);
                Console.WriteLine("");
                Console.WriteLine(a + seis + b + c);
                Console.WriteLine(e);
                Console.WriteLine(i);
                Console.WriteLine(g);
                Console.WriteLine(d);
                Console.WriteLine(h);
                Console.WriteLine(f);
                Console.WriteLine("");
                Console.WriteLine(a + siete + b + c);
                Console.WriteLine(j);
                Console.WriteLine(e);
                Console.WriteLine(i);
                Console.WriteLine(g);
                Console.WriteLine(d);
                Console.WriteLine(h);
                Console.WriteLine(f);
                Console.WriteLine("");
                Console.WriteLine(a + ocho + b + c);
                Console.WriteLine(k);
                Console.WriteLine(j);
                Console.WriteLine(e);
                Console.WriteLine(i);
                Console.WriteLine(g);
                Console.WriteLine(d);
                Console.WriteLine(h);
                Console.WriteLine(f);
                Console.WriteLine("");
                Console.WriteLine(a + nueve + b + c);
                Console.WriteLine(l);
                Console.WriteLine(k);
                Console.WriteLine(j);
                Console.WriteLine(e);
                Console.WriteLine(i);
                Console.WriteLine(g);
                Console.WriteLine(d);
                Console.WriteLine(h);
                Console.WriteLine(f);
                Console.WriteLine("");
                Console.WriteLine(a + diez + b + c);
                Console.WriteLine(m);
                Console.WriteLine(l);
                Console.WriteLine(k);
                Console.WriteLine(j);
                Console.WriteLine(e);
                Console.WriteLine(i);
                Console.WriteLine(g);
                Console.WriteLine(d);
                Console.WriteLine(h);
                Console.WriteLine(f);
                Console.WriteLine("");
                Console.WriteLine(a + once + b + c);
                Console.WriteLine(n);
                Console.WriteLine(m);
                Console.WriteLine(l);
                Console.WriteLine(k);
                Console.WriteLine(j);
                Console.WriteLine(e);
                Console.WriteLine(i);
                Console.WriteLine(g);
                Console.WriteLine(d);
                Console.WriteLine(h);
                Console.WriteLine(f);
                Console.WriteLine("");
                Console.WriteLine(a + doce + b + c);
                Console.WriteLine(o);
                Console.WriteLine(n);
                Console.WriteLine(m);
                Console.WriteLine(l);
                Console.WriteLine(k);
                Console.WriteLine(j);
                Console.WriteLine(e);
                Console.WriteLine(i);
                Console.WriteLine(g);
                Console.WriteLine(d);
                Console.WriteLine(h);
                Console.WriteLine(f);
                Console.WriteLine("");
            }
            else
            {
                Console.WriteLine("");
            }


            //Reto 3
            Console.WriteLine("Reto 3");
            Console.WriteLine("");

            int cal = 0;
            Console.WriteLine("Ingrese el número de estrofa que desea ver");
            cal = int.Parse(Console.ReadLine());

            if (cal == 1)
            {
                Console.WriteLine(a + uno + b + c);
                Console.WriteLine(f);
            }
            else if (cal == 2)
            {
                Console.WriteLine(a + dos + b + c);
                Console.WriteLine(h);
                Console.WriteLine(f);
                Console.WriteLine("");
            }
            else if (cal == 3)
            {
                Console.WriteLine(a + tres + b + c);
                Console.WriteLine(d);
                Console.WriteLine(h);
                Console.WriteLine(f);
                Console.WriteLine("");
            }
            else if (cal == 4)
            {
                Console.WriteLine(a + cinco + b + c);
                Console.WriteLine(g);
                Console.WriteLine(d);
                Console.WriteLine(h);
                Console.WriteLine(f);
                Console.WriteLine("");
            }
            else if (cal == 5)
            {
                Console.WriteLine(a + cinco + b + c);
                Console.WriteLine(i);
                Console.WriteLine(g);
                Console.WriteLine(d);
                Console.WriteLine(h);
                Console.WriteLine(f);
                Console.WriteLine("");
            }
            else if (cal == 6)
            {
                Console.WriteLine(a + seis + b + c);
                Console.WriteLine(e);
                Console.WriteLine(i);
                Console.WriteLine(g);
                Console.WriteLine(d);
                Console.WriteLine(h);
                Console.WriteLine(f);
                Console.WriteLine("");
            }
            else if (cal == 7)
            {
                Console.WriteLine(a + siete + b + c);
                Console.WriteLine(j);
                Console.WriteLine(e);
                Console.WriteLine(i);
                Console.WriteLine(g);
                Console.WriteLine(d);
                Console.WriteLine(h);
                Console.WriteLine(f);
                Console.WriteLine("");
            }
            else if (cal == 8)
            {
                Console.WriteLine(a + ocho + b + c);
                Console.WriteLine(k);
                Console.WriteLine(j);
                Console.WriteLine(e);
                Console.WriteLine(i);
                Console.WriteLine(g);
                Console.WriteLine(d);
                Console.WriteLine(h);
                Console.WriteLine(f);
                Console.WriteLine("");
            }
            else if (cal == 9)
            {
                Console.WriteLine(a + nueve + b + c);
                Console.WriteLine(l);
                Console.WriteLine(k);
                Console.WriteLine(j);
                Console.WriteLine(e);
                Console.WriteLine(i);
                Console.WriteLine(g);
                Console.WriteLine(d);
                Console.WriteLine(h);
                Console.WriteLine(f);
                Console.WriteLine("");
            }
            else if (cal == 10)
            {
                Console.WriteLine(a + diez + b + c);
                Console.WriteLine(m);
                Console.WriteLine(l);
                Console.WriteLine(k);
                Console.WriteLine(j);
                Console.WriteLine(e);
                Console.WriteLine(i);
                Console.WriteLine(g);
                Console.WriteLine(d);
                Console.WriteLine(h);
                Console.WriteLine(f);
                Console.WriteLine("");
            }
            else if (cal == 11)
            {
                Console.WriteLine(a + once + b + c);
                Console.WriteLine(n);
                Console.WriteLine(m);
                Console.WriteLine(l);
                Console.WriteLine(k);
                Console.WriteLine(j);
                Console.WriteLine(e);
                Console.WriteLine(i);
                Console.WriteLine(g);
                Console.WriteLine(d);
                Console.WriteLine(h);
                Console.WriteLine(f);
                Console.WriteLine("");
            }
            else if (cal == 12)
            {
                Console.WriteLine(a + doce + b + c);
                Console.WriteLine(o);
                Console.WriteLine(n);
                Console.WriteLine(m);
                Console.WriteLine(l);
                Console.WriteLine(k);
                Console.WriteLine(j);
                Console.WriteLine(e);
                Console.WriteLine(i);
                Console.WriteLine(g);
                Console.WriteLine(d);
                Console.WriteLine(h);
                Console.WriteLine(f);
                Console.WriteLine("");
            }

            Console.ReadKey();
        }
    }
}
