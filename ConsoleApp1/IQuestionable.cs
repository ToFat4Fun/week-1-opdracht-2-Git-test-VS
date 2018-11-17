//omdat naamgeving xD
namespace Week1Opdracht2Quiz
{
    internal interface IQuestionable
    {
        string Vraag { get; set; }
        string Antwoord { get; set; }
        string Categorie { get; set; }
        int MoeilijkheidsGraad { get; set; }

        void geefVraag();

        bool checkAnswer(string input);
    }
}