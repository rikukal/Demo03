using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T4_Vehicle
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle vehicle = new Vehicle();    // Isolla kirjaimella kutsutaan luokasta olevaa oliota, pienikirjaiminen on oliolle annettu nimi
            vehicle.Name = " Kaara ";    // isolla Name viittaa luokan Vehicle Name-ominaisuuteen, jolle on annettu "Name"-arvoksi "Kaara" 
            vehicle.Speed = 0;          
            vehicle.Tyres = 4;          // Olion Tyres-ominaisuudelle on annettu oletusarvoksi 4
            vehicle.PrintData(); 

            // metodit, eli olion toiminnot	(methods)
            // Jarrutus ja Kaasutus

            /*
            public void Kaasuta()
            {
                Speed += 20;
            }

            public void Kaasuta_kovaa()
            {
                Speed += 50;
            }

            public void Jarruta()
            {
                Speed -= 20;
            }

            public void Jarruta_kovaa()
            {
                Speed -= 50;
            }

            public void Lisaa_rengas()
            {
                Tyres += 1;
            }

            public void Ota_rengas()
            {
                Tyres -= 1;
            }
        */

            // palauttaa kaikki Vehiclen ominaisuudet yhtenä merkkijonona
            Console.WriteLine(vehicle.ToString());

            Console.ReadLine();

        }
    }
}
