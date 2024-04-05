using System;

class FactoryProduction
{
    /// <summary>
    /// Print the production data for each factory over seven days.
    /// </summary>
    /// <param name="production">A two-dimensional array storing the production data.</param>
    static void PrintProduction(int[,] production)
    {
        Console.Write("Day\t");

        for (int factory = 0; factory < production.GetLength(1); factory++)
            Console.Write($"Factory {factory + 1}\t");
        Console.WriteLine();

        for (int day = 0; day < production.GetLength(0); day++)
        {
            Console.Write($"Day {day + 1}:\t");
            for (int factory = 0; factory < production.GetLength(1); factory++)
                Console.Write($"{production[day, factory]}\t");
            Console.WriteLine();
        }
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

        // Task 3: Calculate and present the total production for each day over the week.
    }
}