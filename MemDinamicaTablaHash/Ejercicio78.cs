using System;
using System.Collections;

namespace MemDinamicaTablaHash
{
    internal class Ejercicio78
    {
        static void Main()
        {
            Hashtable  diccio = new Hashtable();
            diccio.Add("Hello", "Hola.");
            diccio.Add("My name is Fran","Me llamo Fran,");
            diccio.Add("How is your name","¿Cómo te llamas?");

            string texto = "Hola. Me llamo Fran, ¿Cómo te llamas?";
            string[] partes = texto.Split('.', ',');

            foreach (string parte in partes)
            {
                Console.WriteLine(parte);
            }

            if (diccio.Contains("adiós"))
                Console.WriteLine(diccio["adiós"]);

            Console.ReadKey();
        }
    }
}
