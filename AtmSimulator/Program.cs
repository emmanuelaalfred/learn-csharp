using System.Numerics;

namespace AtmSimulator;
static class Program
{
    static void Main()
    {
        int amount = GetUserAmount();

        if (amount >= 600)
        {
            Console.WriteLine("This ATM can only dispense amounts up to £600.");
            return;
        }

        if (IsAmountAMulitipleOf10(amount))
        {
            Console.WriteLine("This ATM can only dispense amounts in multiples of 10.");
            return;
        }

        Console.WriteLine($"Dispense ${amount}");
        DispenseNotes(amount);
    }

    private static int GetUserAmount()
    {
        Console.Write("Please enter the amount you would like to withdraw: ");
        string input = Console.ReadLine();
        Console.WriteLine();
        int amount = int.Parse(input);
        return amount;
    }

    private static void DispenseNotes(int amount)
    {
        int numberOf50 = amount / 50;
        amount -= 50 * numberOf50;

        int numberOf20 = amount / 20;
        amount -= 20 * numberOf20;

        int numberOf10 = amount / 10;


        if (numberOf50 != 0)
            Console.WriteLine($"Dispensing {numberOf50} x 50 notes");

        if (numberOf20 != 0)
            Console.WriteLine($"Dispensing {numberOf20} x 20 notes");

        if (numberOf10 != 0)
            Console.WriteLine($"Dispensing {numberOf10} x 10 notes");
    }

    private static bool IsAmountAMulitipleOf10(int amount)
    {
        return amount % 10 != 0;
    }
}