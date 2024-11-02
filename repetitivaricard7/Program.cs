using static System.Runtime.InteropServices.JavaScript.JSType;

namespace repetitivaricard7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*7.Fer un programa que vagi demanant números fins trobar el zero i ens digui el valor més gran i
            el valor més petit.*/
            

            //variables

            int numero, numeroGran, numeroPetit;

            //entrada
            Console.Write("Diguem el valor de numero: ");
            numero = Convert.ToInt32(Console.ReadLine());
            numeroGran = numero;
            numeroPetit = numero;


            while (numero != 0)
            {
               

             

                if (numeroGran<numero )numeroGran = numero;
                else if (numeroPetit>numero )numeroPetit = numero;
                else
                {
                    Console.Write("Diguem un altre numero : ");
                    numero = Convert.ToInt32(Console.ReadLine());
                }

                    

            }
           
            Console.WriteLine($"El numero mes gran es : {numeroGran} i el numero petit es : {numeroPetit}");

        }
    }
}
