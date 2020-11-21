using System;

namespace list3
{
    class Program
    {
        public static void Task1()
        {
            Task(1);

            int n, m;
            Random rnd = new Random();

            Console.WriteLine("Choose paramiters n, m for two-dimentional array nxm:");
            n = int.Parse(Console.ReadLine());
            m = int.Parse(Console.ReadLine());

            // two-dimentional array type
            int[,] arr = new int[n, m];

            // filling in with random numbers
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    arr[i, j] = rnd.Next(0, 100);
                }
            }

            Console.WriteLine("Two-dimenentional array type {0}x{1} with random numbers:", n, m);
            for (int i = 0; i < n; i++)
            {
                Console.Write("[");
                for (int j = 0; j < m; j++)
                {
                    if (j == m - 1)
                    {
                        Console.Write(arr[i, j] + "]");
                    }
                    else
                    {
                        Console.Write(arr[i, j] + ", ");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            int temp;

            // reverse
            for (int i = 0; i < n/2; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    temp = arr[i, j];
                    arr[i, j] = arr[n - i - 1, j];
                    arr[n - i - 1, j] = temp;
                }
            }

            Console.WriteLine("Reverse");
            for (int i = 0; i < n; i++)
            {
                Console.Write("[");
                for (int j = 0; j < m; j++)
                {
                    if (j == m - 1)
                    {
                        Console.Write(arr[i, j] + "]");
                    }
                    else
                    {
                        Console.Write(arr[i, j] + ", ");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            // array of arrays type
            int[][] arr2 = new int[n][];

            // filling in with random numbers
            for (int i = 0; i < n; i++)
            {
                arr2[i] = new int[m];
                for (int j = 0; j < m; j++)
                {
                    arr2[i][j] = rnd.Next(0, 100);
                }
            }

            Console.WriteLine("Array of array type {0}x{1} with random numbers:", n, m);
            for (int i = 0; i < n; i++)
            {
                Console.Write("[");
                for (int j = 0; j < m; j++)
                {
                    if (j == m - 1)
                    {
                        Console.Write(arr2[i][j] + "]");
                    }
                    else
                    {
                        Console.Write(arr2[i][j] + ", ");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            int[] temp2;
            // reverse
            for (int i = 0; i < n / 2; i++)
            {               
                temp2 = arr2[i];
                arr2[i] = arr2[n - i - 1];
                arr2[n - i - 1] = temp2;
            }

            Console.WriteLine("Reverse");
            for (int i = 0; i < n; i++)
            {
                Console.Write("[");
                for (int j = 0; j < m; j++)
                {
                    if (j == m - 1)
                    {
                        Console.Write(arr2[i][j] + "]");
                    }
                    else
                    {
                        Console.Write(arr2[i][j] + ", ");
                    }
                }
                Console.WriteLine();
            }
        }
        public static void Task2((string, string, int, double) user)
        {
            Task(2);

            (string name, string surname, int age, double salary) userData = user;

            //1
            Console.WriteLine("Name = {0}, Surname = {1}, Age = {2}, Salary = {3}", userData.name, userData.surname, userData.age, userData.salary);
            //2
            Console.WriteLine($"Name = {userData.name}, Surname = {userData.surname}, Age = {userData.age}, Salary = {userData.salary}");
            //3
            Console.WriteLine("(Name, Surname, Age, Salary) = {0}", userData);          
        }

        public static void Task3()
        {
            Task(3);

            int @class = 0;
            Console.WriteLine("Value of variable class = {0}", @class);
        }

        public static void Task4()
        {
            Task(4);

            int[] arr = new int[5] { 10, 5, 2, 4, 3 };
            Console.Write("Array: ");
            printArray(arr);

            arr.SetValue(1, 0);
            Console.WriteLine("Changing value of 0 element for 1:");
            printArray(arr);

            Array.Sort(arr);
            Console.WriteLine("Sorting: ");
            printArray(arr);

            Array.Reverse(arr);
            Console.WriteLine("Reverse");
            printArray(arr);

            int index = Array.IndexOf(arr, 2);
            int upperBound = arr.GetUpperBound(0);
            int lowerBound = arr.GetLowerBound(0);
            Console.WriteLine("Index of value 2: {0}, upperBound: {1}, lowerBound: {2}.", index, upperBound, lowerBound);

            int[] emptyArray = Array.Empty<int>();
            Console.Write("Empty array: ");
            printArray(emptyArray);

        }
        public static void printArray(int[] arr)
        {
            Console.Write("(");
            int i = 0;
            foreach (int item in arr)
            {
                if (i != arr.Length - 1)
                {
                    Console.Write("{0}, ", item);
                }
                else
                {
                    Console.Write(item);
                }
                i++;
            }
            Console.WriteLine(")");
        }

        public static void Task5(object user)
        {
            Task(5);
            Console.WriteLine(user.ToString());
        }
        public static void Task(int num)
        {
            if (num == 1)
            {
                Console.WriteLine("Task {0} \n", num);
            }
            else
            {
                Console.WriteLine("\n ------------------------------ \n \n Task {0} \n", num);
            }
        }


        static void Main(string[] args)
        {
            Task1();
            Task2(("Jan", "Kowalski", 40, 5500.50));
            Task3();
            Task4();
            var aUserData = new { Name = "Jan", Surname = "Kowalski", Age = 40, Salary = 5500.50 };
            Task5(aUserData);
        }
    }

   
}
