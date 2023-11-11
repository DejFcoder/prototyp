namespace Algoritm;

public class Utvary
{
    public static List<string> druhPripojenia()
    {
        List<string> dovody = new List<string>();
        bool value = true;
        while (value)
        {
            Console.WriteLine("Na ake oddelenie chces presunut tento projekt: (UP, UM, UI, USAZP)");
            string prepojenie = Console.ReadLine().ToUpper();
            
            if (prepojenie == "USAZP")
            {
                string icon = USAZP.AktualnyStav();
                if (icon == "2")
                {
                    value = false;
                    Console.WriteLine("Tento projekt je pozastavený, uveď dôvod:");
                    string dovod = Console.ReadLine();
                    dovody.Add(dovod);
                }
                else if (icon == "4")
                {
                    value = false;
                    Console.WriteLine("Projekt bol dokončený");
                    dovody.Add("Projekt bol dokončený");
                }
                else
                {
                    continue;
                }
            }
            else if (prepojenie == "UP")
            {
                string icon = UP.AktualnyStav();
                if (icon == "2")
                {
                    value = false;
                    Console.WriteLine("Tento projekt je pozastavený, uveď dôvod:");
                    string dovod = Console.ReadLine();
                    dovody.Add(dovod);
                }
                else if (icon == "4")
                {
                    value = false;
                    Console.WriteLine("Projekt bol dokončený");
                    dovody.Add("Projekt bol dokončený");
                }
                else
                {
                    continue;
                }
            }

            else if (prepojenie == "UM")
            {
                string icon = UM.AktualnyStav();
                if (icon == "2")
                {
                    value = false;
                    Console.WriteLine("Tento projekt je pozastavený, uveď dôvod:");
                    string dovod = Console.ReadLine();
                    dovody.Add(dovod);
                }
                else if (icon == "4")
                {
                    value = false;
                    Console.WriteLine("Projekt bol dokončený");
                    dovody.Add("Projekt bol dokončený");
                }
                else
                {
                    continue;
                }
            }

            else if (prepojenie == "UI")
            {
                string icon = UI.AktualnyStav();
                if (icon == "2")
                {
                    Console.WriteLine("Tento projekt je pozastavený, uveď dôvod:");
                    string dovod = Console.ReadLine();
                    dovody.Add(dovod);
                }
                else if (icon == "4")
                {
                    value = false;
                    Console.WriteLine("Projekt bol dokončený");
                    dovody.Add("Projekt bol dokončený");
                }
                else
                {
                    continue;
                }
            }
        }

        return dovody;
    }
}
