namespace TrelloClone.Tasking.Domain.Models;

public class Column
{
    public string Name { get; set; }
    
    public Column(string columnName = "New Column")
    {
        Name = columnName;
    }
}