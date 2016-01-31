using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T6_Koira
{
    class Dog
    {
        public string Name { get; set; }
        public string Breed { get; set; }   //rotu
        public int Age { get; set; }
        public int Volume { get; set; } //Bark_more or Bark_less
        public int Tailspeed { get; set; } // Swinging tail , Stop , swing less
        public bool Drooling { get; set;}   //kuolaako vai ei? - oletus että kuolaisi  

        // default constructor

        //parametric constructor

        // methods 
        public void PrintData()
        {
            Console.WriteLine(" Dog info:");
            Console.WriteLine(" Name: {0}", Name);
            Console.WriteLine(" Age {0}", Age);
            Console.WriteLine(" Volume: {0}",);
            Console.WriteLine({0})      //Tähän jäätiin!
            Console.WriteLine({0})
        }
    }
}
