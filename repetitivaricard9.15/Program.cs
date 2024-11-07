using static System.Net.Mime.MediaTypeNames;

namespace repetitivaricard9._15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 15.Hem obtingut els resultats del Girona de la temporada 23 / 24 en un fitxer CSV.
             ● El fitxer Girona lliga23_24.txt acaba amb - 1.
             ● Cada dos files representen una jornada: la primera fila és el resultat del Girona
             (posicions senars) i la segona és del rival(posicions parells).
             ● Cal comptar els partits guanyats, perduts i empatats del Girona.
             ● Cada victòria suma 3 punts i cada empat 1 punt.
             ● Calcula el total de punts obtinguts*/

            string linia;
            int numero;
            int puntsTotals = 0;
            int guanyat = 0;
            int empatat = 0;
            int perdut = 0;
            int resultatGirona;
            int resultatRival;

            //entrada
            StreamReader sr = new StreamReader("Girona lliga23_24.txt");
            linia = sr.ReadLine();

            //algorisme

            while (linia != "-1")
            {
             
                 resultatGirona = Convert.ToInt32(linia);
                 linia = sr.ReadLine();         
                 resultatRival = Convert.ToInt32(linia);

               
                if (resultatGirona > resultatRival)
                {
                    guanyat++;
                    puntsTotals += 3; 
                }
                else if (resultatGirona == resultatRival)
                {
                    empatat++;
                    puntsTotals += 1; 
                }
                else
                {
                    perdut++; 
                }

                linia = sr.ReadLine();
            }

            sr.Close(); 

            // Sortida
            Console.WriteLine($"El girona ha guanyat: {guanyat} partits");
            Console.WriteLine($"El girona ha empatat: {empatat} partits");
            Console.WriteLine($"El girona ha perdut: {perdut} partits");
            Console.WriteLine($"El girona ha conseguit en total : {puntsTotals} punts la temporada 23/24");
        }
    }
}
