using System;
using System.Collections.Generic;

namespace TP_Dictionnaire
{
    class Program
    {
        static void Main(string[] args)
        {
            Salle s1 = new Salle(306);
            Salle s2 = new Salle(367);
            Salle s3 = new Salle(368);

            List<Salle> mesSalles = new List<Salle>();
            mesSalles.Add(s1);
            mesSalles.Add(s2);
            mesSalles.Add(s3);

            Poste p1 = new Poste("P306-01", "Windows18");
            Poste p2 = new Poste("P306-02", "Windows18");
            Poste p3 = new Poste("P306-03", "Windows18");
            Poste p4 = new Poste("P306-04", "Windows18");
            Poste p5 = new Poste("P307-01", "Windows10");
            Poste p6 = new Poste("P307-02", "Windows10");
            Poste p7 = new Poste("P307-03", "Windows10");

            Logiciel logiciel11 = new Logiciel("MS Office 2015");
            Logiciel logiciel12 = new Logiciel("MS Office 2017");
            Logiciel logiciel13 = new Logiciel("Oracle");
            Logiciel logiciel14 = new Logiciel("Visual Studio 2013");
            Logiciel logiciel15 = new Logiciel("Visual Studio 2012");

            p1.LesLogiciels.Add(logiciel11);
            p1.LesLogiciels.Add(logiciel12);
            p1.LesLogiciels.Add(logiciel13);
            p2.LesLogiciels.Add(logiciel13);
            p2.LesLogiciels.Add(logiciel14);
            p2.LesLogiciels.Add(logiciel15);
            p3.LesLogiciels.Add(logiciel11);
            p3.LesLogiciels.Add(logiciel14);
            p3.LesLogiciels.Add(logiciel15);

            Logiciel logiciel1 = new Logiciel("Logiciel A");
            Logiciel logiciel2 = new Logiciel("Logiciel B");

            Poste poste1 = new Poste("P306-01", "Windows");
            poste1.NomPoste = "Poste 1";
            poste1.Os = "Windows";
            poste1.LesLogiciels.Add(logiciel1);

            Poste poste2 = new Poste("P306-02", "Linux");
            poste2.NomPoste = "Poste 2";
            poste2.Os = "Linux";
            poste2.LesLogiciels.Add(logiciel1);
            poste2.LesLogiciels.Add(logiciel2);

            Salle salle1 = new Salle(1);
            salle1.AjouterPoste(poste1);

            Salle salle2 = new Salle(2);
            salle2.AjouterPoste(poste2);

            string descriptifSalle1 = salle1.DescriptifSalle();
            string descriptifSalle2 = salle2.DescriptifSalle();

            Console.WriteLine("Descriptif de la Salle 1 :\n" + descriptifSalle1);
            Console.WriteLine("Descriptif de la Salle 2 :\n" + descriptifSalle2);

            Dictionary<Logiciel, int> recap = new Dictionary<Logiciel, int>();

            foreach (Salle sa in mesSalles)
            {
                foreach (Poste p in sa.LesPostes)
                {
                    foreach (Logiciel l in p.LesLogiciels)
                    {
                        if (recap.ContainsKey(l))
                            recap[l]++;
                        else
                            recap[l] = 1;
                    }
                }
            }

            Console.WriteLine("\nRécapitulatif des logiciels dans l'ensemble de l'établissement :");
            foreach (var kvp in recap)
            {
                Console.WriteLine($"- {kvp.Key.NomLogiciel}: {kvp.Value} installations");
            }
        }
    }
}
