using Microsoft.AspNetCore.Mvc.RazorPages;

public class IndexModel : PageModel
{
    private readonly GameService _gameService;

    public Game Game { get; set; }

    public IndexModel(GameService gameService)
    {
        _gameService = gameService;
    }

    public void OnGet()
    {
        Game = _gameService.GetGame();
    }
}