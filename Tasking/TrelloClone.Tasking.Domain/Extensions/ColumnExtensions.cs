using TrelloClone.Tasking.Domain.Models;

namespace TrelloClone.Tasking.Domain.Extensions;

public static class ColumnExtensions
{
    public static void SortByName(this Column column)
    {
        column.Sort((cardX, cardY) => string.Compare(cardX.Name, cardY.Name, StringComparison.Ordinal));
    }
}