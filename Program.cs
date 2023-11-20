
Board board = new();
board.CreateBoard();


// Classes
public class Board
{

    string[] topRow = { " ", " ", " ", "|", " ", " ", " ", "|", " ", " ", " " };
    string[] midRow = { " ", " ", " ", "|", " ", " ", " ", "|", " ", " ", " " };
    string[] botRow = { " ", " ", " ", "|", " ", " ", " ", "|", " ", " ", " " };
    string[] dashRow = { "-", "-", "-", "+", "-", "-", "-", "+", "-", "-", "-", };

    public void CreateBoard()
    {
        foreach (string position in topRow) { Console.Write(position); }
        Console.WriteLine();
        foreach (string dash in dashRow) { Console.Write(dash); }
        Console.WriteLine();
        foreach (string position in midRow) { Console.Write(position); }
        Console.WriteLine();
        foreach (string dash in dashRow) { Console.Write(dash); }
        Console.WriteLine();
        foreach (string position in botRow) { Console.Write(position); }
    }
   

}
