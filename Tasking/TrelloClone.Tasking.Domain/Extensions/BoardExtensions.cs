using TrelloClone.Tasking.Domain.Models;

namespace TrelloClone.Tasking.Domain.Extensions;

public static class BoardExtensions
{
    public static int CountColumns(this Board board) => board.Columns.Count;

    public static int CountCards(this Board board) => board.Columns.Sum(column => column.Count);
    
    public static int CountUntrackedCards(this Board board) => board.UntrackedCards.Count;
}