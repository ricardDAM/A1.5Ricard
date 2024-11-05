namespace repetitivaricard3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //3.Fes un programa per a saber quants valors positius i negatius hem introduït per teclat

            //variables
            int numero;
            int contPositius = 0;
            int contNegatius = 0;

            //entrada
            Console.Write("Introdueix un numero positiu o negatiu: ");
            numero = Convert.ToInt32(Console.ReadLine());

            //algorisme
            while (numero != 0)
            {

                if (numero > 0) contPositius++;
                else  contNegatius++;

                Console.Write("Introdueix un altre numero positiu o negatiu: ");
                numero = Convert.ToInt32(Console.ReadLine());

                
            }
            //sortida
            Console.WriteLine($"Has introduit {contPositius} numeros positius i {contNegatius} numeros negatius.");

        }
    
    }
}
