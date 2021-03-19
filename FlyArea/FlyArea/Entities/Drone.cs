using System;

namespace FlyArea
{
    class Drone : IFlyable
    {
        const int TimeToWait = 1;

        const int TimeToFly = 10;

        const int FlySpeed = 40;

        const int MinimumAltitude = 1000;

        Coordinate currentCoordinate;

        ProcessorDistance processor = new ProcessorDistance();

        GeneratorCurrentPoint generator = new GeneratorCurrentPoint();

        Messanger messanger = new Messanger();

        public long FlyTo(Coordinate coordinate)
        {
            long distance = 0;

            if (coordinate.altitude > MinimumAltitude)
            {
                messanger.GiveMessage("\n I'm only dron, I can't fly higher 1000m"); //drone  can't fly higher than 1000m; 
            }
            else
            {
                currentCoordinate = generator.CurrentPointDrone();
                messanger.GiveMessage($"Drone now here {currentCoordinate.PrintString()}");
                distance = processor.CalculatingDistance(currentCoordinate, coordinate);
                if (distance > 1000)
                {
                    messanger.GiveMessage($"{distance} km is very long for me ((");   //drone can't fly longer than 1000 km;
                    distance = 0;
                }
                else
                {
                    messanger.GiveMessage($"\n I'm drone, go to you for me {distance} km ");
                }
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
                int numberOfStopping = (int)(distance / FlySpeed) * 60 / TimeToFly;
                double overallTimeToFly = (distance / FlySpeed) * 60 + (numberOfStopping * TimeToWait);
                timeForFly =(overallTimeToFly);                             //after every 10 min drone need wait 1 min
                messanger.GiveMessage($"My speed is {FlySpeed} km/h therefore I'll fly in time {TimeSpan.FromDays(timeForFly)}");
            }
            return timeForFly;
        }

        public TimeSpan GetFlyTime(Coordinate coordinate)
        {
            throw new NotImplementedException();
        }
    }
}
