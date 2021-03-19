using System;
using System.Collections.Generic;
using System.Text;

namespace FlyArea
{
    class GeneratorCurrentPoint
    {
        Coordinate coordinate;

        Random random = new Random();

        public Coordinate CurrentPointBird()
        {
            coordinate.altitude = random.Next(100);
            coordinate.longtitude = random.Next(4000);
            coordinate.latitude = random.Next(4000);
            return coordinate;
        }

        public Coordinate CurrentPointPlane()
        {
            coordinate.altitude = random.Next(10000);
            coordinate.longtitude = random.Next(4000);
            coordinate.latitude = random.Next(4000);
            return coordinate;
        }

        public Coordinate CurrentPointDrone()
        {
            coordinate.altitude = random.Next(1000);
            coordinate.longtitude = random.Next(4000);
            coordinate.latitude = random.Next(4000);
            return coordinate;
        }

    }
}
