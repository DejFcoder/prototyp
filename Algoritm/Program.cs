namespace Algoritm
{
    class Program
    {
        public static void Main(string[] args)
        {
            Projekt projekt = new Projekt("Detske Ihrisko", "vdfddhxfg","Kultura", 100000, 4);

            Console.WriteLine("Rozpočet: " + projekt.rozpocet + " Eur");
            Console.WriteLine();
            Console.WriteLine("Fixné financie boli vypočítané na: ");
            Console.WriteLine(Methods.VypocetFixnychFinancii(projekt.rozpocet, 85) + " Eur");
            Console.WriteLine();
            
            Console.WriteLine("Zvyšok financií budeme môcť použiť ako voľné financie do ďaľších projektov a z tohto projektu nám vyšlo: ");
            double volneFinancie = Methods.VypocetVolnychFinancii(projekt.rozpocet, 85);
            Console.WriteLine(volneFinancie + " Eur");
            Console.WriteLine();
            
            Console.WriteLine("Zoznam voľných financií v jednotlivých projektoch: ");
            List<double> zoznamVolnychFinancii = new List<double>();
            zoznamVolnychFinancii = Methods.ZoznamVolnychFinancii(volneFinancie, zoznamVolnychFinancii);
            
            foreach (var item in zoznamVolnychFinancii)
            {
                Console.Write(item + ", ");
            }
            Console.WriteLine();
            Console.WriteLine();
            
            List<string> sablony = Methods.Sablony(projekt.casti);
            int i = 1;
            foreach (var item in sablony)
            {
                Console.WriteLine(i + ". " + item);
                i++;
            }
            Console.WriteLine();

            List<string> reportingVedenia = HlavneVedenie.dovodyPreVedenie();
            
            Console.WriteLine("---------------------------------------------------------------");
            Console.WriteLine("HLAVNÉ VEDENIE");
            Console.WriteLine("Dovody pozastavenia projektov / dokoncenie projektov: ");

            foreach (var item in reportingVedenia)
            {
                Console.WriteLine(item);
            }
            
            Console.WriteLine(projekt.name);
        }
    }
}

