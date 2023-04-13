namespace PlayingCardDeck;

public enum Suits
{
    Hearts,
    Diamonds,
    Clubs,
    Spades
}

public class Suit
{
    private readonly Suits _value;
    public string Color => (int)_value <= 1 ? "red" : "black";

    public Suit(int value)
    {
        _value = (Suits)value;
    }

    
    public Suit(string value)
    {
        if (!Enum.IsDefined(typeof(Suits), value))
        {
            throw new ArgumentException("value is not a valid suit");
        }
        Enum.TryParse<Suits>(value, out _value);
    }

    public override string ToString()
    {
        Suits result = (Suits)_value;
        return result.ToString();
    }
    
    public static bool operator ==(Suit lhs, Suit rhs)
    {
        return lhs._value == rhs._value;
    }
    
    public static bool operator !=(Suit lhs, Suit rhs)
    {
        return lhs._value != rhs._value;
    }
}