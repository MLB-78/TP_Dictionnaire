using System;
using System.Collections.Generic;

namespace TP_Dictionnaire
{
    class Poste
    {
        private string nomPoste;
        private string os;
        private List<Logiciel> lesLogiciels = new List<Logiciel>();

        public Poste(string nomPoste, string os)
        {

            this.NomPoste = nomPoste;
            this.Os = os;

        }

        public string NomPoste
        {
            get { return nomPoste; }
            set { nomPoste = value; }
        }

        public string Os
        {
            get { return os; }
            set { os = value; }
        }

        public List<Logiciel> LesLogiciels
        {
            get { return lesLogiciels; }
            set { lesLogiciels = value; }
        }
    }
}
