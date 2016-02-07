using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T5_Opiskelija_app
{
    class Program
    {
        static void Main(string[] args)
        {
            Opiskelija opiskelijat[] = new Opiskelija[5];
            opiskelijat[0] = new Opiskelija { Nimi = "Riku", Ika = 20, Opintopisteet = 60, Opiskeluala = "tieto ja viestinta-tekniikka", Insinoori = true };
            opiskelijat[1] = new Opiskelija { Nimi = "Kalle", Ika = 23, Opintopisteet = 23, Opiskeluala = "hyvinvointiteknologia", Insinoori = true };
            opiskelijat[2] = new Opiskelija { Nimi = "Iina", Ika = 19, Opintopisteet = 100, Opiskeluala = "sairaanhoitaja", Insinoori = false };
            opiskelijat[3] = new Opiskelija { Nimi = "Susanna", Ika = 27, Opintopisteet = 100, Opiskeluala = "energia ja ymparisto-tekniikka", Insinoori = true };
            opiskelijat[4] = new Opiskelija { Nimi = "Kerttu", Ika = 57, Opintopisteet = 120, Opiskeluala = "fysioterapeutti", Insinoori = false };

            // ominaisuudet lajitellaan luokan (Opiskelija[ISOLLA]) arvo (opiskelijat) [n.luku] = new luokka(Opiskelija) { ominaisuus = "ominaisuuden arvo" , ominaisuus2 ... };
            //ei siis erikseen ilman new Student - jakoa 
            foreach (Opiskelija opiskelija in opiskelijat)
            {
                Console.Write(opiskelija.ToString());
                Console.WriteLine();
            }

            Console.WriteLine("Paina Enteriä jatkaaksesi...");
            Console.ReadLine();
        }
    }
}
