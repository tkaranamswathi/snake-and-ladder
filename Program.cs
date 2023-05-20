namespace UC2RANDOMDIEROLL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome to random dieroll");
            int position = 0;
            Random rand = new Random();
            int dieRoll = rand.Next(1, 7);
            Console.WriteLine("Welcome to Snake and Ladder game!");
            Console.WriteLine($"position:{position}");
            Console.WriteLine("Roll the dice (press any key to continue)");
            Console.ReadLine();
            Console.WriteLine("The player rolled a " + dieRoll);
        }
    }
}