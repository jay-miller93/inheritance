using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritancePolymorphism
{
    class AirCraft : Vehicle
    {
        private double altitude;
        public double Altitude { get; }

        public AirCraft()
        {

        }
        public AirCraft(int seats, int carryCapacity, string color, double movementSpeed)
        {
            this.seats = seats;
            this.carryCapacity = carryCapacity;
            this.color = color;
            this.movementSpeed = movementSpeed;

            altitude = 0.0d;
        }

        public override void Move()
        {
            altitude += 10000.0d;
            base.Move();
        }

        public override string GetDistanceTraveled()
        {
            return "Altitude " + altitude + " -" + base.GetDistanceTraveled();

        }
    }
}
