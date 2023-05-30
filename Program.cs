namespace UC6TOTALROLLS
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int winningPosition = 100;
            int playerPosition = 0;
            int diceRollCount = 0;

            Random random = new Random();

            while (playerPosition != winningPosition)
            {
                int diceRoll = random.Next(1, 7); // Simulating a dice roll (random number between 1 and 6)
                int newPosition = playerPosition + diceRoll;

                if (newPosition <= winningPosition)
                {
                    playerPosition = newPosition;
                }

                diceRollCount++;

                Console.WriteLine($"Dice roll: {diceRoll}");
                Console.WriteLine($"Player position: {playerPosition}");

                if (playerPosition == winningPosition)
                {
                    Console.WriteLine("Congratulations! You've reached the winning position.");
                }
                else
                {
                    Console.WriteLine("Roll the dice again.");
                }

                Console.WriteLine("Press Enter to roll the dice.");
                Console.ReadLine();
            }

            Console.WriteLine($"Total dice rolls: {diceRollCount}");
        }
    }
}
