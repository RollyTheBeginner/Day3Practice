namespace Exercise3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");

            int userInput = Convert.ToInt32(Console.ReadLine());

            // Display the factorial sequence
            for (int i = userInput; i >= 1; i--)
            {
                Console.Write(i);

                if (i > 1)
                    Console.Write(" x ");
                
            }

            // Compute factorial
            int factorial = 1;
            for (int j = 1; j <= userInput; j++)
            {
                factorial *= j;
            }

            // FOR SPACE LANG
            Console.WriteLine();
            Console.Write(userInput + "! = " + factorial);

        }
    }
}
