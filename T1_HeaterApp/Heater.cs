using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T1_HeaterApp
{
    class Heater
    {
        // properties

        public string Modelname {get; set;}
        public int Temperature { get; set; }
        public int Humidity { get; set; }
        public bool IsOn { get; set; }

        // default constructor

        

        //parametric constructor

        // methods prints object data to screen

        public void PrintData()
        {
        Console.WriteLine("Heater data");
        Console.WriteLine("- Temp {0}",Temperature);
        Console.WriteLine("- Humi {0}", Humidity);
        Console.WriteLine("- IsOn {0}", IsOn);
    }

        // method returns object poroperties in a one string
        public override string ToString()
        {

            return "Temp = " + Temperature + " Humi = " + Humidity + " IsOn = " + IsOn;
        }

        // print properties to console


    }
}
