using System;

//17079543 week 1 opdracht 2
namespace Week1Opdracht2Quiz
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //maak een Quiz aan met vragen volgens de opdracht.
            //Gebruik C# initializers om de vragen te vullen bij de opstart van het programma.
            Quiz Q = new Quiz();
            Question vraag1 = new Question()
            {
                Vraag = "1Wie is president van de USA?",
                Antwoord = "Donald J. Trump",
                Categorie = "open vraag",
                MoeilijkheidsGraad = 1
            };

            Question vraag2 = new Question()
            {
                Vraag = "2Met wie kan Nero Claudius goed omgaan in FG/O?",
                Antwoord = "Vlad the Impaler",
                Categorie = "open vraag",
                MoeilijkheidsGraad = 2
            };

            Question vraag3 = new Question()
            {
                Vraag = "3Hoeveel SQ kost een 10 roll?",
                Antwoord = "30",
                Categorie = "open vraag",
                MoeilijkheidsGraad = 3
            };

            ChoiceQuestion vraag4 = new ChoiceQuestion()
            {
                Vraag = "1 multi: Wat is de default acces modifier in C#?",
                Categorie = "multiple choice",
                MoeilijkheidsGraad = 1
            };
            vraag4.addAntwoord("private", false);
            vraag4.addAntwoord("internal", true);
            vraag4.addAntwoord("protected", false);

            Q.addVraag(vraag1);
            Q.addVraag(vraag2);
            Q.addVraag(vraag3);
            Q.addVraag(vraag4);
            Console.ForegroundColor = ConsoleColor.Green;
            //begin user interactie.
            Console.WriteLine(Q.message());
            string keuzeVragen = Console.ReadLine();
            int keuze = int.Parse(keuzeVragen);
            Q.kiesVraag(keuze); //gaat de juiste vragen filteren en geven.

            Console.ReadKey();
        }
    }
}