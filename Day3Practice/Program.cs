namespace Day3Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = i; j < 5; j++)
                    Console.Write(" ");

                for (int k = 1; k <= (2 * i - 1); k++)
                    Console.Write("*");


                Console.WriteLine();
            }

        }
    }
}
