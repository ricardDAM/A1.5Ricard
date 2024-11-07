using System.Diagnostics;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace repetitivaricard9._14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            /*14.Considerem el fitxer BONUS2.TXT per al càlcul del BONUS.
            ● Quan apareix la paraula "BONUS", a continuació hi ha la quantitat guanyada a la
            següent línia.
            ● Si es troba "NO BONUS", no hi ha cap quantitat associada.
            ● Processa el fitxer per identificar les línies amb "BONUS" i extreure les quantitats de
            cada BONUS.
            ● Finalment, calcula el total dels guanys i el nombre de bitllets amb BONUS.*/


            string linia;
                int cont1 = 0;
                int acumuladorDiners = 0;
                int numero;
            
                //entrada
                StreamReader sr = new StreamReader("BONUS2.TXT");

                //algorisme 
                linia = sr.ReadLine();

                while (linia != null)
                {

                    if (linia == "BONUS")
                    {
                        cont1++;
                        linia = sr.ReadLine();
                        
                        if (linia !=null){
                        numero = Convert.ToInt32(linia);
                        acumuladorDiners = acumuladorDiners + numero;
                         }

                    }
                linia = sr.ReadLine();


            }
            sr.Close();
                // sortida

                Console.WriteLine($"S'han distribuit {cont1} bonus.");
                Console.WriteLine($"Ha guanyat {acumuladorDiners} € en total");

            }
    }
}
