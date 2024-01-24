namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Pick a number 1 - 1000.");

            var r = new Random();
            var favNumber = r.Next(1, 1000);
            var userInput = int.Parse(Console.ReadLine());


            if (userInput < favNumber)
            {
                Console.WriteLine($"{userInput} is too low.");
            }
            else if (userInput < favNumber)
            {
                Console.WriteLine($"{userInput} is too high.");
            }
            else
            {
                Console.WriteLine($"You guessed it!");
            }
            Console.WriteLine($"What's your favorite subject?");
            string FavSubject = Console.ReadLine();
            switch( FavSubject.ToLower() )
            {
                case "math":
                    Console.WriteLine($"Math is interesting.");
                    break;
                case "science":
                    Console.WriteLine("Science is cool!");
                    break;
                case "history":
                    Console.WriteLine("History is fanscinating!");
                    break;
                case "language":
                    Console.WriteLine("Language arts is boring.");
                    break;
                case "lunch":
                    Console.WriteLine("That's not a real subject");
                    break;
                case "gym":
                    Console.WriteLine("Couldn't be me.");
                    break;
                default:
                    Console.WriteLine("I don't know that subject");
                    break;
            }
        }
        
    }
}
