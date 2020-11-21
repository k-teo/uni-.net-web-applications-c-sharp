using System;

namespace list6.Vehicles
{
    public abstract class MotorVehicle : Vehicle
    {
        public double EngineCapacity { get; set; }
        public int Milometer { get; set; }
        public MotorVehicle(String brand, String color, double engine, int milometer) : base(brand, color)
        {
            EngineCapacity = engine;
            Milometer = milometer;
        }
        public abstract void SomeMethodInMotorVehicle();
        public override string ToString()
        {
            return base.ToString() + ", engine capacity: " + EngineCapacity + ", milometer: " + Milometer;
        }
    }
}
