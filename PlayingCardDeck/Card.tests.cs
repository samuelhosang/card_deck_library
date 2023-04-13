using Microsoft.VisualStudio.TestTools.UnitTesting;
using PlayingCardDeck;

namespace PlayingCardDeckTests;

[TestClass]
public class CardTests
{
    private Deck deck;
    private Card card;
    
    [TestInitialize]
    public void Setup()
    {
        deck = new Deck();
        deck.Shuffle();
        card = deck.DealOneCard();
    }

    [TestMethod]
    public void CardNeedsSuitAndRank()
    {
        Card card = new(0, 1);
        Assert.IsNotNull(card);
    }
    
    [TestMethod]
    public void CardShouldHaveRank()
    {
        Assert.IsNotNull(card.Rank);
    }

    [TestMethod]
    public void CardShouldHaveSuit()
    {
        Assert.IsNotNull(card.Suit);
    }

    [TestMethod]
    public void CardCanBeLessThanAnotherCard()
    {
        Card lhs = new(1, 1);
        Card rhs = new(3, 3);
        Assert.IsTrue(lhs < rhs);
        Assert.IsFalse(rhs < lhs);
    }

    [TestMethod]
    public void CardCanBeGreaterThanAnotherCard()
    {
        Card lhs = new(2, 12);
        Card rhs = new(2, 2);
        Assert.IsTrue(lhs > rhs);
        Assert.IsFalse(rhs > lhs);
    }

    [TestMethod]
    public void CardCanBeEqualToAnotherCard()
    {
        Card lhs = new(1, 1);
        Card rhs = new(1, 1);
        Assert.IsTrue(lhs == rhs);
        Assert.IsFalse(lhs != rhs);
    }

    [TestMethod]
    public void CardCanBeNotEqualToAnotherCard()
    {
        Card lhs = new(1, 1);
        Card rhs = new(2, 1);
        Assert.IsTrue(lhs != rhs);
        Assert.IsFalse(lhs == rhs);
    }

    [TestMethod]
    public void CardsCanHaveTheSameColor()
    {
        Card lhs = new(0, 1);
        Card rhs = new(1, 1);
        Assert.IsTrue(lhs.IsSameColor(rhs));
        Assert.IsFalse(lhs.IsDifferentColor(rhs));
    }

    [TestMethod]
    public void CardsCanHaveDifferentColors()
    {
        Card lhs = new(0, 1);
        Card rhs = new(2, 1);
        Assert.IsTrue(lhs.IsDifferentColor(rhs));
        Assert.IsFalse(lhs.IsSameColor(rhs));
    }

    [TestMethod]
    public void CardsCanHaveSameSuit()
    {
        Card lhs = new(1, 1);
        Card rhs = new(1, 13);
        Assert.IsTrue(lhs.IsSameSuit(rhs));
    }

    [TestMethod]
    public void CardsCanHaveDifferentSuit()
    {
        Card lhs = new(1, 1);
        Card rhs = new(2, 13);
        Assert.IsFalse(lhs.IsSameSuit(rhs));
    }
}