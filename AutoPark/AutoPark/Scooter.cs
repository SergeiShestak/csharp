using System;
using System.Collections.Generic;
using System.Text;

namespace AutoPark
{
    class Scooter : IVehicle
    {
        int fuelConsume;
        Chassis chassis;
        Engine engine;
        Transmission transmission;

        public Scooter(Chassis chassis,Engine engine,Transmission transmission,int fuelConsume)
        {
            this.chassis = chassis;
            this.engine = engine;
            this.transmission = transmission;
            this.fuelConsume = fuelConsume;
        }
        public void printInfo()
        {
            Console.WriteLine($"\n\t Your scooter build on {chassis.getInfo()} \n {engine.getInfo()}" +
                $" \n {transmission.getInfo()} \n with consume fuel {fuelConsume} l on 100 km ");
        }
    }
}
