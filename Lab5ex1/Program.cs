using System;

namespace Lab5ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Scrieti un program care va afisa pozitia unui substring intr-un string, ambele siruri de caractere fiind citite de la tastatura */

            Console.WriteLine("Introduceti primul string = ");
            string string1 = Console.ReadLine();

            if (string.IsNullOrEmpty(string1) || string.IsNullOrWhiteSpace(string1))
            {
                Console.WriteLine("Nu ai introdus nimic, sau ai introdus spatiu gol. Ruleaza din nou programul.");
                return;
            }

            Console.WriteLine("Introduceti al doilea string = ");
            string string2 = Console.ReadLine();

            if (string.IsNullOrEmpty(string2) || string.IsNullOrWhiteSpace(string2))
            {
                Console.WriteLine("Nu ai introdus nimic, sau ai introdus spatiu gol. Ruleaza din nou programul.");
                return;
            }

            /* Curs - Slide 26 => string.IndexOf: intoarce primul index in cadrul string-ului unde se regaseste (sau unde incepe) textul specificat ca si parametru */
            int pozitie = string1.IndexOf(string2);

            if (pozitie == -1) 
                Console.WriteLine(string2 + " nu se gaseste deloc in " + string1);
            else Console.WriteLine(string2 + " incepe de pe pozitia " + pozitie + " in " + string1);

        }
    }
}
