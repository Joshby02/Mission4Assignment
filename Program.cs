using System.Transactions;
using Mission4Assignment;

Console.WriteLine("Welcome to Tic-Tac-Toe!");

string[] gameBoardArray = { "1", "2", "3", "4", "5", "6", "7", "8", "9" };
Support.PrintBoard(gameBoardArray);

bool gameWin = false;

while (!gameWin)
{
    int playerXChoiceInt;
    while (true)
    {
        Console.WriteLine("Player X - Enter a number (1-9): ");
        string? input = Console.ReadLine();

        if (!int.TryParse(input, out playerXChoiceInt) || playerXChoiceInt < 1 || playerXChoiceInt > 9)
        {
            Console.WriteLine("Invalid input.");
            continue;
        }

        playerXChoiceInt--;

        if (gameBoardArray[playerXChoiceInt] == "X" || gameBoardArray[playerXChoiceInt] == "O")
        {
            Console.WriteLine("That spot is already taken.");
            continue;
        }

        break;
    }

    gameBoardArray[playerXChoiceInt] = "X";
    Support.PrintBoard(gameBoardArray);

    string result = Support.CheckWinner(gameBoardArray);
    if (result != "")
    {
        EndGame(result);
        break;
    }

    int playerOChoiceInt;
    while (true)
    {
        Console.WriteLine("Player O - Enter a number (1-9): ");
        string? input = Console.ReadLine();

        if (!int.TryParse(input, out playerOChoiceInt) || playerOChoiceInt < 1 || playerOChoiceInt > 9)
        {
            Console.WriteLine("Invalid input.");
            continue;
        }

        playerOChoiceInt--;

        if (gameBoardArray[playerOChoiceInt] == "X" || gameBoardArray[playerOChoiceInt] == "O")
        {
            Console.WriteLine("That spot is already taken.");
            continue;
        }

        break;
    }

    gameBoardArray[playerOChoiceInt] = "O";
    Support.PrintBoard(gameBoardArray);

    result = Support.CheckWinner(gameBoardArray);
    if (result != "")
    {
        EndGame(result);
        break;
    }
}

static void EndGame(string result)
{
    if (result == "Tie")
        Console.WriteLine("It's a tie!");
    else
        Console.WriteLine($"Player {result} wins!");
}
