using System.Transactions;

Console.WriteLine("Welcome to Tic-Tac-Toe!");
string[] gameBoardArray = ["1","2","3","4","5","6","7","8","9"];
int i = 0;
string board = $" {gameBoardArray[i]} | {gameBoardArray[i + 1]} | {gameBoardArray[i + 2]}\n" +
               $"---+---+---\n" +
               $" {gameBoardArray[i + 3]} | {gameBoardArray[i + 4]} | {gameBoardArray[i + 5]}\n" +
               $"---+---+---\n" +
               $" {gameBoardArray[i + 6]} | {gameBoardArray[i + 7]} | {gameBoardArray[i + 8]}";

Console.WriteLine(board);
bool gameWin = false;
while (gameWin == false)
{
    Console.WriteLine("Player X- Enter the number of the spot you want to choose: ");
    string? playerXChoice = Console.ReadLine();

    while (true)
    {
        if (string.IsNullOrEmpty(playerXChoice))
        {
            Console.WriteLine("Please enter a valid number between 1 and 9");
            playerXChoice = Console.ReadLine();
            continue;
        }

        if (!int.TryParse(playerXChoice, out int playerXChoiceInt))
        {
            Console.WriteLine("Please enter a valid number between 1 and 9");
            playerXChoice = Console.ReadLine();
            continue;
        }

        if (playerXChoiceInt < 1 || playerXChoiceInt > 9)
        {
            Console.WriteLine("Please enter a valid number between 1 and 9");
            playerXChoice = Console.ReadLine();
            continue;
        }

        playerXChoiceInt = playerXChoiceInt - 1;

        Console.WriteLine($"You chose spot {playerXChoiceInt}");
        break;
    }
    // Put in the board update method
    // add game winning check method


    Console.WriteLine("Player O- Enter the number of the spot you want to choose: ");
    string? playerOChoice = Console.ReadLine();

    while (true)
    {
        if (string.IsNullOrEmpty(playerOChoice))
        {
            Console.WriteLine("Please enter a valid number between 1 and 9");
            playerOChoice = Console.ReadLine();
            continue;
        }

        if (!int.TryParse(playerOChoice, out int playerOChoiceInt))
        {
            Console.WriteLine("Please enter a valid number between 1 and 9");
            playerOChoice = Console.ReadLine();
            continue;
        }

        if (playerOChoiceInt < 1 || playerOChoiceInt > 9)
        {
            Console.WriteLine("Please enter a valid number between 1 and 9");
            playerOChoice = Console.ReadLine();
            continue;
        }

        playerOChoiceInt = playerOChoiceInt - 1;

        Console.WriteLine($"You chose spot {playerOChoiceInt}");
        break;
    }      
    
    // Put in the board update method
    // add game winning check method
}
