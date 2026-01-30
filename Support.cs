namespace Mission4Assignment;

public class Support
{
    public static void PrintBoard(string[] board)
    {
        Console.WriteLine();
        Console.WriteLine($" {board[0]} | {board[1]} | {board[2]}");
        Console.WriteLine("---+---+---");
        Console.WriteLine($" {board[3]} | {board[4]} | {board[5]}");
        Console.WriteLine("---+---+---");
        Console.WriteLine($" {board[6]} | {board[7]} | {board[8]}");
        Console.WriteLine();
    }

// Method to check if there is a winner. Returns "X" if X wins, "O" if O wins, "Tie" if board is full, or "" if game continues
public static string CheckWinner(string[] gameBoardArray)
{
    int[][] winningCombos = 
    {
        new int[] {0, 1, 2}, // Top row
        new int[] {3, 4, 5}, // Middle row
        new int[] {6, 7, 8}, // Bottom row
        new int[] {0, 3, 6}, // Left column
        new int[] {1, 4, 7}, // Middle column
        new int[] {2, 5, 8}, // Right column
        new int[] {0, 4, 8}, // Diagonal top-left to bottom-right
        new int[] {2, 4, 6}  // Diagonal top-right to bottom-left
    };

    // Check each winning combination
    foreach (int[] combo in winningCombos)
    {
        if (gameBoardArray[combo[0]] == gameBoardArray[combo[1]] && 
            gameBoardArray[combo[1]] == gameBoardArray[combo[2]])
        {
            return gameBoardArray[combo[0]];
        }
    }

    // Check for tie (no numbers left on board)
    bool boardFull = true;
    foreach (string spot in gameBoardArray)
    {
        if (spot != "X" && spot != "O")
        {
            boardFull = false;
            break;
        }
    }
        
    if (boardFull)
        return "Tie";

    return "";
}
}
