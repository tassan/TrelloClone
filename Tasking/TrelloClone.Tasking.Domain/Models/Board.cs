using TrelloClone.Tasking.Domain.Extensions;

namespace TrelloClone.Tasking.Domain.Models;

public class Board
{
    public string Title { get; set; }
    public List<Column> Columns { get; set; }
    protected internal List<Card> UntrackedCards { get; set; }

    public Board()
    {
        Title = "New Board";
        Columns = new List<Column>();
        UntrackedCards = new List<Card>();
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
        if (!Columns.Any()) return;
        
        var column = Columns.First();
        column.Add(card);
            
        if (UntrackedCards.Contains(card)) RemoveUntrackedCard(card);
    }

    public void RemoveCard(Card card)
    {
        if (!Columns.Any()) return;
        
        var column = Columns.First();
        column.Remove(card);
        AddUntrackedCard(card);
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

    private void AddUntrackedCard(Card card)
    {
        UntrackedCards.Add(card);
    }

    private void RemoveUntrackedCard(Card card)
    {
        UntrackedCards.Remove(card);
    }

    public override string ToString()
    {
        return $"Board: {Title} Columns: {this.CountColumns()} Cards: {this.CountCards()} Untracked Cards: {this.CountUntrackedCards()}";
    }
}