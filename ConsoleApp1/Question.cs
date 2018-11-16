namespace ConsoleApp1
{
    public class Question : IQuestionable
    {
        //object Question heeft de volgende attributen.
        public string Vraag { get; set; }
        public string Antwoord { get; set; }
        public string Categorie { get; set; }
        public int MoeilijkheidsGraad { get; set; }

        public Question(){}

        public void geefVraag()
        {
            System.Console.WriteLine(Vraag);
        }

        //methode uit interface. controleert antwoord
        public bool checkAnswer(string input)
        {
            return input.Equals(Antwoord);
        }
    }
}