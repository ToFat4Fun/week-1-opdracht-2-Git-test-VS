﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    internal class Quiz
    {
        private List<Question> vragenLijst;

        public Quiz()
        {
            vragenLijst = new List<Question>();
        }

        //voegt vraag toe aan vragenLijst.
        public void addVraag(Question Q)
        {
            vragenLijst.Add(Q);
        }

        //methode print welkom bericht.
        public string message()
        {
            string yorokobe = @" __     __             _         _             _____ _                                  _
 \ \   / /            | |       | |           / ____| |                                | |
  \ \_/ /__  _ __ ___ | | _____ | |__   ___  | (___ | |__   ___  _   _ _ __   ___ _ __ | |
   \   / _ \| '__/ _ \| |/ / _ \| '_ \ / _ \  \___ \| '_ \ / _ \| | | | '_ \ / _ \ '_ \| |
    | | (_) | | | (_) |   < (_) | |_) |  __/  ____) | | | | (_) | |_| | | | |  __/ | | |_|
    |_|\___/|_|  \___/|_|\_\___/|_.__/ \___| |_____/|_| |_|\___/ \__,_|_| |_|\___|_| |_(_)
";
            string message = yorokobe + " \n" +
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

        //methode die de user input verwerkt.
        public void kiesVraag(int input)
        {
            switch (input)
            {
                case 1:
                    Console.WriteLine("U heeft gekozen voor Makkelijk");
                    makkelijkeVraag();
                    break;

                case 2:
                    Console.WriteLine("U heeft gekozen voor gemiddeld");
                    gemiddeldeVraag();
                    break;

                case 3:
                    Console.WriteLine("U heeft gekozen voor moeilijk");
                    moeilijkeVraag();
                    break;

                case 4:
                    Console.WriteLine("U heeft gekozen voor sorteren op moeilijkheidsgraad");
                    sorteerMoeilijkheidsGraad();
                    break;

                case 5:
                    Console.WriteLine("U heeft gekozen voor sorteren op categorie");
                    sorteerCategorie();
                    break;
                case 0:
                    Console.ReadKey(true);
                    break;

                default:
                    Console.WriteLine("default");
                    break;
            }
        }

        public void presentQuestion(Question q)
        {
            q.geefVraag();
            Console.WriteLine("antwoord: ");
            string response = Console.ReadLine();
            Console.WriteLine(q.checkAnswer(response));
            Console.WriteLine("volgende vraag? druk op een toets");
            Console.ReadKey(true);
        }

        public void makkelijkeVraag()
        {
            List<Question> result = (from Question q in vragenLijst
                         where q.MoeilijkheidsGraad.Equals(1)
                         select q).ToList();
            foreach(Question q in result)
            {
                presentQuestion(q);
            }
        }

        public void gemiddeldeVraag()
        {
            List<Question> result = (from Question q in vragenLijst
                         where q.MoeilijkheidsGraad.Equals(2)
                         select q).ToList();
            foreach (Question q in result)
            {
                presentQuestion(q);
            }
        }

        public void moeilijkeVraag()
        {
            List<Question> result = (from Question q in vragenLijst
                         where q.MoeilijkheidsGraad.Equals(3)
                         select q).ToList();
            foreach (Question q in result)
            {
                presentQuestion(q);
            }

        }
        public void sorteerMoeilijkheidsGraad()
        {
            List<Question> result = (from Question q in vragenLijst
                         orderby q.MoeilijkheidsGraad
                         select q).ToList();
            foreach (Question q in result)
            {
                presentQuestion(q);
            }
        }
        public void sorteerCategorie()
        {
            List<Question> result = (from Question q in vragenLijst
                         orderby q.Categorie
                         select q).ToList();
            foreach (Question q in result)
            {
                presentQuestion(q);
            }
        }
    }
}