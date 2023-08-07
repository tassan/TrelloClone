using TrelloClone.Tasking.Domain.Extensions;
using TrelloClone.Tasking.Domain.Models;

namespace TrelloClone.Tasking.Test.Unit.Domain.Models;

[Category("Unit")]
[Category("Domain.Models")]
[Category("Domain.Models.Card")]
public class CardTest
{
    private Card _card;

    [SetUp]
    public void Setup()
    {
        _card = new Card();
    }

    [Test]
    public void Card_Should_UpdateName()
    {
        // Arrange
        var expected = "New Name";

        // Act
        _card.UpdateName(expected);

        // Assert
        _card.Name
            .Should()
            .Be(expected);
    }

    [Test]
    public void Card_Should_UpdateDescription()
    {
        // Arrange
        var expected = "New Description";
        
        // Act
        _card.UpdateDescription(expected);
        
        // Assert
        _card.Description
            .Should()
            .Be(expected);
    }

    [Test]
    public void Card_Should_UpdateDeadline()
    {
        // Arrange
        var expected = DateTime.Now;
        
        // Act
        _card.UpdateDeadline(expected);
        
        // Assert
        _card.Deadline
            .Should()
            .Be(expected);
    }
}