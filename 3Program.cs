namespace AvoidMagicNumber
{
    internal class Program
    {
        private const int EvenDivisor = 2; // Constant for checking evenness
        private const int RemainderForEven = 0;  // Expected remainder for even numbers

        static void Main(string[] args)
        {
            Console.WriteLine("ENTER A NUMBER:");
            int number = Convert.ToInt32(Console.ReadLine());

            // Call IsEven to check if the number is even
            if (IsEven(number))
            {
                Console.WriteLine("The number is even.");
            }
            else
            {
                Console.WriteLine("The number is odd.");
            }
        }

        private static bool IsEven(int number)
        {
            return number % EvenDivisor == RemainderForEven;
        }
    }
}
