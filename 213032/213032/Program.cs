using System;
using System.Linq;

namespace LabTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task 1: Two-Dimensional Array:");
            int[,] arr2D = {
                {1, 2, 3},
                {4, 5, 6},
                {7, 8, 9}
            };
            Print2DArray(arr2D);

            Console.WriteLine("\nTask 2: Merge Array of Strings:");
            string[] strArray = { "hello", "and", "welcome", "to", "this", "demo!" };
            string mergedString = Merger(strArray);
            Console.WriteLine("Merged String: " + mergedString);

            Console.WriteLine("\nTask 3: Extract Words with Length 4-5 and Vowels:");
            string inputString = "hello world food demo words vowels abcde";
            string[] filteredWords = ExtractWords(inputString);
            Console.WriteLine("Filtered Words: " + string.Join(", ", filteredWords));

            Console.WriteLine("\nTask 4: Summarize Cafeteria Food Ratings:");
            int[] responses = { 2, 3, 3, 2, 4, 5, 3, 2, 4, 3, 2, 5, 1, 3, 4, 2, 3, 4, 2, 1, 3, 4, 3, 2, 4, 5, 4, 3, 3, 4, 5, 3, 2, 4, 2, 3, 4, 5, 3, 2 };
            SummarizeResponses(responses);

            Console.WriteLine("\nTask 5: Decimal to Binary and Binary to Decimal:");
            int decimalNumber = 25;
            string binaryResult = DecimalToBinary(decimalNumber);
            Console.WriteLine("Decimal to Binary: " + binaryResult);

            int binaryNumber = 11001;
            int decimalResult = BinaryToDecimal(binaryNumber);
            Console.WriteLine("Binary to Decimal: " + decimalResult);

            Console.WriteLine("\nTask 6: Rectangular Array for Test Marks:");
            int[,] testMarks = new int[5, 10]
            {
                { 85, 78, 90, 88, 76, 79, 85, 81, 83, 87 },
                { 80, 82, 85, 84, 89, 91, 78, 80, 82, 84 },
                { 75, 73, 78, 80, 79, 85, 87, 89, 84, 90 },
                { 90, 92, 91, 88, 87, 86, 90, 92, 89, 93 },
                { 88, 84, 85, 82, 81, 87, 88, 85, 89, 90 }
            };
            Print2DArray(testMarks);

            Console.ReadLine();
        }

        static void Print2DArray(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                Console.Write("Marks of student 1 are : ");
                for (int j = 0; j < arr.GetLength(1); j++)
                {

                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        static string Merger(string[] arr)
        {
            return string.Join(" ", arr);
        }

        static string[] ExtractWords(string str)
        {
            string[] words = str.Split(' ');
            return words.Where(w => w.Length >= 4 && w.Length <= 5 && w.Any(c => "aeiouAEIOU".Contains(c))).ToArray();
        }

        static void SummarizeResponses(int[] responses)
        {
            int[] frequency = new int[5];
            for (int i = 0; i < responses.Length; i++)
            {
                if (responses[i] >= 1 && responses[i] <= 5)
                {
                    frequency[responses[i] - 1]++;
                }
            }

            for (int i = 0; i < frequency.Length; i++)
            {
                Console.WriteLine($"Response {i + 1} given by: {frequency[i]} people");
            }
        }

        static string DecimalToBinary(int number)
        {
            return Convert.ToString(number, 2);
        }

        static int BinaryToDecimal(int binary)
        {
            return Convert.ToInt32(binary.ToString(), 2);
        }
    }
