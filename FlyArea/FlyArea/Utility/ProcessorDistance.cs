using System;
using System.Collections.Generic;
using System.Text;

namespace FlyArea
{
    class ProcessorDistance
    {
        public long CalculatingDistance(Coordinate current,Coordinate gotten)
        {
            long altitude = Math.Abs(current.altitude - gotten.altitude);
            long latitude = Math.Abs(current.latitude - gotten.latitude);
            long longtitude = Math.Abs(current.longtitude - gotten.longtitude);
            double distanceFlatness =Math.Pow(latitude,2) + Math.Pow(longtitude,2);
            long distanceInVolume = (long)Math.Sqrt(distanceFlatness + Math.Pow((altitude/1000),2));
            return distanceInVolume;
        }
    }
}
