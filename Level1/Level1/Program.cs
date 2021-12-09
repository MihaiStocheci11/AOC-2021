using System;
using System.Collections.Generic;
using System.IO;

namespace Level1
{
    class Program
    {
        static void Main(string[] args)
        {
            string textFile = @"C:\Users\Mihai\source\Repos\AOC\Level1\Level1\input.txt";
            if (File.Exists(textFile))
            {
                // Read file using StreamReader. Reads file line by line  
                using (StreamReader file = new StreamReader(textFile))
                {
                    int length = 0;
                    string ln;
                    int count = 0;
                    var numbers = new List<int> { };

                    while ((ln = file.ReadLine()) != null)
                    {
                        numbers.Add(Int32.Parse(ln));
                        length++;
                    }

                    for (int i = 1; i < length; i++)
                    {
                        // check item before
                        if (numbers[i] > numbers[i - 1])
                        {
                            count++;
                        }
                        file.Close();
                        Console.WriteLine($"File has {length} lines.");
                        Console.WriteLine(count);
                    }
                }
            }
        }
    }
}
