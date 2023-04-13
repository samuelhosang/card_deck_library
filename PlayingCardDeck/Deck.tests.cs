using Microsoft.VisualStudio.TestTools.UnitTesting;
using PlayingCardDeck;

namespace PlayingCardDeckTests;

[TestClass]
public class DeckTests
{
    private Deck deck;
    
    [TestInitialize]
    public void Setup()
    {
        deck = new Deck();
    }

    [TestMethod]
    public void DeckShouldHaveCards()
    {
        Assert.IsNotNull(deck.Cards);
    }
    
    [TestMethod]
    public void DeckShouldHaveFiftyTwoCards()
    {
        Assert.AreEqual(52, deck.Cards.Count);
    }

    [TestMethod]
    [DataRow(1)]
    [DataRow(7)]
    public void DeckShouldDealOutCards(int amountToDeal)
    {
        List<Card> dealt = deck.Deal(amountToDeal);
        Assert.AreEqual(amountToDeal, dealt.Count);
    }

    [TestMethod]
    [DataRow(1)]
    [DataRow(7)]
    public void DeckShouldLoseCardsWhenDealt(int amountToDeal)
    {
        List<Card> dealt = deck.Deal(amountToDeal);
        Assert.AreEqual(amountToDeal, dealt.Count);
        for (int i = 0; i < dealt.Count; i++)
        {
            int result = deck.Cards.IndexOf(dealt[i]);
            Assert.AreEqual(-1, result);
        }
    }

    [TestMethod]
    public void DeckShouldAllowShuffling()
    {
        List<Card> cards = new(deck.Cards);
        deck.Shuffle();
        int errorRate = 0;
        for (int i = 0; i < deck.Cards.Count; i++)
        {
            if (cards[i].ToString() == deck.Cards[i].ToString())
            {
                errorRate++;
            }
        }
        Console.WriteLine("Error Rate: " + errorRate);
        Assert.IsTrue(errorRate < 3, "more than 5% of the deck was similar");
    }

    [TestMethod]
    [DataRow(4, 5)]
    [DataRow(3, 7)]
    public void DeckShouldDealCardsRoundRobinAndEvenlyToPlayers(int players, int cards)
    {
        deck.Shuffle();
        List<Card> copy = new(deck.Cards);

        List<List<Card>> dealtToPlayers = deck.DealToPlayers(players, cards);
        Assert.AreEqual(52 - players * cards, deck.Cards.Count);

        for (int i = 0; i < cards; i++)
        {
            for (int j = 0; j < players; j++)
            {
                Card lhs = copy[players * i + j];
                Card rhs = dealtToPlayers[j][i];
                
                Assert.AreEqual(lhs.ToString(), rhs.ToString());
            }
        }
    }
}