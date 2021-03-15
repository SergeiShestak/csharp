using System;
using System.Collections.Generic;
using System.Text;

namespace AutoPark
{
    class Bus : IVehicle
    {
        int passengerCapacity;
        Chassis chassis;
        Engine engine;
        Transmission transmission;


        public Bus(Chassis chassis,Engine engine, Transmission transmission,int passengers)
        {
            this.chassis = chassis;
            this.engine = engine;
            this.transmission = transmission;
            passengerCapacity = passengers;
        }
        public void printInfo()
        {
            Console.WriteLine($"\n\t Bus on {chassis.getInfo()} \n {engine.getInfo()} " +
                $"\n {transmission.getInfo()} \n passenger capacity : {passengerCapacity}");
        }
    }
}
