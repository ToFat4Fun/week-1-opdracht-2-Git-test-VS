using System;
using System.Collections.Generic;
using System.Text;

//omdat naamgeving xD
namespace ConsoleApp1
{
    interface IQuestionable
    {
        string Vraag { get; set; }
        string Antwoord { get; set; }
        string Categorie { get; set; }
        int MoeilijkheidsGraad { get; set; }
        void geefVraag();
        bool checkAnswer(string input);
    }
}
