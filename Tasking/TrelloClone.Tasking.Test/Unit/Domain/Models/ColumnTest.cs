using TrelloClone.Tasking.Domain.Extensions;
using TrelloClone.Tasking.Domain.Models;

namespace TrelloClone.Tasking.Test.Unit.Domain.Models;

public class ColumnTest
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Column_Should_SortCards_ByName()
    {
        // Arrange
        var column = new Column("Test Column");
        var cardList = new List<Card>
        {
            new Card("Zeta"),
            new Card("Alpha"),
            new Card("Gamma")
        };
        
        column.AddRange(cardList);
        
        // Act
        column.SortByName();
        
        // Assert
        Assert.That(column[0].Name, Is.EqualTo("Alpha"));
        Assert.That(column[1].Name, Is.EqualTo("Gamma"));
        Assert.That(column[2].Name, Is.EqualTo("Zeta"));
    }
}