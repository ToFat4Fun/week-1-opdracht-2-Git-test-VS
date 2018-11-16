namespace ConsoleApp1
{
    public class Question
    {
        //object Question heeft de volgende attributen.
        public string Vraag { get; set; }

        public string Antwoord { get; set; }
        public string Categorie { get; set; }
        public int MoeilijkheidsGraad { get; set; }

        public Question(){}

        public virtual void geefVraag()
        {
            System.Console.WriteLine(Vraag);
        }

        public bool checkAnswer(string input)
        {
            return input.Equals(Antwoord);
        }
    }
}