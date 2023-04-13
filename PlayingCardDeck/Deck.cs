namespace PlayingCardDeck;

public class Deck
{
    public List<Card> Cards => _cards;
    
    private readonly List<Card> _cards = new();

    public Deck()
    {
        Populate();
    } 
    
    public void Shuffle()
    {
        Random rnd = new();
        List<Card> copy = new(_cards);
        int total = _cards.Count;
        _cards.Clear();
        for (int i = 0; i < total; i++)
        {
            int id = rnd.Next(copy.Count);
            _cards.Add(copy[id]);
            copy.RemoveAt(id);
        }
    }

    public Card DealOneCard()
    {
        return Deal(1)[0];
    }

    public List<Card> Deal(int numberOfCards)
    {
        List<Card> dealt = new();
        
        for (int i = 0; i < numberOfCards; i++)
        {
            Card card = _cards[0];
            _cards.RemoveAt(0);
            dealt.Add(card);
        }

        return dealt;
    }

    public void Populate()
    {
        _cards.Clear();
        
        for (int i = 0; i < 4; i++)
            for (int j = 1; j < 14; j++) 
                _cards.Add(new Card(i, j));
    }
}





