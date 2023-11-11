namespace Algoritm;

public class HlavneVedenie : Utvary
{
    public static List<string> dovodyPreVedenie()
    {
        List<string> dovodyPreVedenie = new List<string>();
        dovodyPreVedenie = druhPripojenia();
        return dovodyPreVedenie;
    }
}