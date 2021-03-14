using System;
using System.Collections.Generic;
using System.Text;

namespace AutoPark
{
    class Chassis : Composition
    {
        private QuantityWheels wheels;
        private int Id;
        private int maxLoad;

        public Chassis(QuantityWheels wheels,int Id,int maxLoad)
        {
            this.wheels = wheels;
            this.Id = Id;
            this.maxLoad = maxLoad;
        }

        public string getInfo()
        {
            return ($"Chassis on {wheels} wheels with maxLoad:{maxLoad} kg  and Id:{Id}");
        }
    }

    enum QuantityWheels
    {
        TWO,FOUR,SIX,TEN,TWELVE
    }
}
