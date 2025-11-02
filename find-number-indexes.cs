using System;
using System.Collections.Generic;

class Program
{
    // This method finds all indexes where the target number appears
    static List<int> FindTargetIndexes(int[] nums, int target)
    {
        List<int> indexes = new List<int>();

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == target)
                indexes.Add(i); // Add each matching index to the list
        }

        return indexes; // Return all matching indexes
    }

    static void Main()
    {
        // ⭐ NEW: Program introduction and header
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("=========================================");
        Console.WriteLine("Target Number Index Finder Program");
        Console.WriteLine("=========================================");
        Console.ResetColor();
        Console.WriteLine("This program lets you enter a list of numbers,");
        Console.WriteLine("then asks for a target number and shows all indexes where it appears.\n");

        List<int> numbers = new List<int>();
        Console.WriteLine("Enter numbers one by one (type 'done' to finish):");

        while (true)
        {
            string input = Console.ReadLine();

            if (input.ToLower() == "done")
                break;

            if (int.TryParse(input, out int number))
            {
                numbers.Add(number);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid input! Please enter a valid integer.");
                Console.ResetColor();
            }
        }

        if (numbers.Count == 0)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("No numbers were entered. Exiting program.");
            Console.ResetColor();
            return;
        }

        Console.Write("Enter the target number to find: ");
        string targetInput = Console.ReadLine();

        if (!int.TryParse(targetInput, out int target))
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Invalid target number! Exiting program.");
            Console.ResetColor();
            return;
        }

        List<int> resultIndexes = FindTargetIndexes(numbers.ToArray(), target);

        if (resultIndexes.Count > 0)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"The target number {target} was found at the following index(es):");
            Console.ResetColor();
            Console.WriteLine(string.Join(", ", resultIndexes));
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"The target number {target} was not found in the list.");
            Console.ResetColor();
        }
    }
}
