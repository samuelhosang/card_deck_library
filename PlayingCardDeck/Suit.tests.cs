using Microsoft.VisualStudio.TestTools.UnitTesting;
using PlayingCardDeck;

namespace PlayingCardDeckTests;

[TestClass]
public class SuitTests
{
    [TestMethod]
    [DataRow(0)]
    [DataRow(1)]
    [DataRow(2)]
    [DataRow(3)]
    public void SuitCanInitializeWithInteger(int arg)
    {
        Suit suit = new(arg);
        Assert.IsNotNull(suit);
    }

    [TestMethod]
    [DataRow("Hearts")]
    [DataRow("Diamonds")]
    [DataRow("Spades")]
    [DataRow("Clubs")]
    public void SuitCanInitializeWithString(string arg)
    {
        Suit suit = new(arg);
        Assert.IsNotNull(suit);
    }

    [TestMethod]
    public void SuitHasToString()
    {
        Suit suit = new(0);
        Assert.IsNotNull(suit.ToString());
    }

    [TestMethod]
    [DataRow(0, "red")]
    [DataRow(1, "red")]
    [DataRow(2, "black")]
    [DataRow(3, "black")]
    public void SuitHasColor(int val, string color)
    {
        Suit suit = new(val);
        Assert.AreEqual(color, suit.Color);
    }
}