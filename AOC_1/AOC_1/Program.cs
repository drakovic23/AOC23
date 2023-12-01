using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using static System.Net.Mime.MediaTypeNames;

namespace AOC_1
{
    internal class Program
    {
        static void partOne()
        {
            var inputFile = File.ReadAllLines("../../../input.txt");
            var input = new List<string>(inputFile);
            int sum = 0;

            foreach(var line in input)
            {
                List<int> digits = new List<int>();
                string num = "";
                foreach(var character in line)
                {
                    if(Char.IsDigit(character))
                    {
                        digits.Add(Int32.Parse(character.ToString()));
                    }
                }

                num += digits[0];
                num += digits[digits.Count - 1];
                sum += Int32.Parse(num);
            }

            Console.WriteLine(sum);
        }

        static void partTwo()
        {
            var inputFile = File.ReadAllLines("../../../input.txt");
            var input = new List<string>(inputFile);
            int sum = 0;

            Dictionary<string, int> keyValuePairs = new Dictionary<string, int>
            {
                { "one", 1 },
                { "two", 2 },
                { "three", 3 },
                { "four", 4 },
                { "five", 5 },
                { "six", 6 },
                { "seven", 7 },
                { "eight", 8 },
                { "nine", 9 }
            };

            foreach (var line in input)
            {

                SortedDictionary<int, int> digits = new SortedDictionary<int, int>();
                string num = "";

                foreach(var keyValue in keyValuePairs)
                {
                    int i = 0;

                    if (line.ToLower().Contains(keyValue.Key)) //to address duplicates
                    {
                        while ( (i = line.IndexOf(keyValue.Key, i)) != -1 )
                        {
                            digits.Add(i, keyValue.Value);
                            i++;
                        }
                    }
                }

                for (int i = 0; i < line.Length; i++)
                {
                    if (char.IsDigit(line[i]))
                    {
                        int value = int.Parse(line[i].ToString());
                        digits.Add(i, value);
                    }
                }

                num += digits.Values.First();
                num += digits.Values.Last();
                sum += int.Parse(num);
            }

            Console.WriteLine(sum);
        }
        static void Main(string[] args)
        {
            partOne();
            partTwo(); //not 54673 -- too low

        }
    }
}