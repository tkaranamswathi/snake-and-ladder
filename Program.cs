namespace UC4WINNINGPOS
{
    internal class Program
    {
            public static void Main(string[] args)
            {
                int winningPosition = 100;
                int playerPosition = 0;

                Random random = new Random();

                while (playerPosition < winningPosition)
                {
                    int diceRoll = random.Next(1, 7); // Simulating a dice roll (random number between 1 and 6)
                    playerPosition += diceRoll;

                    if (playerPosition < 0)
                    {
                        playerPosition = 0;
                    }

                    Console.WriteLine($"Player position: {playerPosition}");

                    if (playerPosition == winningPosition)
                    {
                        Console.WriteLine("Congratulations! You've reached the winning position.");
                    }
                    else if (playerPosition > winningPosition)
                    {
                        Console.WriteLine("Oops! You've gone past the winning position.");
                    }
                    else
                    {
                        Console.WriteLine("Roll the dice again.");
                    }

                    Console.WriteLine("Press Enter to roll the dice.");
                    Console.ReadLine();
                }
            }
    }
}

    