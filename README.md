# card_deck_library
A library for implementing a standard deck of poker-style playing cards.


---

## Deck

### Constructor
```csharp
Deck d = new Deck();
```

### Properties

#### Cards
List of class Card. Populated on initialization.

### Methods

#### Shuffle

Shuffles the current cards in the deck.
```csharp
d.Shuffle();
```

#### Deal

Deals x cards out of the deck.
```csharp
List<Card> hand = d.Deal(amount);
```

#### DealOneCard

Deals the top card of the deck.
```csharp
Card c = d.DealOneCard();
```

#### DealToPlayers
Deals cards from the top of the deck for each player given.

Returns a List of Lists of Cards, where the outer list is the player, and each inner list is the cards for that player.
```csharp
List<List<Card>> playersCards = d.DealToPlayers(4, 5);
```

#### Populate

Populates the deck with 52 cards; 13 ranks for 4 suits.
```csharp
d.Populate();
```


---

## Card

### Constructor
```csharp
Card c = new Card(suit, rank);
```

### Properties

#### Rank
An instance of the Rank class denoting what rank (or value) this card is.

#### Suit
An instance of the Suit class denoting what suit this card is.

### Methods

#### IsSameColor
Determines if the given card is the same suit as the argument card.
```csharp
bool result = c.IsSameColor(new Card(1, 1));
```

#### IsDifferentColor
Determines if the given card is a different suit as the argument card.
```csharp
bool result = c.IsDifferentColor(new Card(1, 1));
```

#### IsSameSuit
Determines if the given card is the same suit as the argument card.
```csharp
bool result = c.IsSameSuit(new Card(1, 1));
```

#### ToString
Returns the string represtation of the card.
EX: Ace of Hearts, King of Diamonds, 5 of Clubs
```csharp
c.ToString();
```

#### operator >
Compare the value of a given card with the argument card.
```csharp
bool result = c > new Card(1, 1);
```

#### operator <
Compare the value of a given card with the argument card.
```csharp
bool result = c < new Card(1, 1);
```

#### operator ==
Compare if the suit and rank of a given card match the suit and rank of the argument card.
```csharp
bool result = c == new Card(1, 1);
```

#### operator !=
Compare if the suit or rank of a given card does not match the suit and rank of the argument card.
```csharp
bool result = c != new Card(1, 1);
```
---

## Rank
```csharp
Rank r = new Rank(value);
```

### Properties

#### Value
The value of the rank of the card.
```csharp
int v = r.Value
```

### Methods

#### ToString
Returns the text representation of the card rank.
```csharp
r.ToString();
```

---

## Suit
```csharp
Suit s = new Suit(0);
Suit s = new Suit("Hearts");
```

### Properties

#### Color
Returns the color of the suit.
```csharp
s.Color();
```

### Methods

#### ToString
Returns the string representation of the card suit.
```csharp
s.ToString();
```

#### operator ==
Compare against another suit for a match.
```csharp
s == new Suit(0);
```

#### operator !=
Compare against another suit for a non-match.
```csharp
s != new Suit("Diamonds");
```
