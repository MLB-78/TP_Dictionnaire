using System;
using System.Collections.Generic;


namespace TP_Dictionnaire
{
    class Salle
    {
        private int noSalle;
        private List<Poste> lesPostes = new List<Poste>();

        public int NoSalle
        {
            get { return noSalle; }
            set { noSalle = value; }
        }

        internal List<Poste> LesPostes
        {
            get { return lesPostes; }
            set { lesPostes = value; }
        }

        public Salle(int no)
        {
            this.NoSalle = no;
        }

        public void AjouterPoste(Poste p)
        {
            LesPostes.Add(p);
        }

        public string DescriptifSalle()
        {
            string descriptif = $"Salle {NoSalle} :\n";
            foreach (var poste in LesPostes)
            {
                descriptif += $"- Poste {poste.NomPoste}, OS : {poste.Os}\n";
                foreach (var logiciel in poste.LesLogiciels)
                {
                    descriptif += $"  - Logiciel : {logiciel.NomLogiciel}\n";
                }
            }
            return descriptif;
        }
    }
}