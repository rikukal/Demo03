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
        public string Ika { get; set; }
        public string Opintopisteet { get; set; }
        public string Opiskeluala { get; set; }
        public string Insinoori { get; set; }
        public override string ToString()
        {

            return "\nStudent:Nimi: " + Nimi + "\nIka: " + Ika + "\nOpintopisteet: " + Opintopisteet + "\nInsinoori: " + Insinoori;
        }

    }
}
