namespace ThoughtformTCG.GameModels
{
    public class CardContainer
    {
        protected internal List<Card> Cards { get; private set; }

        public CardContainer()
        {
            Cards = new List<Card>();
        }
    }

    public class PlayerHand : CardContainer
    {
        // Additional methods or properties for managing a player's hand
    }

    public class LostPile : CardContainer
    {
        // Additional methods or properties for managing a player's lost pile
    }

    public class MainDeck : CardContainer
    {
        // Additional methods or properties for managing the main deck
    }

    public class RevisionDeck : CardContainer
    {
        // Additional methods or properties for managing the revision deck
    }
    public class Player
    {
        public PlayerHand Hand { get;  set; }
        public LostPile LostPile { get;  set; }
        public MainDeck MainDeck { get;  set; }
        public RevisionDeck RevisionDeck { get;  set; }

        public Player()
        {
            Hand = new PlayerHand();
            LostPile = new LostPile();
            MainDeck = new MainDeck();
            RevisionDeck = new RevisionDeck();
        }

        // Additional methods or properties for managing a player
    }
}
