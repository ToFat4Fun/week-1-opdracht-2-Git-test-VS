using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Question
    {
        //vraag en antwoord. question moet beide vraag en antwoord bevatten.
        private string Vraag { get; set;}
        private string Antwoord { get; set; }
        private string Categorie { get; set; }
        private Enum MoeilijkheidsGraad { get; set; }
        private Enum MoelijkheidsGraad { 1,2,3}


        public Question(string V, string A, string C, Enum MG)
        {
            Vraag = V;
            Antwoord = A;
            Categorie = C;
            moeilijkheidsGraad = MG;
        }


        
    }
}
