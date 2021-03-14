using System;
using System.Collections.Generic;
using System.Text;

namespace AutoPark
{
    class Car : Vehicle
    {
        int maxSpeed;
        private Chassis chassis;
        private Engine engine;
        private Transmission transmission;

        public Car(Chassis chassis,Engine engine,Transmission transmission,int maxSpeed)
        {
            this.chassis = chassis;
            this.engine = engine;
            this.transmission = transmission;
            this.maxSpeed = maxSpeed;
        }
        public void printInfo()
        {
            Console.WriteLine($"\n\t This car consist from:{chassis.getInfo()} \n {engine.getInfo()} \n {transmission.getInfo()}\n and have speed:{maxSpeed}");
        }
    }
}
