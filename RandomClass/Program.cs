namespace Exercise4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = Random.Shared.Next(1, 10);

            int count = 0;

            while (count < 4)
            {
                Console.WriteLine("Pick a number from 1 to 10");
                Console.Write("Enter here: ");
                int userInput = Convert.ToInt32(Console.ReadLine());

                if (userInput == number)
                {
                    Console.WriteLine("\nYou won");
                    Console.WriteLine("\nThe random number is: " + number);
                    break;
                }
                else
                {
                    Console.WriteLine("\nYou lost\n");
                    count++;

                    if (count == 4)
                    {
                        Console.WriteLine("The random number is: " + number);

                    }
                }
            }
        }
    }
}
