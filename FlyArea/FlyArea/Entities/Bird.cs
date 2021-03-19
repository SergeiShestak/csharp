using System;
using System.Collections.Generic;
using System.Text;

namespace FlyArea
{
    internal class Bird : IFlyable
    {
        Messanger messanger = new Messanger();

        Random rand = new Random();

        ProcessorDistance processor = new ProcessorDistance();

        GeneratorCurrentPoint generator = new GeneratorCurrentPoint()
            ;
        private double flySpeed;

        const int MinimumAltitude = 100;

        public long FlyTo(Coordinate coordinate)
        {
            long distance = 0;

            if (coordinate.altitude > MinimumAltitude)
            {
                messanger.GiveMessage("\n We are only birds, we can't so high "); //birds can't fly higher than 100m 
            }
            else
            {
                Coordinate currentCoordinate = generator.CurrentPointBird();
                messanger.GiveMessage($"Now we are here : {currentCoordinate.PrintString()}");
                distance = processor.CalculatingDistance(currentCoordinate, coordinate);
                messanger.GiveMessage($"We're birds, go to you for us {distance} km ");
            }
            return distance;
        }

        public double GetFlyTime(long distance)
        {
            double timeForFly;

            if (distance == 0)
            {
                timeForFly = 0;
            }
            else
            {
                flySpeed = rand.Next(20);
                timeForFly = ((double)(distance / flySpeed));
                messanger.GiveMessage($"ours speed is {flySpeed} km/h \n therefore we'll fly to you in time " +
                    $"{TimeSpan.FromHours(timeForFly)} \n");
            }
            return timeForFly;
        }

        public TimeSpan GetFlyTime(Coordinate coordinate)
        {
            throw new NotImplementedException();
        }
    }
}
