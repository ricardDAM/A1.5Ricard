
using System.IO;

namespace repetititvaricard2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //2.Fes un programa per contar quants valors enters introdueix un usuari per Consola.
            //Deixarem de contar valors en trobar el valor 0.Fes el mateix programa però agafant les dades del fitxer NUMEROS.TXT.FI = null.

            //variables
            string linia;
            int numero;
            int cont=0;

            //entrada
            StreamReader sr = new StreamReader("NUMEROS.TXT");

            //algorisme i sortida
            linia = sr.ReadLine();
           
            
            while (linia != null)
            {
                cont++;
               numero =Convert.ToInt32(linia);          
                linia= sr.ReadLine();
             
            }

            sr.Close();
            Console.WriteLine($"S'han trobat {cont} numeros");

        }
    }
}
