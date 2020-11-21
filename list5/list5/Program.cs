using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Xml.Schema;

namespace list5
{

    public static class StringExtension
    {
        public static string MyStringConversion(this string text)
        {
            

            String convertedString = "";
            int ascii;
            for (int i = 0; i < text.Length; i++)
            {
                if (i % 2 != 0)
                {
                    if (text[i] >= 'A' && text[i] <= 'Z')
                    {
                        convertedString += text[i];
                    }
                    else if (text[i] >= 'a' && text[i] <= 'z')
                    {
                        ascii = text[i] - ('a' - 'A');
                        convertedString += (char)ascii;
                    }
                    else
                    {
                        convertedString += '.';
                    }
                }
                else
                {
                    if (text[i] >= 'A' && text[i] <= 'Z')
                    {
                        ascii = text[i] + ('a' - 'A');
                        convertedString += (char)ascii;
                    }
                    else if (text[i] >= 'a' && text[i] <= 'z')
                    {
                        convertedString += text[i];
                    }
                    else
                    {
                        convertedString += '.';
                    }
                }
                
            }

            return convertedString;
        }
    }
    public class MixedNumber
    {
        public int Integer { get; set; } = 0;
        private int numerator  = 0;
        private int denominator  = 1;
        public static int Counter { get; private set; } = 0;

        public int Numerator { get { return numerator; } set { numerator = value; ReduceFranction(this); } }
        public int Denominator { get { return denominator; } set { denominator = value; ReduceFranction(this); } }

        public MixedNumber() 
        { }

        public MixedNumber(double fraction)
        {
            String[] sFraction = fraction.ToString().Split(',');
            Integer = Int32.Parse(sFraction[0]);
            numerator = Int32.Parse(sFraction[1]);
            String denominator = "1";
            for (int i = 0; i < sFraction[1].Length; i++)
            {
                denominator += "0";
            }

            this.denominator = Int32.Parse(denominator);
            ReduceFranction(this);
        }

        public MixedNumber(int integer) : 
            this(integer, 0, 0)
        { }

        public MixedNumber(int numerator, int denominator) : 
            this(0, numerator, denominator)
        { }
        
        public MixedNumber(int integer, int numerator, int denominator)
        {
            this.Integer = integer;
            if (numerator < 0) { 
                this.numerator = -numerator;
                Counter++;
            }
            else 
            { 
                this.numerator = numerator;
            }
            if (denominator < 0) 
            { 
                this.denominator = -denominator;
                Counter++;
            }
            else 
            { 
                this.denominator = denominator; 
            }
            
            ReduceFranction(this);
        }

        public static MixedNumber operator +(MixedNumber num1, MixedNumber num2)
        {
            MixedNumber num = new MixedNumber();
            num.Integer = num1.Integer + num2.Integer;
            num.numerator = num1.numerator * num2.denominator + num2.numerator * num1.denominator;
            num.denominator = num1.denominator * num2.denominator;

            return ReduceFranction(num);
        }

        private static MixedNumber ReduceFranction (MixedNumber num)
        {
            Boolean isReducing = false;
            Boolean isChanging = false;
            MixedNumber result = new MixedNumber();
            result.Integer = num.Integer;

            if (num.denominator == 0)
            {
                isChanging = true;
                num.denominator = 1;
                num.numerator = 0;
            }

            if (num.numerator > num.denominator)
            {
                isReducing = true;
                int i = num.numerator / num.denominator;
                result.Integer += + i;
                num.numerator = num.numerator - num.denominator * i;
            }
            
            for (int i = num.numerator; i>0; i--)
            {
                if (num.numerator % i == 0 && num.denominator % i == 0)
                {
                    isReducing = true;
                    num.numerator /= i;
                    num.denominator /= i; 
                }
            }

            result.numerator = num.numerator;
            result.denominator = num.denominator;

            if (isReducing) { Counter++; }
            if (isChanging) { Counter++; }

            return result;
        }

        public override string ToString()
        {
            //return (Integer + (double)Numerator / (double)Denominator).ToString();
            String result = "";
            if(Integer == 0)
            {
                result = numerator + "/" + denominator;
            }
            else
            {
                result = Integer + " " + numerator + "/" + denominator;
            }
            return result;
            
        }


    }

    class Program
    {
        public static void Task1()
        {
            Task(1);
            Console.WriteLine("Assigning to mixed numbers: ");
            MixedNumber num1 = new MixedNumber(34, 56);
            Console.WriteLine("num1 = " + num1.ToString());
            MixedNumber num2 = new MixedNumber(2, 31, 45);
            Console.WriteLine("num2 = " + num2.ToString());
            MixedNumber fraction = num1 + num2;
            Console.WriteLine("num1 + num2 = " + fraction);
            Console.WriteLine("\nTaking double as paramiter: 5.734");
            MixedNumber myDoubleNumber = new MixedNumber(5.734);
            Console.WriteLine("After assighning to mixed number = " + myDoubleNumber);
            MixedNumber test = new MixedNumber(3, 2, 5);
            Console.WriteLine("\nNew value: num 3 = " + test.ToString());
            test.Denominator = 6;
            Console.WriteLine("After changing denominator to 6:\nnum3 = " + test.ToString());
            Console.WriteLine("Counter: " + MixedNumber.Counter);

        }
        public static void Task2()
        {
            Task(2);
            String example = "qwert3456SDFGHJ";
            System.Console.WriteLine("String: qwert3456SDFGHJ");
            System.Console.WriteLine("After conversion: " + example.MyStringConversion());
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
        }
    }
}
