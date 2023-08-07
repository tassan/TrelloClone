using TrelloClone.Tasking.Domain.Extensions;
using TrelloClone.Tasking.Domain.Models;

namespace TrelloClone.Tasking.Test.Unit.Domain.Models;

[Category("Unit")]
[Category("Domain.Models")]
[Category("Domain.Models.Board")]
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
        // Arrange
        var column = new Column("To Do");

        // Act
        _board.AddColumn(column);

        // Assert
        Assert.That(_board.CountColumns(), Is.EqualTo(1));
    }

    [Test]
    public void Board_Should_RemoveColumn()
    {
        // Arrange
        var column = new Column("To Do");
        _board.AddColumn(column);

        // Act
        _board.RemoveColumn(column);

        // Assert
        Assert.That(_board.CountColumns(), Is.EqualTo(0));
    }

    [Test]
    public void Board_Should_AddCard()
    {
        // Arrange
        var column = new Column("To Do");
        _board.AddColumn(column);
        
        var card = new Card("Write Tests");
        
        // Act
        _board.AddCard(card);
        
        // Assert
        Assert.That(_board.CountCards(), Is.EqualTo(1));
    }

    [Test]
    public void Board_Should_RemoveCard()
    {
        // Arrange
        var column = new Column("To Do");
        var card = new Card("Write Tests");
        
        _board.AddColumn(column);
        _board.AddCard(card);
        
        // Act
        _board.RemoveCard(card);
        
        // Assert
        Assert.That(_board.CountCards(), Is.EqualTo(0));
    }

    [Test]
    public void Board_Should_MoveCard()
    {
        // Arrange
        var todoColumn = new Column("To Do");
        var doingColumn = new Column("Doing");
        var card = new Card("Write Tests");
        
        _board.AddColumn(todoColumn);
        _board.AddColumn(doingColumn);
        _board.AddCard(card);
        
        // Act
        _board.MoveCard(card, todoColumn, doingColumn);
        
        // Assert
        Assert.That(_board.CountCards(), Is.EqualTo(1));
        Assert.That(todoColumn.Count, Is.EqualTo(0));
        Assert.That(doingColumn.Count, Is.EqualTo(1));
    }

    [Test]
    public void Board_Should_MoveColumn()
    {
        // Arrange
        var todoColumn = new Column("To Do");
        var doingColumn = new Column("Doing");
        
        _board.AddColumn(todoColumn);
        _board.AddColumn(doingColumn);
        
        // Act
        _board.MoveColumn(doingColumn, 0);
        
        // Assert
        Assert.That(_board.CountColumns(), Is.EqualTo(2));
        Assert.That(_board.Columns[0].Name, Is.EqualTo("Doing"));
        Assert.That(_board.Columns[1].Name, Is.EqualTo("To Do"));
    }
    
    [Test]
    public void Board_Should_AddUntrackedCard()
    {
        // Arrange
        var board = new Board();
        var column = new Column("To Do");
        var card = new Card("Write Tests");
        
        board.AddColumn(column);
        board.AddCard(card);
        
        // Act
        board.RemoveCard(card);
        
        // Assert
        Assert.That(board.CountUntrackedCards(), Is.EqualTo(1));
    }
    
    [Test]
    public void Board_Should_RemoveUntrackedCard()
    {
        // Arrange
        var board = new Board();
        var column = new Column("To Do");
        var card = new Card("Write Tests");
        
        board.AddColumn(column);
        board.AddCard(card);
        board.RemoveCard(card);
        
        // Act
        board.AddCard(card);
        
        // Assert
        Assert.That(board.CountUntrackedCards(), Is.EqualTo(0));
    }
    
    [Test]
    public void Board_Should_DoNothing_When_EmptyColumns()
    {
        // Arrange
        var board = new Board();
        var card = new Card("Write Tests");
        
        // Act
        board.AddCard(card);
        board.RemoveCard(card);
        
        // Assert
        Assert.That(board.CountCards(), Is.EqualTo(0));
    }

    [Test]
    public void Board_ToString_Test()
    {
        // Arrange
        var board = new Board("Teams Special Project");
        var column = new Column("To Do");
        var card = new Card("Write Tests");
        
        board.AddColumn(column);
        board.AddCard(card);
        
        // Act
        var result = board.ToString();
        
        // Assert
        result.Should()
            .NotBeEmpty();
    }
}