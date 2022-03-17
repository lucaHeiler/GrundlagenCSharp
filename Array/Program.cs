using System;

namespace Array
{
    class Program
    {
        static void Main()
        {



            //Aufgabe 1 
           



            
           string[] namen = new string[3];

            
            namen[0] = "luca";
            namen[1] = "daniel";
            namen[2] = "tobi";

               
            int[] daten = new int[10];      //Platz im Speicher in Form von Array (int) reserviert


            daten[0] = 19;
            daten[1] = 17;
            daten[2] = 13;

            //Anzahl der Elmente in einem Array kann über deren Eigenschaft "Length" abgerufen werden

            for (int index = 3; index < daten.Length; index++)
            {
                daten[index] = index * 10;
            }

            foreach (int zeug in daten)
            {
                Console.Write($"{zeug}\t");

            }
            foreach (string element in namen)
            {

                Console.Write($"{element}\t");

            }

        }



    }
}