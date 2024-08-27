using Microsoft.AspNetCore.SignalR;

public class GameHub : Hub
{
    private readonly GameService _gameService;

    public GameHub(GameService gameService)
    {
        _gameService = gameService;
    }

    public async Task SendMove(int fromX, int fromY, int toX, int toY)
    {
        if (_gameService.MakeMove(fromX, fromY, toX, toY))
        {
            await Clients.All.SendAsync("ReceiveMove", fromX, fromY, toX, toY);
        }
    }
}