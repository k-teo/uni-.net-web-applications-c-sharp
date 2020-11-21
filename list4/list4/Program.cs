#define task1
#define task2
#define task3
#define num
#define real
#define text
#define other


using System;
using System.Linq;


namespace list4
{
    class Program
    {
        public static void Task1 ()
        {
            Task(1);
            String comment1 = "Type paramiter x";
            String comment2 = "Type paramiter y";

            Console.WriteLine("a)");
            (int xtuple, int ytuple) = a_GetFromConsoleXY(comment1, comment2);
#if(task1)
            Console.WriteLine("X = {0} Y = {1}\n", xtuple, ytuple);
#endif
            Console.WriteLine("\nb)");
            int x, y;
            b_GetFromConsoleXY(out x, out y, comment1, comment2);
#if(task1)
            Console.WriteLine("X = {0} Y= {1}\n", x, y);
#endif
        }
        public static (int x, int y) a_GetFromConsoleXY (String comment1, String comment2)
        {
            Console.WriteLine(comment1);
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(comment2);
            int y = Convert.ToInt32(Console.ReadLine());

            return (x, y);
        }
        public static void b_GetFromConsoleXY(out int x, out int y, String comment1, String comment2)
        {
            Console.WriteLine(comment1);
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(comment2);
            y = Convert.ToInt32(Console.ReadLine());
        }

        public static void Task2()
        {
            Task(2);
#if(task2)
            Console.WriteLine("My default values: surnme = \" \", borderMark = \"-\", borderWidth = 3, minBorderWidth = 26\n");
            Console.WriteLine("Exmaple:");
#endif
            DrawCard("Ryszard", "Rys", "X", 2, 20);
#if(task2)
            Console.WriteLine("\nOnly name (Leon):");
#endif
            DrawCard("Leon");
#if(task2)
            Console.WriteLine("\nOnly name (Egeniusz) and the border width (1):");
#endif
            DrawCard("Eugeniusz", borderWidth: 1);
#if(task2)
            Console.WriteLine("\nMinimal border width is too small: \n(surnameLength = 8, borderWidth = 10 -> 28 and minBorderLength = 26");
#endif
            DrawCard("Adam", "Kowalski", ".", 10, 22);
#if(task2)
            Console.WriteLine("\nMore than one sign in the mark border:");
#endif
            DrawCard("Klaudia", "Teodorowicz", "*-", 5, 31);
            
        }
        public static void DrawCard(String name, String surname = " ", String borderMark = "-", int borderWidth = 3, int minBorderWidth = 26)
        {
            minBorderWidth = borderLength(name, surname, borderWidth, minBorderWidth);
            int upperLowerBorder = borderWidth;
            DrawLine(upperLowerBorder, borderMark, minBorderWidth);
            Console.WriteLine();
            DrawStringWithBorder(name, borderMark, borderWidth, minBorderWidth);
            if (surname != " ") { DrawStringWithBorder(surname, borderMark, borderWidth, minBorderWidth); }
            DrawLine(upperLowerBorder, borderMark, minBorderWidth);
            Console.WriteLine();
        }
        public static int borderLength(String name, String surname, int borderLength, int minBorderWidth)
        {
            String text = name.Length > surname.Length ? name : surname;
            if (minBorderWidth - (borderLength * 2 + text.Length) >= 0) { return minBorderWidth; }
            else { return minBorderWidth - (minBorderWidth - (borderLength * 2 + text.Length)); }
        }
        public static void DrawLine (int number, String borderMark, int lineLength)
        {
            String result = "";
            String tail = "";
            int length = lineLength / borderMark.Length;
            if (lineLength % borderMark.Length != 0)
            {
                for (int i = 0; i < lineLength % borderMark.Length; i++)
                {
                    tail += borderMark[i];
                }
            }
            for (int i = 0; i < number; i++)
            {
                result += String.Concat(Enumerable.Repeat(borderMark, length)) + tail;
                if (i != number - 1) { result += "\n"; }
                
            }
            Console.Write(result);
        }
        public static void DrawStringWithBorder(String text, String borderMark, int borderLength, int lineLength)
        {
            int spaces = lineLength - (borderLength * 2 + text.Length);
            DrawLine(1, borderMark, borderLength);
            if (spaces % 2 == 0) { Console.Write(String.Concat(Enumerable.Repeat(" ", spaces / 2))); }
            else { Console.Write(String.Concat(Enumerable.Repeat(" ", spaces / 2 + 1))); }
            Console.Write(text);
            Console.Write(String.Concat(Enumerable.Repeat(" ", spaces / 2)));
            DrawLine(1, borderMark, borderLength);
            Console.WriteLine();
        }
        public static void Task3()
        {
            Task(3);
            CountMyTypes(1, 2, 19, -7.2, 7.2, 10.99, "maj", "majowka", "agawa");
        }
        public static (int evenInt, int posDouble, int string5, int others) CountMyTypes (params Object[] tab)
        {
            int evenIntegers = 0;
            int positiveRealNumabers = 0;
            int stringOfAtLeast5Characters = 0;
            int others = 0;

            for (int i = 0; i < tab.Length; i++)
            {
                Console.Write("Paramiter {0}: ", i+1);
                switch (tab[i])
                {
                    case int num when num % 2 == 0:
                        evenIntegers++;
#if(num && task3)
                        Console.WriteLine("{0} - even integer ({1})", num, evenIntegers);
#endif
                        break;
                    case double real when real > 0:
                        positiveRealNumabers++;
#if (real && task3)
                        Console.WriteLine("{0} - positive real number ({1})", real, positiveRealNumabers);
#endif
                        break;
                    case String text when text.Length >= 5:
                        stringOfAtLeast5Characters++;
#if (text && task3)
                        Console.WriteLine("{0} - string with at least 5 characters ({1})", text, stringOfAtLeast5Characters);
#endif
                        break;
                    default:
                        others++;
#if (other && task3)
                        Console.WriteLine("{0} - unknown type ({1})", Convert.ToString(tab[i]), others);
#endif
                        break;
                }

            }
#if (task3)
            Console.WriteLine("\nTypes: ");
            Console.WriteLine("- even integers: " + evenIntegers);
            Console.WriteLine("- positive real numbers: " + positiveRealNumabers);
            Console.WriteLine("- even integers: " + stringOfAtLeast5Characters);
            Console.WriteLine("- other types: " + others);
#endif
            return (evenIntegers, positiveRealNumabers, stringOfAtLeast5Characters, others);
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
            Task2();
            Task3();
        }
    }
}
