namespace Exercise5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter numbers separated by commas: ");
            string userInput = Console.ReadLine();

            string[] parts = userInput.Split(',');

            int highestNumber = int.MinValue;

            foreach (string part in parts)
            {
                int number = int.Parse(part.Trim());

                if (number > highestNumber)
                {
                    highestNumber = number;
                }
            }

            Console.WriteLine("Highest: " + highestNumber);

        }
    }
}