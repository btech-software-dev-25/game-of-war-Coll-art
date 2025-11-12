

    public class Card
    {

        // Create a string property Suit with a private setter
        public string Suit { get; private set; }

        // Create an int property Rank with a private setter - values should range from 0 for a face value of 2 to 12 for an Ace
        public int Rank { get; private set; }


        // Create a public constructor that takes suit and rank as arguments and assigns them to Suit and Rank
        public Card(string suit, int rank)
        {
            Suit = suit;

            Rank = rank;
        }

        // Overload the > operator to compare two cards by rank
        public static bool operator >(Card c1, Card c2)
        {
            return c2.Rank > c1.Rank;
        }


        // Overload the < operator to compare two cards by rank
        public static bool operator <(Card c1, Card c2)
        {
            return c1.Rank < c2.Rank;
        }



    // Create a public string method RankString that returns a string representation of this card's rank, 2-10 and Jack, Queen, King, Ace
    public string RankString()
    {
        string[] ranks = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King", "Ace" };

        return ranks[Rank];
        
        // return Rank switch
        // {
        //     0 => "2",
        //     1 => "3",
        //     2 => "4",
        //     3 => "5",
        //     4 => "6",
        //     5 => "7",
        //     6 => "8",
        //     7 => "9",
        //     8 => "10",
        //     9 => "Jack",
        //     10 => "Queen",
        //     11 => "King",
        //     12 => "Ace",
        //     _ => "Unknown"
        // };

    }

    }   
