using TrelloClone.Tasking.Domain.Models;

namespace TrelloClone.Tasking.Domain.Extensions;

public static class ColumnExtensions
{
    public static int CountCards(this Column column) => column.Cards.Count;
}