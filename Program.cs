
using System.Drawing;

Board board = new();
Board.ShowBoard();

Console.WriteLine("Player 1, what is your name?");
string playerName1 = Console.ReadLine();
Player player1 = new(playerName1);

Console.WriteLine("Player 2, what is your name?");
string playerName2 = Console.ReadLine();
Player player2 = new(playerName1);

while(true)
{
    string playerTurn = "X";
    Console.WriteLine($"{playerTurn}, choose postion..");
    int position = Convert.ToInt32(Console.ReadLine());

    Board.AddPosition(position, playerTurn);
    Board.ShowBoard();

    playerTurn = "O";
    Console.WriteLine($"{playerTurn}, choose postion..");
    position = Convert.ToInt32(Console.ReadLine());
    
    Board.AddPosition(position, playerTurn);
    Board.ShowBoard();

}



// Classes
public class Board
{
    public static string[] topRow = { " ", " ", " ", "|", " ", " ", " ", "|", " ", " ", " " };
    public static string[] midRow = { " ", " ", " ", "|", " ", " ", " ", "|", " ", " ", " " };
    public static string[] botRow = { " ", " ", " ", "|", " ", " ", " ", "|", " ", " ", " " };
    public static string[] dashRow = { "-", "-", "-", "+", "-", "-", "-", "+", "-", "-", "-", };
    public static void ShowBoard()
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
        Console.WriteLine();
    }

    public static void AddPosition(int position, string playerTurn)
    {
        switch (position) { 
            
            case 1:
                if (topRow[1] == " ") topRow[1] = $"{playerTurn}"; 
                break;
            case 2:
                if (topRow[5] == " ") topRow[5] = $"{playerTurn}";
                break;
            case 3:
                if (topRow[9] == " ") topRow[9] = $"{playerTurn}";
                break;
            case 4:
                if (midRow[1] == " ") midRow[1] = $"{playerTurn}";
                break;
            case 5:
                if (midRow[5] == " ") midRow[5] = $"{playerTurn}";
                break;
            case 6:
                if (midRow[9] == " ") midRow[9] = $"{playerTurn}";
                break;
            case 7:
                if (botRow[1] == " ") botRow[1] = $"{playerTurn}";
                break;
            case 8:
                if (botRow[5] == " ") botRow[5] = $"{playerTurn}";
                break;
            case 9:
                if (botRow[9] == " ") botRow[9] = $"{playerTurn}";
                break;

        }
        return;

    }

    public static void AddPosition2(int position)
    {
        switch (position)
        {

            case 1:
                if (topRow[1] == " ") topRow[1] = "O";
                break;
            case 2:
                if (topRow[5] == " ") topRow[5] = "O";
                break;
            case 3:
                if (topRow[9] == " ") topRow[9] = "O";
                break;
            case 4:
                if (midRow[1] == " ") midRow[1] = "O";
                break;
            case 5:
                if (midRow[5] == " ") midRow[5] = "O";
                break;
            case 6:
                if (midRow[9] == " ") midRow[9] = "O";
                break;
            case 7:
                if (botRow[1] == " ") botRow[1] = "O";
                break;
            case 8:
                if (botRow[5] == " ") botRow[5] = "O";
                break;
            case 9:
                if (botRow[9] == " ") topRow[9] = "O";
                break;
            
        }
        return;

    }


}

public class Player
{
    public int NumberOfPlayers { get; set; }
    public string Name { get; set; }
    public string Side { get; set; }

    public int Number { get; set; } 
    public Player(string name) {

        NumberOfPlayers++;
        Name = name; 
        Number = NumberOfPlayers;
    
    }

  
}
