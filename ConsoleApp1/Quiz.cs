using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Quiz
    {
        List<Question> vragenLijst;


        public Quiz()
        {
            vragenLijst = new List<Question>();
        }

        public void addVraag(Question Q)
        {
            vragenLijst.Add(Q);
        }

        public string message()
        {
            string yorokobe = @" __     __             _         _             _____ _                                  _ 
 \ \   / /            | |       | |           / ____| |                                | |
  \ \_/ /__  _ __ ___ | | _____ | |__   ___  | (___ | |__   ___  _   _ _ __   ___ _ __ | |
   \   / _ \| '__/ _ \| |/ / _ \| '_ \ / _ \  \___ \| '_ \ / _ \| | | | '_ \ / _ \ '_ \| |
    | | (_) | | | (_) |   < (_) | |_) |  __/  ____) | | | | (_) | |_| | | | |  __/ | | |_|
    |_|\___/|_|  \___/|_|\_\___/|_.__/ \___| |_____/|_| |_|\___/ \__,_|_| |_|\___|_| |_(_)
";
            string message =  yorokobe + " \n" +
                "Kies 1,2 of 3 voor makkelijk, gemiddeld en moeilijke vragen. \n" +
                "Je kunt ook sorteren op moeilijkheidsgraad of op categorie \n" +
                "Druk op 1 voor makkelijk \n" +
                "Druk op 2 voor gemiddeld \n" +
                "Druk op 3 voor moeilijk  \n" +
                "Druk op 4 om te sorteren op moeilijkheidsgraad \n" +
                "Druk op 5 om te sorteren op categorie.\n" +
                "druk op 0 om af te sluiten";
            return message;
        }



    }
}
