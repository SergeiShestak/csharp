using System;
using System.Collections.Generic;
using System.Text;

namespace AutoPark
{
    class Engine : IComposition
    {
        private int power;
        private int volume;
        private EngineType type;
        private int Id;

        public Engine(int power,int volume,EngineType type,int Id)
        {
            this.power = power;
            this.volume = volume;
            this.type = type;
            this.Id = Id;
        }

        public string getInfo()
        {
            return ($"engine {type} power {power} Kw and volume {volume} cm3");
        }
    }

    enum EngineType
    {
        DIESEL,PETROL,TURBODIESEL,TURBOPETROL,ELECTRIC
    }
}
