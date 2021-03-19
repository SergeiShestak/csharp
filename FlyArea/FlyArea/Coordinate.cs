using System;
using System.Collections.Generic;
using System.Text;

namespace FlyArea
{
    struct Coordinate
    {
        public int altitude;

        public int longtitude;

        public int latitude;

        public string PrintString()
        {
            return ($"altitude is {altitude} longtitude is {longtitude} latitude is: {latitude}");
        }
    }
}
