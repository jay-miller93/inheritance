using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritancePolymorphism
{
    class AutoMobile1 : Vehicle
    {
        private int numOfWheels;
        private float wheelSize;
        private int numOfDoors;
        
        public int NumOfWheels { get; }
        public int NumOfDoors { get; }
        public float WheelSize { get; }
        public AutoMobile1()
        {

        }
        public AutoMobile1(int numOfWheels, float wheelSize, int numberOfDoors, int seats, int carryCopacity, string color, 
            double movementSpeed)
        {
            this.numOfDoors = numOfDoors;
            this.wheelSize = wheelSize;
            this.numOfWheels = numOfWheels;
            this.seats = seats;
            this.carryCapacity = carryCapacity;
            this.color = color;
            this.movementSpeed = movementSpeed;
        }


    }
}
