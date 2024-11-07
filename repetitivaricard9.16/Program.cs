namespace repetitivaricard9._16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*16. S'introdueix per teclat el valor del radi r d'una circumferència.
            ● Tenim un fitxer anomenat coordenades.txt.
            ● Cada línia senar conté una coordenada x. Cada línia parell conté una coordenada y.
            -2,6 → coordenada x
            3,8 → coordenada y
            . . .
            ● El fitxer acaba amb un valor nul per a x per indicar el final.
            ● El programa ha d'informar si cada punt està dins, fora o sobre el perímetre de la
            circumferència.
            ● La circumferència té centre a (0, 0) i radi r.*/

            //variables
            string linia;
            double x, y;
            double radi;
            double distancia;
            //entrada
            Console.Write("Introdueix el valor del radi : ");
            radi = Convert.ToDouble(Console.ReadLine());

            StreamReader sr = new StreamReader("coordenades.txt");


            while ((linia = sr.ReadLine()) != null)
            {
                x = Convert.ToDouble(linia);
                linia = sr.ReadLine();
                y = Convert.ToDouble(linia);
                distancia = Math.Sqrt(x * x + y * y);

                if (distancia < radi)
                {
                    Console.WriteLine($"El punt ({x}, {y}) està dins de la circumferència.");
                }
                else if (distancia == radi)
                {
                    Console.WriteLine($"El punt ({x}, {y}) està sobree el perímetre de la circumferència.");
                }
                else
                {
                    Console.WriteLine($"El punt ({x}, {y}) està fora de la circumferència.");
                }
            }

            sr.Close();
        }
    }
}