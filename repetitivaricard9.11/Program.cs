using System.Diagnostics;
using System.Security.Cryptography;

namespace repetitivaricard9._11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*11.Fes un programa per que faci el següent:
            a.Genera dos nombres entre 1 i 100 a l’atzar
            b.Ens demana el resultat de la suma, resta, producte i divisió entera
            c.Si encertem tots els resultats, el programa acaba
            d.Si fallem algun resultat, tornem a repetir des de l’apartat a) fins l’apartat d.
            e.Quan el procés acaba, ens ha d’informar de quantes iteracions han calgut
            per poder completar correctament les 4 operacions. */
          
            
            int intents = 0;
            bool encertat = false;
            int num1;
            int num2;
            int suma;
            int resta;
            int multiplicacio;
            int divisio;
            int sumaCorrecte;
            int restaCorrecte;
            int multiplicacioCorrecte;
            int divisioCorrecte;
            Random rand = new Random();

            while (!encertat)
            {
                 intents++;
                 num1 = rand.Next(1, 101);
                 num2 = rand.Next(1, 101);
                 sumaCorrecte = num1 + num2;
                 restaCorrecte = num1 - num2;
                 multiplicacioCorrecte = num1 * num2;
                 divisioCorrecte = num1 / num2;


                Console.WriteLine($"Diguem el resultat de les operacions amb els numeros random {num1} i {num2}:");

                Console.Write("Suma: ");
                 suma = Convert.ToInt32(Console.ReadLine());

                Console.Write("Resta: ");
                resta = Convert.ToInt32(Console.ReadLine());

                Console.Write("multiplicacio: ");
                 multiplicacio = Convert.ToInt32(Console.ReadLine());

                Console.Write("Divisio : ");
                 divisio = Convert.ToInt32(Console.ReadLine());

                if (suma == sumaCorrecte && resta == restaCorrecte &&
                    multiplicacio == multiplicacioCorrecte && divisio == divisioCorrecte)
                {
                    encertat = true;
                }
                else
                {
                    Console.WriteLine("Has fallat en alguna resposta intenta-ho un altre cop.");
                }
            }

            Console.WriteLine($"Has fet correctament les 4 operacions en  {intents} intents.");
        }
    }
}