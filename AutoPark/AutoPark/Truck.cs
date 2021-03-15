using System;
using System.Collections.Generic;
using System.Text;

namespace AutoPark
{
    class Truck : IVehicle
    {
        int payLoadCapacity;
        Chassis chassis;
        Engine engine;
        Transmission transmission;

        public Truck(Chassis chassis,Engine engine,Transmission transmission,int payload)
        {
            this.chassis = chassis;
            this.engine = engine;
            this.transmission = transmission;
            payLoadCapacity = payload;
        }

        public void printInfo()
        {
            Console.WriteLine($"\n\t Dream Truck on {chassis.getInfo()} \n {engine.getInfo()} \n " +
                $"{transmission.getInfo()} \n it can carry: {payLoadCapacity} ton") ;
        }
    }
}
