using System;
using System.Collections.Generic;
using System.Text;

namespace FlyArea
{
    class Reader
    {
        Coordinate coordinate;

        const int PlaneMaximumAltitude = 10000;

        const int MaximumDistanceForFly = 40000;

        Messanger messanger = new Messanger();

        public Coordinate ReadConsole()
        {
            
        messanger.GiveMessage("Enter a number for altitude in m");
        coordinate.altitude = Convert.ToInt32(Console.ReadLine());
        while (coordinate.altitude < 0 || coordinate.altitude > PlaneMaximumAltitude)
        {
                messanger.GiveMessage("Please enter valid number , we can't fly under ground and higher than 10000 m ");
                coordinate.altitude = Convert.ToInt32(Console.ReadLine());
        }

        messanger.GiveMessage("Enter a number for latitude in km");
        coordinate.latitude = Convert.ToInt32(Console.ReadLine());

        while (coordinate.latitude < 0 || coordinate.latitude > MaximumDistanceForFly)
        {
            messanger.GiveMessage("Please enter valid number, we can't fly beyound and far than one time around Earth :) ");
            coordinate.latitude = Convert.ToInt32(Console.ReadLine());
        }

        messanger.GiveMessage("Enter a number for latitude in km");
        coordinate.longtitude = Convert.ToInt32(Console.ReadLine());

        while (coordinate.longtitude < 0 || coordinate.longtitude > MaximumDistanceForFly)
        {
             messanger.GiveMessage("Please enter valid number) ");
             coordinate.longtitude = Convert.ToInt32(Console.ReadLine());
        }
        return coordinate;
        }
    }
}

