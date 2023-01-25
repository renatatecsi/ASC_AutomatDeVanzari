using System;
namespace AutomatDeVanzari
{
    class Program
    {
        static void Main(string[] args)
        {
            // Automat de vanzari
            // N = nickel (0.05), D = dime (0.10), Q = quarter (0.25)

            Console.WriteLine("Bun venit la automatul de vanzari! Un produs costa 20¢. \n" +
                "Automatul acepta doar monede de 5, 10 si 25.");
            int moneda = int.Parse(Console.ReadLine());

            int sumaMonede = moneda; 
            if (sumaMonede != 20) // cat timp suma monedelor nu este egala cu 20
            {
                int moneda2 = 0;
                Console.WriteLine($"Suma monede introduse: {sumaMonede}¢. \nMai introduceti:");
                moneda2 = int.Parse(Console.ReadLine());
                sumaMonede = moneda + moneda2;

                if (sumaMonede != 20)
                {
                    while (sumaMonede <20)
                    {
                        int moneda3 = 0;
                        Console.WriteLine($"Suma monede introduse: {sumaMonede}¢. \nMai introduceti:");
                        moneda2 = int.Parse(Console.ReadLine());
                        sumaMonede = moneda;
                    }
                }
                
            }
            else
            {
                int rest = sumaMonede - 20;
                Console.WriteLine($"Aici este produsul. Restul este {rest}¢.");
                
            }

            
        }
    }
}