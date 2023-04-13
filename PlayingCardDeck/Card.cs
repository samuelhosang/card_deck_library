namespace PlayingCardDeck;

public class Card
{
    public Suit Suit => _suit;
    public Rank Rank => _rank;

    private readonly Rank _rank;
    private readonly Suit _suit;

    public Card(int suit, int rank)
    {
        _suit = new Suit(suit);
        _rank = new Rank(rank);
    }

    public Card(string suit, int rank)
    {
        _suit = new Suit(suit);
        _rank = new Rank(rank);
    }

    public bool IsSameSuit(Card rhs)
    {
        return Suit == rhs.Suit;
    }

    public bool IsSameColor(Card rhs)
    {
        return Suit.Color == rhs.Suit.Color;
    }

    public bool IsDifferentColor(Card rhs)
    {
        return Suit.Color != rhs.Suit.Color;
    }

    public override string ToString()
    {
        return Rank + " of " + Suit;
    }
    
    public static bool operator >(Card lhs, Card rhs)
    {
        return lhs.Rank > rhs.Rank;
    }

    public static bool operator <(Card lhs, Card rhs)
    {
        return lhs.Rank < rhs.Rank;
    }
    
    public static bool operator ==(Card lhs, Card rhs)
    {
        return lhs.Rank == rhs.Rank && lhs.Suit == rhs.Suit;
    }
    
    public static bool operator !=(Card lhs, Card rhs)
    {
        return lhs.Rank != rhs.Rank || lhs.Suit != rhs.Suit;
    }
}