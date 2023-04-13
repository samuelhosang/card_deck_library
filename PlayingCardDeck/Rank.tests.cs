using Microsoft.VisualStudio.TestTools.UnitTesting;
using PlayingCardDeck;

namespace PlayingCardDeckTests;

[TestClass]
public class RankTests
{
    [TestInitialize]
    public void Setup()
    {
        
    }

    [TestMethod]
    public void RankValueCannotBeLowerThanZero()
    {
        Assert.ThrowsException<ArgumentException>(() =>
        {
            new Rank(0);
        });
    }

    [TestMethod]
    public void RankValueCannotBeHigherThanThirteen()
    {
        Assert.ThrowsException<ArgumentException>(() =>
        {
            new Rank(14);
        });
    }
    
    [TestMethod]
    [DataRow( 1)]
    [DataRow( 3)]
    [DataRow( 5)]
    [DataRow( 6)]
    [DataRow(11)]
    public void RankHasAValue(int arg)
    {
        Rank rank = new(arg);
        Assert.AreEqual(arg, rank.Value);
    }

    [TestMethod]
    public void RankHasLessThanOperator()
    {
        Rank lhs = new(1);
        Rank rhs = new(5);
        Assert.IsTrue(lhs < rhs);
        Assert.IsFalse(rhs < lhs);
    }

    [TestMethod]
    public void RankHasGreaterThanOperator()
    {
        Rank lhs = new(10);
        Rank rhs = new(5);
        Assert.IsTrue(lhs > rhs);
        Assert.IsFalse(rhs > lhs);
    }

    [TestMethod]
    public void RankHasEqualOperator()
    {
        Rank lhs = new(7);
        Rank rhs = new(7);
        Assert.IsTrue(lhs == rhs);
        Assert.IsFalse(rhs != lhs);
    }

    [TestMethod]
    public void RankHasNotEqualOperator()
    {
        Rank lhs = new(6);
        Rank rhs = new(13);
        Assert.IsTrue(lhs != rhs);
        Assert.IsFalse(rhs == lhs);
    }

    [TestMethod]
    [DataRow(1, "Ace")]
    [DataRow(4, "4")]
    [DataRow(10, "10")]
    [DataRow(11, "Jack")]
    [DataRow(12, "Queen")]
    [DataRow(13, "King")]
    public void RankHasToString(int value, string str)
    {
        Rank rank = new(value);
        Assert.AreEqual(str, rank.ToString());
    }
}