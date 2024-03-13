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
        }
    }
}