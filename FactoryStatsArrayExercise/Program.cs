using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

class FactoryProduction
{
    /// <summary>
    /// Print the production data for each factory over seven days.
    /// </summary>
    /// <param name="production">A two-dimensional array storing the production data.</param>
    static void PrintProduction(int[,] production)
    {
        DisplayRowHeadings(production);

        for (int day = 0; day < production.GetLength(0); day++)
        {
            DisplayDayRow(production, day);
        }
    }

    static void Display2DArray(int[,] array)
    {
        for (int rowIndex = 0; rowIndex < array.GetLength(0); rowIndex++)
        {
            DisplayRowColumns(array, rowIndex);
        }
    }
    static void DisplayRowColumns(int[,] array, int rowIndex)
    {
        for (int columnIndex = 0; columnIndex < array.GetLength(1); columnIndex++)
            Console.Write($"{array[rowIndex, columnIndex]}\t");
        Console.WriteLine();
    }

    static int SumRowColumns(int[,] array, int rowIndex)
    {
        int sum = 0;
        for (int columnIndex = 0; columnIndex < array.GetLength(1); columnIndex++)
            sum += array[rowIndex, columnIndex];
        return sum;
    }

    static int SumColumnRows(int[,] array, int columnIndex)
    {
        int sum = 0;
        for (int rowIndex = 0; rowIndex < array.GetLength(0); rowIndex++)
            sum += array[rowIndex, columnIndex];
        return sum;
    }

    private static void DisplayDayRow(int[,] production, int day)
    {
        Console.Write($"Day {day + 1}:\t");
        for (int factory = 0; factory < production.GetLength(1); factory++)
            Console.Write($"{production[day, factory]}\t");
        Console.WriteLine();
    }

    private static void DisplayRowHeadings(int[,] production)
    {
        Console.Write("Day\t");
        for (int factory = 0; factory < production.GetLength(1); factory++)
            Console.Write($"Fac {factory + 1}\t");
        Console.WriteLine();
    }

    /// <summary>
    /// The main method to execute the program.
    /// </summary>
    /// <param name="args">Command-line arguments.</param>
    static void Main(string[] args)
    {
        int[,] production = {
            {130, 225, 155, 165, 145},
            {134, 241, 153, 161, 146},
            {129, 244, 149, 157, 145},
            {131, 239, 150, 161, 151},
            {120, 209, 148, 130, 140},
            {72, 40, 47, 66, 44},
            {22, 28, 21, 26, 23}
        };
        PrintProduction(production);

        // Task 2: Calculate and present the average production for each factory over the week.
        for (int factory = 0; factory < production.GetLength(1); factory++)
        {
            int sum = 0;
            for (int day = 0; day < production.GetLength(0); day++)
            {
                sum += (production[day, factory]);

            }
            Console.WriteLine((double)sum / production.GetLength(0));
        }


        // Task 3: Calculate and present the total production for each day over the week.
        Console.WriteLine("Task 3: Calculate and present the total production for each day over the week.");
        for (int day = 0; day < production.GetLength(0); day++)
        {
            int total = 0;
            for (int factory = 0; factory < production.GetLength(1); factory++)
            {
                total += production[day, factory];
            }
            Console.WriteLine(total);

        }

        // Task 4: Calculate and present the total production for each factory over the week.

        Console.WriteLine("Task 4: Calculate and present the total production for each factory over the week.");
        for(int columnIndex=0; columnIndex < production.GetLength(1); columnIndex++)
        {
            Console.WriteLine(SumColumnRows(production, columnIndex));
        }

    }
}