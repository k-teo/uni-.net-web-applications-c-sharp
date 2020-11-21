using list6.Vehicles;
using System;

namespace list6
{
    class Program
    {
        public static int CalculateTotalLoadCapacity(Vehicle[] arr)
        {
            int sum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] is Truck)
                {
                    Truck truck = (Truck)arr[i];
                    sum += truck.LoadCapasity;
                }
            }
            return sum;
        }

        public static void Task1()
        {
            Task(1);
            Vehicle[] vehiclesArray = new Vehicle[6]
            {
                new Bicycle("Trek", "Blue", 29.0, 2),
                new Car("BMW", "Black", 4.0, 20000, 5, 5),
                new Car("Lexus", "Red", 3.0, 700, 5, 5),
                new Truck("Volvo", "White", 7.7, 50000, 5000, "tow truck"),
                new Truck("MAN", "White", 9.2, 200000, 8000, "tank truck"),
                new Truck("Mercedes", "White", 12.6, 3000, 6000, "box truck")
            };
            Console.WriteLine("Method ToString(): \n" + vehiclesArray[0].ToString() + "\n" + vehiclesArray[1].ToString() + "\n" + vehiclesArray[3].ToString());

            Bicycle bicycle = (Bicycle)vehiclesArray[0];
            Car car = (Car)vehiclesArray[1];
            Truck truck = (Truck)vehiclesArray[3];

            Console.WriteLine("\nUnique methods: \nBicycle: ");
            bicycle.BicycleMethod();
            Console.WriteLine("Car: ");
            car.CarMethod();
            Console.WriteLine("Truck: ");
            truck.TruckMethod();


            Console.WriteLine("\nLoad Capacity: " + CalculateTotalLoadCapacity(vehiclesArray) + " in an array: \n");
            for (int i = 0; i < vehiclesArray.Length; i++)
            {
                Console.WriteLine(vehiclesArray[i].ToString());
            }
        }

        public static void PrintColor(Object[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if(arr[i] is TwoInterfacesClass)
                {
                    IHasInterior withInterface = (IHasInterior)arr[i];
                    Console.WriteLine(withInterface.Color);
                }
                else { Console.WriteLine("no color"); }
            }
        }
        public static void Task2()
        {
            Task(2);
            Console.WriteLine("Colors: ");
            Object[] colors = new Object[6]
            {
                new OneInterfaceClass(),
                new TwoInterfacesClass(),
                new OneInterfaceClass(),
                new TwoInterfacesClass(),
                new TwoInterfacesClass(),
                new OneInterfaceClass()
            };

            PrintColor(colors);
        }
        public static void Task(int num)
        {
            if (num == 1)
            {
                Console.WriteLine("Task {0} \n", num);
            }
            else
            {
                Console.WriteLine("\n ------------------------------ \n \nTask {0} \n", num);
            }
        }
        static void Main(string[] args)
        {
            Task1();
            Task2();
        }
    }
}
