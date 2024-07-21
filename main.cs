using System;

class Program
{
    static void Main(string[] args)
    {
        string[] salespersonNames = { "Danielle", "Edward", "Francis" };
        char[] salespersonInitials = { 'D', 'E', 'F' };
        double[] salesTotals = new double[salespersonNames.Length];

        double grandTotal = 0;

        while (true)
        {
            Console.WriteLine("Enter salesperson initial (D, E, F, or Z to quit): ");
            char salespersonInitial = Console.ReadKey().KeyChar;
            Console.WriteLine();

            if (salespersonInitial == 'Z' || salespersonInitial == 'z')
            {
                break;
            }

            salespersonInitial = char.ToUpper(salespersonInitial);

            // Check if the initial is valid
            bool isValidInitial = false;
            for (int i = 0; i < salespersonInitials.Length; i++)
            {
                if (salespersonInitial == salespersonInitials[i])
                {
                    isValidInitial = true;
                    break;
                }
            }

            if (isValidInitial)
            {
                // Find the index of the initial
                int initialIndex = Array.IndexOf(salespersonInitials, salespersonInitial);

                // Get the sale amount
                Console.WriteLine("Enter sale amount: ");
                double saleAmount = Convert.ToDouble(Console.ReadLine());

                // Update the sales total
                salesTotals[initialIndex] += saleAmount;
                grandTotal += saleAmount;
            }
            else
            {
                Console.WriteLine("Invalid salesperson initial. Please try again.");
            }
        }

        // Print the grand total
        Console.WriteLine("\nGrand Total: $" + grandTotal.ToString("0.00"));

        // Find the highest sale
        int highestSaleIndex = 0;
        for (int i = 1; i < salesTotals.Length; i++)
        {
            if (salesTotals[i] > salesTotals[highestSaleIndex])
            {
                highestSaleIndex = i;
            }
        }

        // Print the highest sale
        Console.WriteLine("\nHighest Sale: " + salespersonNames[highestSaleIndex]);
    }
}