using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            // create a new car object 
            Car car = new Car();
            car.PrintData();
            car.Model = "Datsum 100A";
            car.Color = "Yellow";
            car.Engine = 0.4;
            car.DoorCount = 2;
            car.Accelerate();       //kutsuvan arvon voi myös laittaa sulkeisiin, silloin var-ohjelmassa pitää int-kutsua muuttaa ja lisätä se sen tunnisteeseen +5 kohdalle speed
            car.PrintData();


            //create another car object

            string model = "Jeep";
            Car car2 = new Car(model);
            car2.PrintData();
            car2.Color = "Black";
            car2.Engine = 5.0;
            car2.DoorCount = 4;
            car2.FuzzyDices = false;
            car2.Brake();
            car2.PrintData(); 


            Console.ReadLine();

        }
    }
}
