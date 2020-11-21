using System;

namespace list6.Vehicles
{
    public class Truck : MotorVehicle
    {
        public int LoadCapasity { get; set; }
        public String Purpose { get; set; }
        public Truck(String brand, String color, double engine, int milometer, int loadCapacity, String purpose) : base(brand, color, engine, milometer)
        {
            LoadCapasity = loadCapacity;
            Purpose = purpose;
        }
        public override void WhoAmI()
        {
            Console.WriteLine("I am a truck, model: " + Brand);
        }
        public override void SomeMethodInMotorVehicle()
        {
            Console.WriteLine("I am overriding method from MotorVehicle in Car class.");
        }
        public void TruckMethod()
        {
            Console.WriteLine("It is a unique truck method");
        }
        public override string ToString()
        {
            return base.ToString() + ", load capacity: " + LoadCapasity + ", purpose: " + Purpose;
        }
    }
}
