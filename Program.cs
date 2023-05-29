using System.Diagnostics.Metrics;

namespace UC3NOPLAY
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Snake and Ladder Game!");

            int position = 0; // Starting position of the player

            while (position < 100) // Continue the game until the player reaches or exceeds position 100
            {
                Console.WriteLine("Current position: " + position);
                Console.WriteLine("Press Enter to roll the dice.");
                Console.ReadLine();

                // Roll the dice
                Random random = new Random();
                int diceRoll = random.Next(1, 7); // Generate a random number between 1 and 6

                Console.WriteLine("Dice roll: " + diceRoll);

                // Update the position based on the dice roll
                position += diceRoll;

                if (position > 100)
                {
                    position -= diceRoll; // Move the player back to the previous position if they exceed 100
                    Console.WriteLine("Oops! You need to roll the exact number to reach 100. Try again.");
                }
                else if (position < 0)
                {
                    position = 0; // Reset the player's position to 0 if it goes below 0
                    Console.WriteLine("Oops! Your position went below 0. Restarting from position 0.");
                }
                else
                {
                    Console.WriteLine("New position: " + position);

                    // Check if the player has landed on a ladder or snake or chose no play
                    Console.WriteLine("Choose your option:");
                    Console.WriteLine("1. No Play");
                    Console.WriteLine("2. Ladder");
                    Console.WriteLine("3. Snake");

                    int option = Convert.ToInt32(Console.ReadLine());

                    switch (option)
                    {
                        case 1:
                            Console.WriteLine("No Play! Your position remains the same.");
                            break;
                        case 2:
                            // Check if the player can climb the ladder
                            if (position == 3 || position == 6 || position == 20 || position == 36 || position == 63 || position == 68)
                            {
                                int newPosition = position;
                                switch (position)
                                {
                                    case 3:
                                        newPosition = 51;
                                        break;
                                    case 6:
                                        newPosition = 27;
                                        break;
                                    case 20:
                                        newPosition = 70;
                                        break;
                                    case 36:
                                        newPosition = 55;
                                        break;
                                    case 63:
                                        newPosition = 95;
                                        break;
                                    case 68:
                                        newPosition = 98;
                                        break;
                                }

                                Console.WriteLine("Ladder! You climbed up to position " + newPosition + ".");
                                position = newPosition;
                            }
                            else
                            {
                                Console.WriteLine("Oops! You cannot climb the ladder from your current position.");
                            }
                            break;
                        case 3:
                            // Check if the player can slide down the snake
                            if (position == 25 || position == 34 || position == 47 || position == 65 || position == 87 || position == 91)
                            {
                                int newPosition = position;
                                switch (position)
                                {
                                    case 25:
                                        newPosition = 5;
                                        break;
                                    case 34:
                                        newPosition = 1;
                                        break;
                                    case 47:
                                        newPosition = 19;
                                        break;
                                    case 65:
                                        newPosition = 52;
                                        break;
                                    case 87:
                                        newPosition = 57;
                                        break;
                                    case 91:
                                        newPosition = 61;
                                        break;
                                }

                                Console.WriteLine("Snake! You slid down to position " + newPosition + ".");
                                position = newPosition;
                            }
                            else
                            {
                                Console.WriteLine("Oops! There is no snake at your current position.");
                            }
                            break;
                        default:
                            Console.WriteLine("Invalid option! Try again.");
                            break;
                    }
                }
            }

            Console.WriteLine("Congratulations! You reached 100. You win!");
            Console.ReadLine();
        }
    }
}

