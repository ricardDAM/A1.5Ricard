using System.Runtime.ConstrainedExecution;

namespace repetitivaricard5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //5.Fer un programa que vagi demanant per teclat números fins trobar el zero i calculi la mitjana
            //dels valors introduïts


            //variables
            int numero,sumaAcumulador=0;
            int cont = 0;
            int mitjana;

            //entrada
            Console.Write("Diguem un valor per el primer numero: ");
            numero = Convert.ToInt32(Console.ReadLine());

            //algorisme

            while (numero != 0)
            {
                cont++;
                sumaAcumulador += numero;
                Console.Write("Diguem un altre  valor per numero: ");
                numero = Convert.ToInt32(Console.ReadLine());

            }

            mitjana = sumaAcumulador / cont;
            Console.WriteLine("La mitjana es " + mitjana );
          
            

        }
    }
}
