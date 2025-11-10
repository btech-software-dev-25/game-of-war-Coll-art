using System.Collections.ObjectModel;

namespace GameOfWar
{
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
        public int collection_cards;

        // Create a private field _cards that is a List<Card>
        private List<Card> card; 

        // Create a public constructor that takes two parameter: a List<card> called cards and a boolean value called isEmptyDeck
        // If cards is not null and has elements in it, assign it to _cards and be done
        // If cards is null or empty:
        //     _cards should be initialized as an empty List<Card>
        //     InitializeDeck() should be called if and only if isEmptyDeck is false
        public Deck(List<Card> cards, bool isEmptyDeck = false)//constructor
        {
            if (cards != null && cards.Count > 0)
            {
                card = cards;
            }
            else
            {
                card = new List<Card>();
                if (!isEmptyDeck)
                {
                    InitializeDeck();
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
                    card.Add(newCard);
                }
            }
        }

        // Create a public void method called Shuffle() which shuffles (rearranges) the cards in _deck
        public void Shuffle()
        //finish: make a for loop and Assign i the value of a random number up to the length of card
        //makes new list of cards
        {
            List<Card> newCards = new List<Card>();
            
            for (int i = 0; i < card.Count; i++)
            {
                Random rand = new Random();
                int n = rand.Next(52) + 1;

                Card card2 = card[i];

                card.RemoveAt(n);

                newCards.Add(card2);
            }

            card = newCards;

        }

        // Create a public method CardAtIndex which takes an int parameter(variable) for the index of a card and
        // returns the card at the index specified(no new variable: use Card), or throws IndexOutOfRangeException if index is too large or too small


 
        public Card CardAtIndex(int index)
        //creates a card at a particular index 
        {
            if (index < 0 || index >= collection_cards)
            {
                throw new IndexOutOfRangeException("Index is out of range");
            }
            return card[index];
        }

        // Create a public method PullCardAtIndex which does exactly the same thing as CardAtIndex
        // with the additional feature that it _removes_ the card from the deck

        public Card PullCardAtIndex(int index)
        //removes card at particular index
        {
            if (index < 0 || index >= collection_cards)
            {
                throw new IndexOutOfRangeException("Index is out of range");
            }

            if (card == card)
            {
                //deck.Remove(CardAtIndex);
                card.Remove(CardAtIndex);
                return card[index];
            }
            return card[index];
        }

        // Create a public method PullAllCards that returns a list of all of the cards in the deck
        // and removes them all from the deck, leaving it empty

        public List<Card> PullAllCards()
        //removes all cards from deck
        //did i already do this in SHUFFLE?---
        {
            List<Card> allCards = card;
            card.Clear();
            return allCards;
        }



        // Create a public method PushCard that accepts a Card as a parameter and adds it to _deck

        public void PushCard(Card newCard)
        //adds a card to the deck
        {
            card.Add(newCard);
        }



        // Create a public method PushCards that accepts a List<Card> as a parameter and adds the list to _cards
        // Be sure to use AddRange and not Add

        public void PushCards(List<Card> newCards)
        //adds a list of cards to the deck
        {
            card.AddRange(newCards);
        }


        // Create a public method Deal that accepts an integer representing the number of cards to deal
        // and then removes that many cards from the deck, returning them as a List<Card>
        // Be sure to check the size of _deck against the number of cards requested so you don't go out
        // of bounds

        public List<Card> Deal(int numberOfCards)
        //deals a certain number of cards from the deck
        {
            if (numberOfCards < 0 || numberOfCards > collection_cards)
            {
                throw new ArgumentOutOfRangeException("Number of cards requested is out of range");
            }

            List<Card> dealtCards = new List<Card>();

            for (int i = 0; i < numberOfCards; i++)
            {
                dealtCards.Add(card[0]);
                card.RemoveAt(0);
            }

            return dealtCards;
        }

    }
}

       

        
        //shuffle
  // public void Shuffle()
        // {
        //     Random rand = new Random();
        //     int n = card.Count;
        //     for (int i = n - 1; i > 0; i--)
        //     {
        //         int j = rand.Next(0, i + 1);
        //         // Swap card[i] with the element at random index
        //         Card temp = card[i];
        //         card[i] = card[j];
        //         card[j] = temp;
        //     }
        // }



        //remove
        // public Card PullCardAtIndex(int index)
        // {
        //     if (index < 0 || index >= collection_cards)
        //     {
        //         throw new IndexOutOfRangeException("Index is out of range");
        //     }
        //     Card card = card[index];
        //     card.RemoveAt(index);
        //     return card;
        // }
