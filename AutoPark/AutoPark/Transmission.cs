using System;
using System.Collections.Generic;
using System.Text;

namespace AutoPark
{
    class Transmission : Composition
    {
        private TransType type;
        private int numberGearShift;
        private TransProducer producer;

        public Transmission(TransType type, TransProducer producer, int numberGearShift)
        {
            this.type = type;
            this.producer = producer;
            this.numberGearShift = numberGearShift;
        }

        public string getInfo()
        {
            return ($"with {numberGearShift} {type} transmission of {producer} ");
        }
    }

    enum TransType
    {
        AUTOMATIC,MANUAL,VARIATOR
    }

    enum TransProducer
    {
        ZF,EATON,VW,TOYOTA
    }
}
