namespace Ticket_Price_Calculator
{
    
    public class TicketPriceCalculator
{
    public static void Main(string[] args)
    {
        try
        {
            Console.Write("Please enter your age: ");
            string input = Console.ReadLine();

            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("Invalid input. Age cannot be empty.");
                return; // Exit the program
            }

            if (!int.TryParse(input, out int age))
            {
                Console.WriteLine("Invalid input. Please enter a valid integer for age.");
                return; // Exit the program
            }

            if (age < 0)
            {
                Console.WriteLine("Invalid input. Age cannot be negative.");
                return; //Exit the program.
            }

            double ticketPrice; // Use double for currency

            if (age >= 65 || age <= 12)
            {
                ticketPrice = 7.00;
            }
            else
            {
                ticketPrice = 10.00;
            }

            Console.WriteLine($"The ticket price is GHC{ticketPrice:F2}."); // Format the output to 2 decimal places
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An unexpected error occurred: {ex.Message}"); // Catch other possible exceptions
        }
    }
}
}