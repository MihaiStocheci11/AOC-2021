using System;
using System.Collections.Generic;
using System.IO;

namespace Level1
{
    class Part2
    {
        static void Main(string[] args)
        {
            string textFile = @"C:\Users\Mihai\source\Repos\AOC\Level1\Level1\part 1\input.txt";
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

                   
                    for (int i = 2; i <= length-2; i++)
                    {
                        int prev_sum = numbers[i - 2] + numbers[i-1] + numbers[i];
                        int currentSum = numbers[i - 1] + numbers[i] + numbers[i + 1];
                        Console.WriteLine(currentSum);
                        if (prev_sum < currentSum)
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
