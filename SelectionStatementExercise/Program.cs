namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            int myFavNumber = 33;

            Console.WriteLine("Hi, guess my favorite number:");

            var userInput = int.Parse(Console.ReadLine());

            if (userInput < myFavNumber)
            {
                Console.WriteLine("Too low");
            }

            else if (userInput > myFavNumber)
            {
                Console.WriteLine("Too high");
            }

            else
            {
                Console.WriteLine("You guessed it!!!");
            }

        }
    }
}
