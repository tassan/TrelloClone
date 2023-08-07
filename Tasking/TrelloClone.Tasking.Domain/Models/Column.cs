namespace TrelloClone.Tasking.Domain.Models;

public class Column
{
    public string Name { get; set; }
    public List<Card> Cards { get; set; }

    public Column()
    {
        Name = "New Column";
        Cards = new List<Card>();
    }
    
    public Column(string columnName = "New Column") : this()
    {
        Name = columnName;
    }

    public void Add(Card card)
    {
        Cards.Add(card);
    }

    public void Remove(Card card)
    {
        Cards.Remove(card);
    }
}