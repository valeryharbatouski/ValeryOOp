﻿using System;

namespace ValeryOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            var car = new Car();
            var plane = new Plane();
            var ship = new Ship();

            Vehicle[] vehicles = new Vehicle[] {car, plane, ship};

            foreach (var vehicle in vehicles)
            {
                Console.WriteLine(vehicle.Go());
            }
        }
    }


    public abstract class Vehicle
    {
        public abstract string Go();
    }


    public class Car : Vehicle
    {
        public override string Go() => "car says aron-don-don";
    }

    public class Ship : Vehicle
    {
        public override string Go() => "ship sound";
    }

    public class Plane : Vehicle
    {
        public override string Go() => "plane sound";
    }

}
