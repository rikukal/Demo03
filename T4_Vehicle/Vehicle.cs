using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T4_Vehicle
{
    class Vehicle
    {
        //ominaisuudet (properties) HUOM pääohjelmassa ISOILLA ALKUKIRJAIMILLA
        public string Name { get; set; }
        public double Speed { get; set; }
        public int Tyres { get; set; }

        // default constructor

        //parametric constructor

        // methods 

        public void PrintData()
        {
            Console.WriteLine("Vehicle data");
            Console.WriteLine("- Name{0}", Name);
            Console.WriteLine("- Speed {0}", Speed);
            Console.WriteLine("- Tyres {0}", Tyres);
        }
        /*
        vehicle.Kaasuta();
        vehicle.Kaasuta_kovaa();
        vehicle.Jarruta();
        vehicle.Jarruta_kovaa();
        vehicle.Lisaa_rengas();
        vehicle.Ota_rengas(); */

        public override string ToString()
        {

            return "Name: " + Name + " Speed: " + Speed + " Tyres: " + Tyres;
        }
    }


    }
