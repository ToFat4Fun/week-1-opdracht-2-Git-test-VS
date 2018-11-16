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
                System.Console.WriteLine("goed geantwoord!");
            }
        }

        //geeft de vraag + lijst van mogelijke antwoorden
        public void geefVraag()
        {
            System.Console.WriteLine(Vraag);
            foreach(string a in antwoorden) {
                System.Console.WriteLine(a.ToString());
            }
        }

    }
}