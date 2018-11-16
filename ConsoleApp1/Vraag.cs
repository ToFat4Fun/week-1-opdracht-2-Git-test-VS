using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Question
    {
        //object Question heeft de volgende parameters.
        private string Vraag { get; set;}
        private string Antwoord { get; set; }
        private string Categorie { get; set; }
        private int MoeilijkheidsGraad { get; set; }

        public Question(string V, string A, string C, int MG)
        {
            Vraag = V;
            Antwoord = A;
            Categorie = C;
            MoeilijkheidsGraad = MG;
        }
        

        
    }
}
