

namespace UC7PLAYER1AND2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int winningPosition = 100;
            int[] playerPositions = new int[2];
            int currentPlayer = 0;
            int diceRollCount = 0;

            Random random = new Random();

            while (playerPositions[currentPlayer] != winningPosition)
            {
                int diceRoll = random.Next(1, 7); // Simulating a dice roll (random number between 1 and 6)
                int newPosition = playerPositions[currentPlayer] + diceRoll;

                if (newPosition <= winningPosition)
                {
                    playerPositions[currentPlayer] = newPosition;
                }

                diceRollCount++;

                Console.WriteLine($"Player {currentPlayer + 1}: Dice roll: {diceRoll}");
                Console.WriteLine($"Player {currentPlayer + 1}: Position: {playerPositions[currentPlayer]}");

                if (playerPositions[currentPlayer] == winningPosition)
                {
                    Console.WriteLine($"Player {currentPlayer + 1} won the game!");
                    break;
                }
                else if (diceRoll == 6)
                {
                    Console.WriteLine("Ladder! Play again.");
                }
                else
                {
                    currentPlayer = (currentPlayer + 1) % 2; // Switch to the next player
                }

                Console.WriteLine("Press Enter to roll the dice.");
                Console.ReadLine();
            }

            Console.WriteLine($"Total dice rolls: {diceRollCount}");
        }
    }
}
