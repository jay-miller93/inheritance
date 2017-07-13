using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritancePolymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Boat boat1 = new Boat(2, 500, "White and Yellow", 70.0d, .78d);
            boat1.Move();
            boat1.Move();
            Console.WriteLine("Boat moved:" + boat1.GetDistanceTraveled());

            AutoMobile1 vette = new AutoMobile1(4, 20, 2, 2, 500, "Red", 260);
            vette.Move();

            vette.Color = "Green";
            Console.WriteLine("Automobile: " + vette.GetDistanceTraveled());

            AirCraft jet = new AirCraft(40, 1000000, "Gold", 6000);
            jet.Move();
            jet.Move();
            Console.WriteLine("Aircraft " +jet.GetDistanceTraveled());

           
        }
    }
}
