using System;

namespace list6.Vehicles
{
    public class Car : MotorVehicle
    {
        public int SeatsNumber { get; set; }
        public int DoorsNumber { get; set; }
        public Car(String brand, String color, double engine, int milometer, int seats, int doors) : base(brand, color, engine, milometer)
        {
            SeatsNumber = seats;
            DoorsNumber = doors;
        }
        public override void WhoAmI()
        {
            Console.WriteLine("I am a car, model: " + Brand);
        }

        public override void SomeMethodInMotorVehicle()
        {
            Console.WriteLine("I am overriding method from MotorVehicle in Car class.");
        }
        public void CarMethod()
        {
            Console.WriteLine("It is a unique car method");
        }
        public override string ToString()
        {
            return base.ToString() + ", number of seats: " + SeatsNumber + ", number of doors" + DoorsNumber;
        }
    }
}
