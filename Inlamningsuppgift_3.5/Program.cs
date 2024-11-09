using System; 

namespace Inlamning_3._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in ett tal");
            int tal1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Skriv ner en till tal");
            int tal2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Välj ett räknesätt. (Sriv nummern till räknesättet");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtration");
            Console.WriteLine("3. Multiplikation");
            Console.WriteLine("4. Divition");
            int sätt = int.Parse(Console.ReadLine());
            int resultat = tal1 - tal2;

            switch (sätt)
            {
                case 1:
                    Console.WriteLine("Svaret är " + tal1 + tal2);
                    break;
                case 2:  
                    Console.WriteLine("Svaret är " + resultat);
                    break;
                case 3:
                    Console.WriteLine("Svaret är " + tal1 * tal2);
                    break;
                case 4:
                    Console.WriteLine("Svaret är " + tal1 / tal2);
                    break;
            }
        }
    }
}