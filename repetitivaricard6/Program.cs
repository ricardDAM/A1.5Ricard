using static System.Net.Mime.MediaTypeNames;

namespace repetitivaricard6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //6.Fer un programa que vagi demanant per teclat números fins trobar el zero i calculi la mitjana
            //dels valors introduïts.Fes el mateix programa amb FI = null i dades procedents de fitxer NUMEROS2.TXT.

            //variables
            int numero, sumaAcumulador = 0;
            int cont = 0;
            int mitjana;
            string linia;

            //entrada
            StreamReader sr = new StreamReader("NUMEROS2.TXT");

            linia = sr.ReadLine();

            //algorisme

            while (linia != null)
            {
                numero = Convert.ToInt32(linia);
                cont++;
                sumaAcumulador += numero;

                linia = sr.ReadLine();

            }

            mitjana = sumaAcumulador / cont;
            Console.WriteLine("La mitjana es " + mitjana);


        
    }
    }
}
