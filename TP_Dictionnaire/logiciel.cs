using TP_Dictionnaire;

class Logiciel
{
    private string nomLogiciel;
    private List<Poste> lesPostes = new List<Poste>();

    public List<Poste> LesPostes
    {
        get { return lesPostes; }
        set { lesPostes = value; }
    }

    public string NomLogiciel
    {
        get { return nomLogiciel; }
        set { nomLogiciel = value; }
    }

    public Logiciel()
    {
    }

    public Logiciel(string nom)
    {
        this.NomLogiciel = nom;
    }
}
