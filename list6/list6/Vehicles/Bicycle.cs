using System;

namespace list6.Vehicles
{
    public class Bicycle : Vehicle
    {
        public double DiametrOfWheels { get; set; }
        public int BrakesNumber { get; set; }
        public Bicycle(String brand, String color, double diametr, int brakes) : base(brand, color)
        {
            DiametrOfWheels = diametr;
            BrakesNumber = brakes;
        }

        public override void WhoAmI()
        {
            Console.WriteLine("I am a bicycle, model: " + Brand);
        }
        public void BicycleMethod()
        {
            Console.WriteLine("It is a unique bicycle method");
        }
        public override string ToString()
        {
            return base.ToString() + ", diametr of wheels: " + DiametrOfWheels + ", number of brakes: " + BrakesNumber;
        }
    }
}
