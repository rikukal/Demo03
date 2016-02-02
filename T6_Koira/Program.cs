using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T6_Koira
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            dog.Name = "Musti";
            dog.Age = 3;
            //dog.Volume = "quiet";
            dog.Tailspeed = 3;
            dog.Drooling = true;
            dog.PrintData();
        }

        /* Volume volume = Volume Quiet
            enum {
            Silent,
            Quiet,
            Noisy,
            Loud,
            Boisterous
        } */

       /* public void Swing_tail()
        {
            Tailspeed += 3;
        }

        public void Swing_less()
        {
            Tailspeed -= 3;
        }*/


   Console.WriteLine(dog.ToString());

            Console.ReadLine();
    }
}
