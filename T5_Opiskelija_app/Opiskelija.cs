using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T5_Opiskelija_app
{
    class Opiskelija
    {
        //ominaisuudet (properties) Isolla Alkukirjaimella!
        public string Nimi { get; set; }
        public int Ika { get; set; }
        public int Opintopisteet { get; set; }
        public string Opiskeluala { get; set; }
        public bool Insinoori { get; set; }

        // default constructor ( ominaisuuden oletus-alustus)

        //parametric constructor

        // olion toimminnot eli metodit (methods)
        public void PrintData()
        {
            Console.WriteLine("Tiedot opiskelijoista: Nimi: {0} , Ika: {1} , Opintopisteet: {2} , Opiskeluala {3} , Onko Insinoori: {4} ", Nimi, Ika, Opintopisteet, Opiskeluala, Insinoori);
        }
    }
}
