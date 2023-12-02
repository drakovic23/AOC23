namespace AOC_2
{
    internal class Program
    {
        static void partOne()
        {
            var inputFile = File.ReadAllLines("../../../input.txt");
            var input = new List<string>(inputFile);

            int maxRed = 12;
            int maxGreen = 13;
            int maxBlue = 14;

            char[] delimiterChars = { ':', ';' };
            int sumOfId = 0;

            foreach(var line in input)
            {
                string[] strArr = line.Split(delimiterChars);
                string id = "";
                if (char.IsDigit(line[5]))
                    id += line[5];
                if (char.IsDigit(line[6]))
                    id += line[6];
                if (char.IsDigit(line[7]))
                    id += line[7];

                bool possible = true;
                foreach(var str in strArr)
                {
                    int i;
                    if ( (i = str.IndexOf("green")) != -1)
                    {
                        string value = "";
                        if (char.IsDigit(str[i - 3]))
                            value += str[i - 3];
                        if (char.IsDigit(str[i - 2]))
                            value += str[i - 2];

                        if(int.Parse(value) > maxGreen)
                        {
                            possible = false;
                            break;
                        }

                    }

                    if ((i = str.IndexOf("blue")) != -1)
                    {
                        string value = "";
                        if (char.IsDigit(str[i - 3]))
                            value += str[i - 3];
                        if (char.IsDigit(str[i - 2]))
                            value += str[i - 2];

                        if (int.Parse(value) > maxBlue)
                        {
                            possible = false;
                            break;
                        }
                    }

                    if ((i = str.IndexOf("red")) != -1)
                    {
                        string value = "";
                        if (char.IsDigit(str[i - 3]))
                            value += str[i - 3];
                        if (char.IsDigit(str[i - 2]))
                            value += str[i - 2];

                        if (int.Parse(value) > maxRed)
                        {
                            possible = false;
                            break;
                        }
                    }
                   
                }

                if (possible)
                {
                    sumOfId += int.Parse(id);
                }
                    
            }

        Console.WriteLine($"Sum of possible games: {sumOfId}");
        }

        static void partTwo()
        {
            var inputFile = File.ReadAllLines("../../../input.txt");
            var input = new List<string>(inputFile);

            char[] delimiterChars = { ':', ';' };
            int sumOfPower = 0;

            foreach (var line in input)
            {
                string[] strArr = line.Split(delimiterChars);

                int maxRed = 0;
                int maxGreen = 0;
                int maxBlue = 0;

                foreach (var str in strArr)
                {
                    int i;
                    if ((i = str.IndexOf("green")) != -1)
                    {
                        string value = "";
                        if (char.IsDigit(str[i - 3]))
                            value += str[i - 3];
                        if (char.IsDigit(str[i - 2]))
                            value += str[i - 2];

                        if (int.Parse(value) > maxGreen)
                        {
                            maxGreen = int.Parse(value);
                        }

                    }

                    if ((i = str.IndexOf("blue")) != -1)
                    {
                        string value = "";
                        if (char.IsDigit(str[i - 3]))
                            value += str[i - 3];
                        if (char.IsDigit(str[i - 2]))
                            value += str[i - 2];

                        if (int.Parse(value) > maxBlue)
                        {
                            maxBlue = int.Parse(value);
                        }

                    }

                    if ((i = str.IndexOf("red")) != -1)
                    {
                        string value = "";
                        if (char.IsDigit(str[i - 3]))
                            value += str[i - 3];
                        if (char.IsDigit(str[i - 2]))
                            value += str[i - 2];

                        if (int.Parse(value) > maxRed)
                        {
                            maxRed = int.Parse(value);
                        }

                    }

                }

                int power = maxRed * maxGreen * maxBlue;
                sumOfPower += power;

            }

            Console.WriteLine($"Sum of the power of these sets: {sumOfPower}"); 
        }

        static void Main(string[] args)
        {
            partOne();
            partTwo();
        
            
        }
    }
}