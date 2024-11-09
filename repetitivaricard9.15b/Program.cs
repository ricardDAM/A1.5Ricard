namespace repetitivaricard9._15b
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 15.Hem obtingut els resultats del Girona de la temporada 23 / 24 en un fitxer CSV.
             ● El fitxer Girona lliga23_24.txt acaba amb null.
             ● Cada dos files representen una jornada: de manera que el girona jugui 1 vegada afora i un altre de local (15.b)
             ● Cal comptar els partits guanyats, perduts i empatats del Girona.
             ● Cada victòria suma 3 punts i cada empat 1 punt.
             ● Calcula el total de punts obtinguts*/


            //variables
            string linia;
            int puntsTotals = 0;
            int guanyat = 0;
            int empatat = 0;
            int perdut = 0;
            int girona;
            int rival = 0;
            int cont = 0;

            //entrada
            StreamReader sr = new StreamReader("Girona lliga23_24.txt");
            linia = sr.ReadLine();

            //algorisme
            while (linia  != null)
            {
                if (cont % 2 == 0) 
                {
                  
                    rival = Convert.ToInt32(linia);
                    linia = sr.ReadLine();
                    girona = Convert.ToInt32(linia);
                    if (girona > rival)
                    {
                        guanyat++;
                        puntsTotals += 3;
                    }
                    else if (girona == rival)
                    {
                        empatat++;
                        puntsTotals += 1;
                    }
                    else
                    {
                        perdut++;
                    }

                    cont++;
                    linia = sr.ReadLine();

                }
            
                else 
                {
                    girona = Convert.ToInt32(linia);
                    linia = sr.ReadLine();
                    rival = Convert.ToInt32(linia);
                if (girona > rival)
                {
                    guanyat++;
                    puntsTotals += 3;
                }
                else if (girona == rival)
                {
                    empatat++;
                    puntsTotals += 1;
                }
                else
                {
                    perdut++;
                }

                cont++;
                linia = sr.ReadLine();

            }
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
