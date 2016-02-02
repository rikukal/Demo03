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
        //public enum Volume { get; set; } //Bark_more or Calm asteet: silent, quiet, bit noisy, loud, boisterous ENUM?
        public int Tailspeed { get; set; } // Swinging tail, swing less
        public bool Drooling { get; set;}   //kuolaako vai ei? - oletus että kuolaisi  

        // default constructor

        //parametric constructor
       
        // methods 
        public void PrintData()
        {
            Console.WriteLine(" Dog info:");
            Console.WriteLine(" Name: {0}", Name);
            Console.WriteLine(" Age {0}", Age);
            //Console.WriteLine(" Volume: {0}",Volume);
            Console.WriteLine("{0}", Tailspeed);
            Console.WriteLine("{0}", Drooling);
        }

        


        public override string ToString()
        {
            return "Name: " + Name + " Age: " + Age + /*" Volume: "+ Volume + */" Tailspeed: " + Tailspeed + "Is drooling:" + Drooling;
        }
    }
}
