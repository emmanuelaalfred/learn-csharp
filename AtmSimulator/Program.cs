using System.Numerics;

namespace AtmSimulator;
static class Program
{
    static void Main()
    {
        Console.WriteLine("Please enter the amount you would like to withdraw: ");
        string input = Console.ReadLine();

        int amount = int.Parse(input);

        if (amount >= 600)
        {
            Console.WriteLine("This ATM can only dispense amounts up to £600.");

        }
        else if (amount % 10 != 0)
        {
            Console.WriteLine("This ATM can only dispense amounts in multiples of 10.");

        }
        else
        {
            Console.WriteLine($"Dispense ${amount}");

            int numberOf50 = amount / 50;
            amount = amount - 50 * numberOf50;

            int numberOf20 = amount / 20;
            amount = amount - 20 * numberOf20;

            int numberOf10 = amount / 10;


            Console.WriteLine($"Dispensing {numberOf50} x 50 notes");
            Console.WriteLine($"Dispensing {numberOf20} x 20 note");
            Console.WriteLine($"Dispensing {numberOf10} x 10 noteS");
        }

    }

}