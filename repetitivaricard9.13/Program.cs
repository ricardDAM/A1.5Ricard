using static System.Net.Mime.MediaTypeNames;
using System.Drawing;
using System.Runtime.ConstrainedExecution;
using System;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Diagnostics;

namespace repetitivaricard9._13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            /*13.Un fitxer anomenat bonus.txt conté una línia per a cada bitllet de loteria venut.
            ● Cada línia indica si el bitllet és "BONUS" o "NO BONUS".
            ● Si la línia és "BONUS", l'import associat és un enter aleatori entre 1€ i 10€.
            ● Crea un programa que processi aquest fitxer.
            ● El programa ha de comptar quants bonus s'han distribuït.
            ● També ha de calcular el total de bitllets i el percentatge de bitllets guanyadors.
            ● El fitxer acaba quan es troba un valor null.
            ● També has de calcular el total dels guanys i el nombre de bitllets amb BONUS.*/

            //variables
            string linia;
            int cont1 = 0;
            int cont2 = 0;
            int contGeneral = 0;
            int numeroDau;
            double percentatge;
            int dinersBonus = 0;
            //entrada
            StreamReader sr = new StreamReader("bonus.TXT");
            Random rand = new Random();
           
            //algorisme 
            linia = sr.ReadLine();

            while (linia != null)
            {
                if (linia == "BONUS")
                {
                    numeroDau = rand.Next(1,11);
                    dinersBonus = dinersBonus + numeroDau;
                    cont1++;
                }
                else if (linia == "NO BONUS") cont2++;

                linia = sr.ReadLine();

            
            }
            sr.Close();
            // sortida
            contGeneral = cont1 + cont2;
            percentatge = Math.Round(((double)cont1 / contGeneral),4) * 100;

            Console.WriteLine($"S'han distribuit {contGeneral} bitllets.");
            Console.WriteLine($"S'han distribuit {cont1} bonus.");
            Console.WriteLine($"El percentatge de guanyadors que hi ha respecte el total es del {percentatge} %");
            Console.WriteLine($"Ha guanyat {dinersBonus} € en total");

        }
    }
}
