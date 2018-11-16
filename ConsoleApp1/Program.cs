using System;

//17079543 week 1 opdracht 2
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;

            Quiz Q = new Quiz();
            Question vraag1 = new Question("Wie is de president van de USA?", "Donald J. Trump", "Algemeen", 1);
            Question vraag2 = new Question("Wat betekent de volgende code:  string naam = @ " + "hello world ",
                "de @ zorgt ervoor dat er niet meerdere lines nodig zijn. handig om ascii art in op te slaan!", "programming", 2);
            Question vraag3 = new Question("wat is 2+2=4-1", "quick maths!", "media", 3);
            Q.addVraag(vraag1);
            Q.addVraag(vraag2);
            Q.addVraag(vraag3);
            


            Console.WriteLine(Q.message());
            Console.ReadKey();
        }
    }
}
