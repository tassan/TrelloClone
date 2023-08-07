namespace TrelloClone.Tasking.Domain.Models;

public class Card
{
    public string Name { get; set; }
    
    public Card(string cardName = "New Card")
    {
        Name = cardName;
    }
}