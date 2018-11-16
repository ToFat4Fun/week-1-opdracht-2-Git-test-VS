using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    public class ChoiceQuestion  : IQuestionable
    {
        //object ChoiceQuestion heeft de volgende attributen.
        public string Vraag { get; set; }
        public string Antwoord { get; set; }
        public string Categorie { get; set; }
        public int MoeilijkheidsGraad { get; set; }
        private List<string> antwoorden;

        public ChoiceQuestion()
        {
            antwoorden = new List<string>();
        }

        //voegt antwoord toe aan lijst met mogelijke antwoorden. correcte antwoord wordt daadwerklijk opgeslagen in Question
        public void addAntwoord(string an, bool goed)
        {
            antwoorden.Add(an);

            if (goed)
            {
                Antwoord = an;
            }
        }

        //methode uit interface. controleert antwoord
        public bool checkAnswer(string input)
        {
            return input.Equals(Antwoord);
        }

        //geeft de vraag + lijst van mogelijke antwoorden
        public void geefVraag()
        {
            System.Console.WriteLine(Vraag);
            System.Console.WriteLine("Kies uit een van de volgende antwoorden");
            foreach(string a in antwoorden) {
                Console.WriteLine(" {0}", a);
            }
        }
    }
}