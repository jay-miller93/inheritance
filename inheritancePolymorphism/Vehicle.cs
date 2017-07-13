using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritancePolymorphism
{
    class Vehicle//base class
    {
        //fields
        protected int seats;
        protected int carryCapacity;
        protected string color;
        protected double movementSpeed;
        protected double distanceTraveled;

        private float gearRatio;
        private float engineSize;

        //properties
        public int Seats { get; }
        public int CarryCapacity { get; }
        public string Color { get; set; }
        public double DistanceTraveled { get; }


        //constructors

        public Vehicle()
        {

        }
        public Vehicle(int seats, int carryCapacity, string color, double movementSpeed)
        {
            this.seats = seats;
            this.carryCapacity = carryCapacity;
            this.color = color;
            this.movementSpeed = movementSpeed;

            distanceTraveled = 0.0d;
        }
        
        public virtual void Move()
        {
            distanceTraveled += movementSpeed;
        }

        public virtual string GetDistanceTraveled()
        {
            return " Distance Traveled:" + distanceTraveled + "\n";
        }



    }
}
