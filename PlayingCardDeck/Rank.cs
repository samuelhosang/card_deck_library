namespace PlayingCardDeck;

public class Rank
{
    private int _value;

    public int Value => _value;

    public Rank(int value)
    {
        if (value < 1)
        {
            throw new ArgumentException("rank value cannot be lower than 1");
        }
        else if (value > 13)
        {
            throw new ArgumentException("rank value cannot be higher than 13");
        }
        
        _value = value;
    }
    
    public override string ToString()
    {
        switch (_value)
        {
            case 1: return "Ace";
            case 11: return "Jack";
            case 12: return "Queen";
            case 13: return "King";
            default: return _value.ToString();
        }
    }
    
    public static bool operator >(Rank lhs, Rank rhs)
    {
        return lhs._value > rhs._value;
    }

    public static bool operator <(Rank lhs, Rank rhs)
    {
        return lhs._value < rhs._value;
    }
    
    public static bool operator ==(Rank lhs, Rank rhs)
    {
        return lhs._value == rhs._value;
    }
    
    public static bool operator !=(Rank lhs, Rank rhs)
    {
        return lhs._value != rhs._value;
    }
}