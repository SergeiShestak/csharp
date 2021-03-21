using System;

namespace AutoPark
{
    class Program
    {
        static void Main(string[] args)
        {
            Scooter yourScooter = new Scooter(new Chassis(QuantityWheels.TWO,0001,350),new Engine(3,50,EngineType.PETROL,30504),
                new Transmission(TransType.VARIATOR,TransProducer.ZF,2),3);

            Truck dreamTruck = new Truck(new Chassis(QuantityWheels.TWELVE, 0003, 38000), new Engine(700, 12000, EngineType.TURBODIESEL, 0003),
                new Transmission(TransType.MANUAL, TransProducer.EATON, 18), 23);

            Bus neoplan = new Bus(new Chassis(QuantityWheels.SIX, 0004, 30000), new Engine(420, 11000, EngineType.TURBODIESEL, 110),
                new Transmission(TransType.AUTOMATIC, TransProducer.ZF, 8), 56);

            Car vw = new Car(new Chassis(QuantityWheels.FOUR, 0005, 1240), new Engine(180, 3000, EngineType.TURBOPETROL, 0004),
                new Transmission(TransType.MANUAL, TransProducer.VW, 6), 240);
            dreamTruck.printInfo();
            neoplan.printInfo();
            vw.printInfo();
            yourScooter.printInfo();


        }
    }
}
