
namespace repetitivaricard9._10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*10.Fes un programa on llancem un dau de 6 cares(valors de forma aleatoria) fins que el número
            de vegades que surti 1 i 6 sigui el mateix.Conta quantes vegades hem llançat el dau i quantes
            vegades ha aparegut el valor 6*/

             //variables
                int numeroDau;
                int cont1=0;
                int cont6=0;
                int contGeneral=0;

            //entrada
            Random rand = new Random();
            numeroDau = rand.Next(1, 7);

            //algorisme
          // la primera condicio es que cont sigui diferent a zero
            while (cont1 != cont6 || cont1==0 || cont6==0 ){

                if (numeroDau == 1) cont1++;
                else if (numeroDau == 6) cont6++;
              
                contGeneral++;
                numeroDau = rand.Next(1, 7);

            }
            //sortida
            Console.WriteLine($"Hem llençat el dau {contGeneral} vegades");
            Console.WriteLine($"Ha caigut al 6 {cont6} vegades");
        }
    }
}
