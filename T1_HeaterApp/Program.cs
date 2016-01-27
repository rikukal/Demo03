using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T1_HeaterApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // create a new heater object
            Heater heater = new Heater();
            heater.IsOn = true;
            heater.Humidity = 75;
            heater.Temperature = 100; 
            heater.PrintData();

            Console.WriteLine("Temperature = " + heater.Temperature);

            Console.WriteLine(heater.ToString());

            Console.ReadLine();
        }
    }
}
