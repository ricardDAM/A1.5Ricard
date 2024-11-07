using System.Reflection;

namespace repetitivaricard9._12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //12.Donat el fitxer alumnesDAMDAW.txt al moodle, recorre el fitxer per determinar si hi ha més
            // alumnes que es diuen Alex o més alumnes Iker…

            //variables
            string linia;
            int cont1=0;
            int cont2=0;

            //entrada
            StreamReader sr = new StreamReader("alumnesDAMDAW.TXT");

            //algorisme 
            linia = sr.ReadLine();

            while (linia != null)
            {

                if (linia == "Alex") cont1++;
                else if (linia == "Iker") cont2++;
                linia = sr.ReadLine();
            }
            sr.Close();
            // sortida
            if (cont1 == cont2) Console.WriteLine("Hi han la mateixa quantitat d'ikers i alex.");
            else if (cont1>cont2) Console.WriteLine("Hi han mes alex que ikers");
            else Console.WriteLine("Hi han mes ikers que alex.");
          
            Console.WriteLine($"A classe hi han {cont1} persones que es diguin alex i {cont2} que es diguin iker");
        }
    }
}
