namespace Algoritm;

public class Projekt
{
    public string name;
    public string id;
    public string kategoria;
    public double rozpocet;
    public int casti;
        
    public Projekt(string name, string id, string kategoria, int rozpocet, int casti)
    {
        this.name = name;
        this.id = id;
        this.kategoria = kategoria.ToLower();
        this.rozpocet = rozpocet;
        this.casti = casti;
    }
}
