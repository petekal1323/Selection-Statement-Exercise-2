namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            FavSubject();
        }

        public static void FavSubject()
        {
            Console.WriteLine("What is your favorite school subject?");
            string subject = Console.ReadLine();
            
            Console.WriteLine("Please enter to continue...");
            Console.ReadKey();

            switch (subject.ToLower())
            {
                case "math":
                    Console.WriteLine("It's okay!");
                    break;
                case "science":
                    Console.WriteLine("Science is great!");
                    break;
                case "english":
                    Console.WriteLine("Eh, it's okay.");
                    break;
                case "history":
                    Console.WriteLine("I like History");
                    break;
                default:
                    Console.WriteLine("That's a great subject!");
                    break;
                
            }
        }
    }
}