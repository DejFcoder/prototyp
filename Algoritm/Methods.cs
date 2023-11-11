namespace Algoritm;

public class Methods
{
    public static double VypocetFixnychFinancii(double rozpocet, double percentoVyuzitiaRozpoctu)
    {
        double fixneFinancie = rozpocet * (percentoVyuzitiaRozpoctu / 100);

        return fixneFinancie;
    }
        
    public static double VypocetVolnychFinancii(double rozpocet, double percentoVyuzitiaRozpoctu)
    {
        double volneFinancie = rozpocet * ((100 - percentoVyuzitiaRozpoctu) / 100);

        return volneFinancie;
    }

    public static List<double> ZoznamVolnychFinancii(double volneFinancie, List<double> zoznamVolnychFunkcii)
    {
        zoznamVolnychFunkcii.Add(volneFinancie);
        return zoznamVolnychFunkcii;
    }

    public static List<string> Sablony(int casti)
    {
        
        List<string> sablona = new List<string>();
        List<string> pouzivanaSablona = new List<string>();

        sablona.Add("prva uloha");
        sablona.Add("druha uloha");
        sablona.Add("tretia uloha");
        sablona.Add("stvrta uloha");
        sablona.Add("piata uloha");
        
        if (casti <= 2)
        {
            pouzivanaSablona.Add(sablona[0]);
            pouzivanaSablona.Add(sablona[1]);
        }
        else if (casti <= 4 && casti > 2)
        {
            pouzivanaSablona.Add(sablona[0]);
            pouzivanaSablona.Add(sablona[1]);
            pouzivanaSablona.Add(sablona[2]);
            pouzivanaSablona.Add(sablona[3]);
        }
        else
        {
            pouzivanaSablona.Add(sablona[0]);
            pouzivanaSablona.Add(sablona[1]);
            pouzivanaSablona.Add(sablona[2]);
            pouzivanaSablona.Add(sablona[3]);
            pouzivanaSablona.Add(sablona[4]);
        }

        return pouzivanaSablona;
    }
}