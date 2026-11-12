namespace _14_delegate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>
        {
            1, 2, 3, 4, 5, 6, 7, 8, 9, 10
        };

            IEnumerable<int> filteredNumbers =
                numbers.Where(x => x > 5);

            Console.WriteLine("Where:");
            foreach (int number in filteredNumbers)
            {
                Console.Write(number + " ");
            }

            Console.WriteLine();

            int firstNumber =
                numbers.FirstOrDefault(x => x > 5);

            Console.WriteLine("FirstOrDefault: " + firstNumber);

            bool anyNumber =
                numbers.Any(x => x > 8);

            Console.WriteLine("Any: " + anyNumber);

            bool allNumbers =
                numbers.All(x => x > 0);

            Console.WriteLine("All: " + allNumbers);

            int totalCount =
                numbers.Count();

            Console.WriteLine("Count: " + totalCount);

            int filteredCount =
                numbers.Count(x => x > 5);

            Console.WriteLine("Count with condition: " + filteredCount);
        }
    }
}
