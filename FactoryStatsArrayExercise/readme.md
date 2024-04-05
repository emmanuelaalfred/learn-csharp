# Factory Production Exercise

Given the following data

|  Day  | Factory 1   | Factory 2   | Factory 3   | Factory 4   | Factory 5   |
|-------|------------:|------------:|------------:|------------:|------------:|
| Day 1 | 130         | 225         | 155         | 165         | 145         |
| Day 2 | 134         | 241         | 153         | 161         | 146         |
| Day 3 | 129         | 244         | 149         | 157         | 145         |
| Day 4 | 131         | 239         | 150         | 161         | 151         |
| Day 5 | 120         | 209         | 148         | 130         | 140         |
| Day 6 | 72          | 40          | 47          | 66          | 44          |
| Day 7 | 22          | 28          | 21          | 26          | 23          |

## Tasks

### Task  1

Write a program to track the number of items produced in five different factories over a seven-day period. Use a two-dimensional array called `production` to store the data.

### Task 2

Calculate and present the average production for each factory over the week.

### Task 3

Calculate and present the total production for each day over the week.

## Stater code


### C Sharp

```csharp
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
```

PHP

```php
<?php

/**
 * Print the production data for each factory over seven days.
 *
 * @param array $production A two-dimensional array storing the production data.
 * @return void
 */
function printProduction($production) {
    echo "Day\t";
    
    foreach ($production[0] as $factory => $value) {
        echo "Factory " . ($factory + 1) . "\t";
    }
    echo "\n";

    foreach ($production as $day => $productions) {
        echo "Day " . ($day + 1) . ":\t";
        foreach ($productions as $prod) {
            echo $prod . "\t";
        }
        echo "\n";
    }
}

/**
 * The main function to execute the program.
 *
 * @return void
 */
function main() {
    $production = [
        [130, 225, 155, 165, 145],
        [134, 241, 153, 161, 146],
        [129, 244, 149, 157, 145],
        [131, 239, 150, 161, 151],
        [120, 209, 148, 130, 140],
        [72, 40, 47, 66, 44],
        [22, 28, 21, 26, 23]
    ];
    printProduction($production);

    // Task 2: Calculate and present the average production for each factory over the week.

    // Task 3: Calculate and present the total production for each day over the week.
}

// Execute the main function
main();
?>
```

## Online Compilers

These links will take you to the respective online IDEs where you can write, run, and test code in different programming languages.

1. **Repl.it**: [https://replit.com](https://replit.com)
   - Supports over 50 programming languages.

2. **CodeSandbox**: [https://codesandbox.io](https://codesandbox.io)
   - Primarily focused on web development.

3. **Rextester**: [https://rextester.com](https://rextester.com)
   - Supports a wide range of languages.

4. **Ideone**: [https://ideone.com](https://ideone.com)
   - Supports over 60 programming languages.

5. **Paiza.IO**: [https://paiza.io](https://paiza.io)
   - Supports various programming languages.

6. **OnlineGDB**: [https://www.onlinegdb.com](https://www.onlinegdb.com)  
   - Supports C, C++, Java, Python, and more.

7. **JDoodle**: [https://www.jdoodle.com](https://www.jdoodle.com)
   - Supports various programming languages.

---