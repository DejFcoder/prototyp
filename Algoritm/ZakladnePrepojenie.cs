namespace Algoritm;

class ZakladnePrepojenie
{
    public static string zakladnyStav()
    {
                Console.WriteLine("Na ake oddelenie chces presunut tento projekt: (UP, UM, UI, USAZP)");
                string prepojenie = Console.ReadLine().ToUpper();
                return prepojenie;
    }
}