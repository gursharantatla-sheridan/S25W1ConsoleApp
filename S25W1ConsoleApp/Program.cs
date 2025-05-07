namespace S25W1ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");

            int[] numbers = { 10, 20, 0, 30 };
            int total = 0;
            int count = numbers.Length;

            for (int i = 0; i < count; i++) // off-by-one error
            {
                total += numbers[i];
            }

            int average = total / count;
            Console.WriteLine("Average: " + average);
        }
    }
}
