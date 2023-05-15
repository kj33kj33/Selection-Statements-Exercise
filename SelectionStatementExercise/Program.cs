namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            int myNumber = RandomNumber();

            Console.WriteLine("Hi, guess my favorite number:");

            var userInput = int.Parse(Console.ReadLine());

            if (userInput < myNumber)
            {
                Console.WriteLine($"Too low, answer was {myNumber}");
            }
            else if (userInput > myNumber)
            {
                Console.WriteLine($"Too high, answer was {myNumber}");
            }
            else
            {
                Console.WriteLine("You guessed it!!!");
            }
        }

        public static int RandomNumber()
        {
            var r = new Random();
            int myNumber = r.Next(1, 1000);
            return myNumber;
        }
    }
}
