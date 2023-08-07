namespace TrelloClone.Tasking.Domain.Models;

public class Board
{
    public string Title { get; set; }
    
    public Board(string boardTitle = "New Board")
    {
        Title = boardTitle;
    }
}