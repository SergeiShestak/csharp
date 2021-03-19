using System;

namespace FlyArea
{
    class Program
    {
        static void Main(string[] args)
        {
            Reader reader = new Reader();
            Bird bird = new Bird();
            Drone drone = new Drone();
            Plane plane = new Plane();
            Coordinate coordinate;

            coordinate = reader.ReadConsole();
            bird.GetFlyTime(bird.FlyTo(coordinate));
            drone.GetFlyTime(drone.FlyTo(coordinate));
            plane.GetFlyTime(plane.FlyTo(coordinate));
        }
    }
}
