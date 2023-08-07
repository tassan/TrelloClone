using TrelloClone.Tasking.Domain.Models;

namespace TrelloClone.Tasking.Domain.Extensions;

public static class CardExtensions
{
    public static void UpdateName(this Card card, string name)
    {
        card.Update(name, card.Description, card.Deadline);
    }
    
    public static void UpdateDescription(this Card card, string description)
    {
        card.Update(card.Name, description, card.Deadline);
    }
    
    public static void UpdateDeadline(this Card card, DateTime? deadline)
    {
        card.Update(card.Name, card.Description, deadline);
    }
}