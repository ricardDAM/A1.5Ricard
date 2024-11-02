namespace repetititvaricard1
{
    internal class Program
    {
        static void Main(string[] args)
        {


            int cont = 0, num;

            Console.WriteLine("Diguem el valor de num: ");
            num= Convert.ToInt32(Console.ReadLine());

            while (num!=0)
            {
                cont++;
                Console.WriteLine("Diguem  un altre cop el valor de num: ");
                num = Convert.ToInt32(Console.ReadLine());

            }
            Console.WriteLine($"Has escrit {num} ");

        }
    }
}
