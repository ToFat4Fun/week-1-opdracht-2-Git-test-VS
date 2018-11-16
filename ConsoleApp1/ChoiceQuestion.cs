using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    public class ChoiceQuestion : Question
    {
        //object ChoiceQuestion heeft de volgende attributen.
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

        //geeft de vraag + lijst van mogelijke antwoorden
        public void geefVraag()
        {
            base.geefVraag();
            //System.Console.WriteLine(Vraag);
            System.Console.WriteLine("Kies uit een van de volgende antwoorden");
            foreach(string a in antwoorden) {
                Console.WriteLine(" {0}", a);
            }
        }
    }
}