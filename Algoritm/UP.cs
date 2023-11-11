public class UP
{
    public static string AktualnyStav()
    {
        string icon = "";
        Console.WriteLine("Vytajte v UP");
        Console.WriteLine("Zadaj stav projektu: (1 = Hotovo posun dalsiemu oddeleniu , 2 = Docastne pozastavenie, 3 = Presun na ine oddelenie, 4 = Hotovo projekt bol dokonceny)");
        icon = Console.ReadLine().ToUpper();
            
        return icon;
    }
}