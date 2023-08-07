namespace TrelloClone.Tasking.Domain.Models;

public class Board
{
    public string Title { get; set; }
    public List<Column> Columns { get; set; }

    public Board()
    {
        Title = "New Board";
        Columns = new List<Column>();
    }
    
    public Board(string boardTitle = "New Board") : this()
    {
        Title = boardTitle;
    }

    public void AddColumn(Column column)
    {
        Columns.Add(column);
    }

    public void RemoveColumn(Column column)
    {
        Columns.Remove(column);
    }

    public void AddCard(Card card)
    {
        if (Columns.Any())
        {
            var column = Columns.First();
            column.Add(card);
        }
    }

    public void RemoveCard(Card card)
    {
        if (Columns.Any())
        {
            var column = Columns.First();
            column.Remove(card);
        }
    }

    public void MoveCard(Card card, Column from, Column to)
    {
        from.Remove(card);
        to.Add(card);
    }

    public void MoveColumn(Column column, int position)
    {
        Columns.Remove(column);
        Columns.Insert(position, column);
    }
}