namespace TrelloClone.Tasking.Domain.Models;

public class Column : List<Card>
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
}