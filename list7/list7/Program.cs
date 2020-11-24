using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace list7
{
    class Program
    {
        public static string[] ReadTextFile()
        {
            string textFile = Console.ReadLine();
            string[] lines = new string[0];
            /*
            if (File.Exists(textFile))
            {
                lines = File.ReadAllLines(textFile);
            }
            else
            {
                Console.WriteLine("Incorrect path");
            } */
            
            try
            {
                lines = File.ReadAllLines(textFile);
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File does not exsits");
            }
            catch (DirectoryNotFoundException)
            {
                Console.WriteLine("Incorrect path");
            }
            catch (NotSupportedException)
            {
                Console.WriteLine("No possible to read this path");
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("No access to file");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return lines;
        }
        public static void CreateDictionary(string[] lines)
        {
            Dictionary<string, int> words = new Dictionary<string, int>();
            string pattern = @"([a-zA-Z]+)";
            foreach (string line in lines)
            {
                foreach (Match match in Regex.Matches(line, pattern))
                {
                    if(!words.ContainsKey(match.Value.ToLower()))
                    {
                        words.Add(match.Value.ToLower(), 1);
                    }
                    else
                    {
                        words[match.Value.ToLower()] += 1;
                    }
                    /*
                    try
                    {
                        words.Add(match.Value.ToLower(), 1);
                    }
                    catch
                    {
                        words[match.Value.ToLower()] += 1;
                    }
                    */
                }
            }
            SortAndPrint(words, 10);
        }
        public static void PrintDictionary(Dictionary<string, int> words)
        {
            foreach (KeyValuePair<string, int> word in words)
            {
                Console.WriteLine("{0}, uses: {1}", word.Key, word.Value);
            }
        }
        public static void SortAndPrint(Dictionary<string, int> words, int length)
        {
            List<KeyValuePair<string, int>> wordsList = words.ToList();
            wordsList.Sort((x, y) => y.Value.CompareTo(x.Value));
            int counter = 0;
            foreach (KeyValuePair<string, int> word in wordsList)
            {
                if (counter < length)
                {
                    Console.WriteLine("{0}, uses: {1}", word.Key, word.Value);
                }
                else
                {
                    break;
                }
                counter++;
            }
        }
        public static void Task1()
        {
            CreateDictionary(ReadTextFile());
        }
        static void Main(string[] args)
        {
            Task1();
        }
    }
}
