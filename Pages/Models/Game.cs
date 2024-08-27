public class Game
{
    private const string V = "Player1";

    public string[,] Board { get; set; }
    public string CurrentPlayer { get; set; }
    public bool IsGameOver { get; set; }

    public Game()
    {
        Board = new string[5, 5];
        CurrentPlayer = V;
        IsGameOver = false;
    }
}