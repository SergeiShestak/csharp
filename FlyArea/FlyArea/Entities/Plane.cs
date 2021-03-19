using System;

namespace FlyArea
{
    class Plane : IFlyable
    {
        const int StartSpeedFly = 200;

        const int Acceleration = 10;

        const int MaximumSpeedFly = 900;

        const int DistanceForIncreaseAcceleration = 10;

        const int MinimumAltitude = 500;

        double flySpeed;

        Coordinate currentCoordinate;

        GeneratorCurrentPoint generator = new GeneratorCurrentPoint();

        ProcessorDistance processor = new ProcessorDistance();

        Messanger messanger = new Messanger();

        public long FlyTo(Coordinate coordinate)
        {
            long distance;

            if (coordinate.altitude < MinimumAltitude)
            {
                messanger.GiveMessage("I'm big plane, I can't  fly so low"); //piane  can't fly loweer than 500m
                distance = 0;
            }
            else
            {
                currentCoordinate = generator.CurrentPointDrone();
                messanger.GiveMessage($"Plane now is here: {currentCoordinate.PrintString()}");
                distance = processor.CalculatingDistance(currentCoordinate, coordinate);
                messanger.GiveMessage($"I'm plane, go to you for me {distance} km \n");
            }
            return distance;

        }

        public int[] CalculationPlaneSpeed(long distance)
        {
            int[] outputForCalculationAverageSpeed = new int[2];

            int speed = StartSpeedFly;

            int iterator = 0;

            while (iterator < distance / DistanceForIncreaseAcceleration)
            {
                speed += Acceleration;
                iterator++;
                if (speed > MaximumSpeedFly)
                    break;
            }
            outputForCalculationAverageSpeed[0] = speed;
            outputForCalculationAverageSpeed[1] = iterator;
            return outputForCalculationAverageSpeed;
        }

        public TimeSpan GetFlyTime(Coordinate coordinate)
        {
            throw new NotImplementedException();
        }

        public TimeSpan GetFlyTime(long distance)
        {
            double timeForFly;

            long distanceForAcceleration = (MaximumSpeedFly - StartSpeedFly);

            int[] iteratorWithSpeed = new int[2];

            if (distance == 0)
            {
                timeForFly = 0;
            }

            else if (distance < distanceForAcceleration)
            {
                timeForFly = AccelerationTimeCollector(distance);
                iteratorWithSpeed = CalculationPlaneSpeed(distance);
                flySpeed = iteratorWithSpeed[0];
                messanger.GiveMessage($"My speed is {flySpeed} km/h therefore I'll fly at you in time " +
                    $"{TimeSpan.FromHours(timeForFly)} ");

            }
            else
            {
                double distanceRemainingAfterAcceleration = distance - distanceForAcceleration;
                double timeForFlyOnMaxSpeed = (distanceRemainingAfterAcceleration / MaximumSpeedFly);
                timeForFly = (AccelerationTimeCollector(distanceForAcceleration)) + timeForFlyOnMaxSpeed;
                flySpeed = distance / timeForFly;
                messanger.GiveMessage($"My average speed is {flySpeed} km/h therefore I'll fly at you in time " +
                    $"{TimeSpan.FromHours(timeForFly)} ");

            }
            
            return TimeSpan.FromHours(timeForFly);

        }

        public double AccelerationTimeCollector(long distance)
        {
            int iterator = 0;

            double timeCollector = 0;

            int accelerationSpeed = StartSpeedFly;

            while (iterator < distance)
            {
                timeCollector += (double) DistanceForIncreaseAcceleration / accelerationSpeed;
                accelerationSpeed += Acceleration;
                iterator += DistanceForIncreaseAcceleration;
            }
            return timeCollector;

        }

    }
}
