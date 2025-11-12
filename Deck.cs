using System.Collections.ObjectModel;



    public class Deck
    {
        public static string[] RankNames =
        {
            "2", "3", "4", "5", "6", "7", "8", "9", "10",
            "Jack", "Queen", "King", "Ace"
        };

        public static string[] Suits =
        {
            "Hearts", "Diamonds", "Clubs", "Spades"
        };


        // Create a public int property Count that returns the Count value from the private collection _cards
      //  private List<Card> cards;

    // Create a private field _cards that is a List<Card>
    private List<Card> _cards; 

        // Create a public int property Count that returns the Count value from the private collection _cards
        public int Count => _cards.Count;

        // Create a public constructor that takes two parameter: a List<card> called cards and a boolean value called isEmptyDeck
        // If cards is not null and has elements in it, assign it to _cards and be done
        // If cards is null or empty:
        //     _cards should be initialized as an empty List<Card>
        //     InitializeDeck() should be called if and only if isEmptyDeck is false
        public Deck(List<Card> cards, bool isEmptyDeck = false)//constructor
        {
            if (cards != null && cards.Count > 0)
            {
                _cards = cards;
            }
            else
            {
                _cards = new List<Card>();
                if (!isEmptyDeck)
                {
                    InitializeDeck();
                    
                    //System.Console.WriteLine(_cards.Count);
                }
            }


        }  // Card newCard = new Card(suits[i], i);
           // card.Add(newCard);


        // Create a private void method called InitializeDeck() which does the following:
        // Use RankNames and Suits in nested loops to generate all 52 combinations of rank and suit and add them to _cards
        string[] suits = ["clubs", "hearts", "spades", "dimonds"];
        private void InitializeDeck()
        {
            // string[] suits = ["clubs", "hearts", "spades", "dimonds"];


            for (int i = 0; i <= 12; i++)
            {
                for (int j = 0; j < suits.Length; j++)
                {
                Card newCard = new Card(suits[j], i);
                    
                    System.Console.WriteLine($"rank: {newCard.Rank}");

                    _cards.Add(newCard);
                }
            }
        }

        // Create a public void method called Shuffle() which shuffles (rearranges) the cards in _deck
        public void Shuffle()
        //finish: make a for loop and Assign i the value of a random number up to the length of card
        //makes new list of cards
        {
        List<Card> newCards = new List<Card>();

        int Length = _cards.Count;
            
            for (int i = 0; i < Length; i++)
            {
                Random rand = new Random();
                int n = rand.Next(_cards.Count);

                Card card2 = _cards[n];

                _cards.RemoveAt(n);

                newCards.Add(card2);
            }

            _cards = newCards;

        }

        // Create a public method CardAtIndex which takes an int parameter(variable) for the index of a card and
        // returns the card at the index specified(no new variable: use Card), or throws IndexOutOfRangeException if index is too large or too small


 
        public Card CardAtIndex(int index)
        //creates a card at a particular index 
        {
            if (index < 0 || index >= _cards.Count)
            {
                throw new IndexOutOfRangeException("Index is out of range");
            }
            return _cards[index];
        }

        // Create a public method PullCardAtIndex which does exactly the same thing as CardAtIndex
        // with the additional feature that it _removes_ the card from the deck

        public Card PullCardAtIndex(int index)
        //removes card at particular index
        {
            if (index < 0 || index >= _cards.Count)
            {
                throw new IndexOutOfRangeException("Index is out of range");
            }

             else //(card == card)
            {
                Card DuplicateCard = _cards[index];

                //deck.Remove(CardAtIndex);
                _cards.RemoveAt(index);
                return DuplicateCard;
            }
           //return card[index];
        }

        // Create a public method PullAllCards that returns a list of all of the cards in the deck
        // and removes them all from the deck, leaving it empty

        public List<Card> PullAllCards()
        //removes all cards from deck
        //did i already do this in SHUFFLE?---
        {
            List<Card> allCards = _cards;
            _cards.Clear();
            return allCards;
        }



        // Create a public method PushCard that accepts a Card as a parameter and adds it to _deck

        public void PushCard(Card newCard)
        //adds a card to the deck
        {
            _cards.Add(newCard);
        }



        // Create a public method PushCards that accepts a List<Card> as a parameter and adds the list to _cards
        // Be sure to use AddRange and not Add

        public void PushCards(List<Card> newCards)
        //adds a list of cards to the deck
        {
           _cards.AddRange(newCards);
        }


        // Create a public method Deal that accepts an integer representing the number of cards to deal
        // and then removes that many cards from the deck, returning them as a List<Card>
        // Be sure to check the size of _deck against the number of cards requested so you don't go out
        // of bounds

        public List<Card> Deal(int numberOfCards)
        //deals a certain number of cards from the deck
        {
            if (numberOfCards < 0 || numberOfCards > _cards.Count)
        {
                //System.Console.WriteLine(_cards.Count);

                throw new ArgumentOutOfRangeException("Number of cards requested is out of range");
            }

            List<Card> dealtCards = new List<Card>();

            for (int i = 0; i < numberOfCards; i++)
            {
                dealtCards.Add(_cards[0]);
                _cards.RemoveAt(0);
            }

            return dealtCards;
        }

    }


       

        
