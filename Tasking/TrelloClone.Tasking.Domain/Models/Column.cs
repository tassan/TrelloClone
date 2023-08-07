namespace TrelloClone.Tasking.Domain.Models;

public class Column : List<Card>
{
    public string Name { get; set; }

    public Column()
    {
        Name = "New Column";
    }
    
    public Column(string columnName = "New Column") : this()
    {
        Name = columnName;
    }
}