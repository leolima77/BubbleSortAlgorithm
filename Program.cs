using System;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = { 4, 3, 7, 9, 1, 14, 47, 84, 14, 94 };

            for (int i = 1; i < input.Length-1; i++)
            {
                for (int j = 0; j < input.Length - i; j++)
                {
                    if (input[j] > input[j + 1])
                    {
                        int temp = input[j];
                        input[j] = input[j + 1];
                        input[j + 1] = temp;
                    }
                }
            }

            Console.WriteLine(input);
        }
    }
}
