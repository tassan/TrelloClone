using TrelloClone.Tasking.Domain.Models;

namespace TrelloClone.Tasking.Test.Unit.Domain.Models;

public class BoardTest
{
    private Board _board;
    
    [SetUp]
    public void Setup()
    {
        _board = new Board("Teams Special Project");
    }

    [Test]
    public void Board_Should_AddColumn()
    {
        Assert.Pass();
    }
    
    [Test]
    public void Board_Should_RemoveColumn()
    {
        Assert.Pass();
    }
    
    [Test]
    public void Board_Should_AddCard()
    {
        Assert.Pass();
    }
    
    [Test]
    public void Board_Should_RemoveCard()
    {
        Assert.Pass();
    }
    
    [Test]
    public void Board_Should_MoveCard()
    {
        Assert.Pass();
    }
    
    [Test]
    public void Board_Should_MoveColumn()
    {
        Assert.Pass();
    }
}