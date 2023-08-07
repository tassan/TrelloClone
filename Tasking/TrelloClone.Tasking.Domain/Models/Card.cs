namespace TrelloClone.Tasking.Domain.Models;

public class Card
{
    public string Name { get; set; }
    public string Description { get; set; }
    public DateTime? Deadline { get; set; }
    
    public Card(string cardName = "New Card")
    {
        Name = cardName;
        Description = string.Empty;
        Deadline = null;
    }
}