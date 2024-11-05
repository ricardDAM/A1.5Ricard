using System.Drawing;

namespace repetititvaricard1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //1.Fes un programa per contar quants valors enters introdueix un usuari per Consola.
            //Deixarem de contar valors en trobar el valor 0.
            
            //variables
            int cont = 0, num;

            //entrada
            Console.WriteLine("Diguem el valor de num: ");
            num= Convert.ToInt32(Console.ReadLine());

           //algorisme i sortida
            while (num!=0)
            {
                cont++;
                Console.WriteLine("Diguem  un altre cop el valor de num: ");
                num = Convert.ToInt32(Console.ReadLine());

            }
            Console.WriteLine($"Has escrit {cont} numeros");

        }
    }
}
