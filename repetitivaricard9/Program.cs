using System.Diagnostics.Metrics;

namespace repetitivaricard9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //9.Fer un programa que donat un número enter positiu et digui quantes xifres té.
            
            //variables
            int numero;
            int cont=0;
            int aux;

            //entrada

            Console.Write("Diguem un valor per numero: ");
            numero = Convert.ToInt32(Console.ReadLine());
            aux = numero;

            //algorisme i sortida

            while (aux != 0)
            {
                cont++;
                aux = aux / 10;
            }

            Console.WriteLine($"El numero te {cont} digits");

        }
    }
}
