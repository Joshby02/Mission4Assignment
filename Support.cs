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
}