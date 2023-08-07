using TrelloClone.Tasking.Domain.Models;

namespace TrelloClone.Tasking.Domain.Extensions;

public static class ColumnExtensions
{
    public static void SortByName(this Column column)
    {
        column.Sort((column1, column2) => string.Compare(column1.Name, column2.Name, StringComparison.Ordinal));
    }
}