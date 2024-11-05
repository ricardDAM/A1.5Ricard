using static System.Net.Mime.MediaTypeNames;

namespace repetitivaricard4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //4.Fes un programa per a saber quants valors positius i negatius hem introduït per teclat
            //Fes el mateix programa amb FI = null i dades procedents de fitxer NUMEROS.TXT
            
            //variables
            string linia;
            int numero;
            int contPositius = 0;
            int contNegatius = 0;

            //entrada
            StreamReader sr = new StreamReader("NUMEROS.TXT");

            //algorisme 
            linia = sr.ReadLine();
 
            while (linia != null )
            {
                numero = Convert.ToInt32(linia);
                if (numero > 0) contPositius++;
                else  contNegatius++;
               
                linia = sr.ReadLine();
            }
            sr.Close();
            // sortida
            Console.WriteLine($"S'ha trobat {contPositius} numeros positius i {contNegatius} numeros negatius.");
        }
    }
}
