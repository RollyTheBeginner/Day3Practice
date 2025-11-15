namespace Exercise2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;

            while (true)
            {
                Console.WriteLine("Enter a number or type 'ok' to exit the program: ");

                Console.Write("Input: ");
                string userInput = Console.ReadLine();

                if (userInput?.ToLower() == "ok")
                {

                    Console.WriteLine("You entered ok!");
                    Console.WriteLine("The sum of all numbers are: " + sum);
                    Console.WriteLine("Exiting the program...");
                    break;
                }

                int parsedNumber;

                if (int.TryParse(userInput, out parsedNumber))
                {
                    sum += parsedNumber;
                    Console.WriteLine("You entered a valid number: " + parsedNumber + "\n");
                }
                else
                {
                    Console.WriteLine("Invalid input! Please enter a number or 'ok'. \n");
                }

              
            }
        }
    }
}
