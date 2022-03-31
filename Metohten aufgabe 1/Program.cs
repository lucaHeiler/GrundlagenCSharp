using System;

namespace Methoden_aufgabe_1
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("geben sie ein text ein");
            string eingabe_string = Console.ReadLine();
            int anzahl = 0;
            bool flag;



            flag = false;
            Console.WriteLine("geben sie eine Zahl ein");
            try
            {




                anzahl = Convert.ToInt32(Console.ReadLine());




            }
            catch
            {
                Console.WriteLine("Fehler");
                Console.Clear();
                flag = true;

            }

            while (flag) ;

            anzahl = ausgabeTextMalX(eingabe_string, anzahl);


            Console.Write("\nAnzahlder Buchstaben: {0}", anzahl);
            static int ausgabeTextMalX(string text, int anzahl1)


                int b = 0;
                int a = 0;

            b = text.Length;
            a = anzahl1;

            a *= b;
            Console.WriteLine(a);
            for (int i = 0; i < anzahl1; i++)



                Console.WriteLine(text);


            anzahl1 = a;
            Console.WriteLine(anzahl1);
            return anzahl1;
        }

    }

}




















