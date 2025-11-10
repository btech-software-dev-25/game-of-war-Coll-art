






// Create an instance of the GameState class
using System.Data;

GameState state = new GameState();

System.Console.WriteLine(state.CardDeck.Count);


// Shuffle CardDeck within your instance
state.CardDeck.Shuffle();

System.Console.WriteLine(state.CardDeck.Count);

// Deal 26 cards each from CardDeck to your instance's PlayerDeck and ComputerDeck
state.PlayerDeck = new Deck(state.CardDeck.Deal(26));

System.Console.WriteLine(state.CardDeck.Count);

state.ComputerDeck = new Deck(state.CardDeck.Deal(26));



// Create a function with the signature: static bool PlayCards(GameState state, int playerCardIndex)
// The function should:
//     Pull the card at playerCardIndex from state.PlayerDeck
//     Pull the card at index 0 from state.ComputerDeck
//     Compare the two cards
//         If the player card is higher, the player gets both cards along with any in state.TableDeck
//         If the computer card is higher, the computer gets both cards along with any in state.TableDeck
//         If the player and computer cards are the same, both cards go into state.TableDeck
//     Check whether either state.PlayerDeck or state.ComputerDeck are empty
//         If the computer deck is empty, the player wins and state.Winner should be set to "Computer"
//         If the player deck is empty, the computer wins and state.Winner should be set to "Player"
//     return true

static bool PlayCards(GameState state, int playerCardIndex)
{
    state.PlayerDeck.PullCardAtIndex(playerCardIndex);

    state.ComputerDeck.PullCardAtIndex(0);

    Card playerCard = state.PlayerDeck.CardAtIndex(playerCardIndex);
    Card computerCard = state.ComputerDeck.CardAtIndex(0);
    if (playerCard > computerCard)
    {
        //player gets both cards and any in TableDeck
        List<Card> wonCards = new List<Card>
        {
            playerCard,
            computerCard
        };
        wonCards.AddRange(state.TableDeck.PullAllCards());
        state.PlayerDeck.PushCards(wonCards);
    }
    else if (computerCard > playerCard)
    {
        //computer gets both cards and any in TableDeck
        List<Card> wonCards = new List<Card>
        {
            playerCard,
            computerCard
        };
        wonCards.AddRange(state.TableDeck.PullAllCards());
        state.ComputerDeck.PushCards(wonCards);
    }
    else
    {
        //both cards go into TableDeck
        state.TableDeck.PushCard(playerCard);
        state.TableDeck.PushCard(computerCard);
    }

   return true;
}




// Call Lib.RunGame(), passing two parameters: the state object you instantiated above and the name of your PlayCards function

Lib.RunGame(state, PlayCards);

/*
namespace GameOfWar
{
    public class GameState
    {
        // Create a public Deck property called CardDeck
        public Deck CardDeck { get; set; }

        // public Deck = CardCeck

        // Create a public Deck property called PlayerDeck
        public Deck PlayerDeck { get; set; }

        // Create a public Deck property called ComputerDeck

        public Deck ComputerDeck { get; set; }

        // Create a public Deck property called TableDeck

        public Deck TableDeck { get; set; }

        // Create a public string property called Winner
        public string Winner { get; set; }


        // Create a public constructor that accepts no parameters. It should:
        //    Initialize Winner to be empty (not null)
        //    Initialize CardDeck to be a new, fresh deck of 52 cards
        //    Initialize PlayerDeck, ComputerDeck, and TableDeck to be empty Deck objects (no cards)
    }
}
*/

// ~~~
// GameState state = new GameState();
// state.CardDeck.Shuffle();
// state.PlayerDeck = new Deck(state.CardDeck.Deal(26));
// state.ComputerDeck = new Deck(state.CardDeck.Deal(26));
/*
static bool PlayCards(GameState state, int playerCardIndex);
{
    return true;
}
*/
//~~~~
