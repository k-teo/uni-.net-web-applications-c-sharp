using System;

namespace list6.Vehicles
{
    public abstract class Vehicle
    {
        public String Brand { get; set; }
        public String Color { get; set; }
        public Vehicle(String brand, String color)
        {
            Brand = brand;
            Color = color;
        }
        public abstract void WhoAmI();
        public override string ToString()
        {
            return this.GetType().Name + ": brand: " + Brand + ", color: " + Color;
        }
    }
}
