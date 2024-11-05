using static System.Net.Mime.MediaTypeNames;
using System.Threading;

namespace repetitivaricard8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //8.Fer un programa que vagi demanant números fins trobar el zero i ens digui el valor més gran i
            //el valor més petit.
            //Fes el mateix programa amb FI = null i dades procedents de fitxer NUMEROS.TXT.
          
            //variables

            int numero, numeroGran, numeroPetit;
            string linia;

            //entrada

            StreamReader sr = new StreamReader("NUMEROS.TXT");

            linia = sr.ReadLine();
            
            numero = Convert.ToInt32(linia);
            numeroGran = numero;
            numeroPetit = numero;

            //algorisme

            while (linia!= null)
            {
                numero = Convert.ToInt32(linia);
                if (numeroGran < numero) numeroGran = numero;
                else if (numeroPetit > numero) numeroPetit = numero;
                else
                {
                    linia = sr.ReadLine();

                }


            }

            Console.WriteLine($"El numero mes gran es : {numeroGran} i el numero petit es : {numeroPetit}");

       

    }
    }
}
