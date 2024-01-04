using ThoughtformTCG.GameModels;

namespace ThoughtformTCG.GameControllers;
// To create a new deck in the Main Program simply use List<Card> nameOfDeck = new DeckBuilder.BuildDeck(1,1,1,1,1);
public class DeckBuilder
{
    private readonly LoadCard loadCard;
    private static readonly DeckBuilder instance = new DeckBuilder();

    public DeckBuilder()
    {
        // Create an instance of LoadCard
        loadCard = new LoadCard();
    }

    // Build a deck with specific cards based on their IDs
    public static List<Card> BuildDeck(params int[] cardIds)
    {
        List<Card> deck = new List<Card>();
        foreach (int cardId in cardIds)
        {
            Card? card = instance.loadCard.FindCardById(cardId);
            if (card != null)
            {
                deck.Add(card);
            }
        }
        return deck;
    }
    public void ShuffleDeck(List<Card> deck)
    {
        Random random = new Random();
        int n = deck.Count;
        while (n > 1)
        {
            n--;
            int k = random.Next(n + 1);
            Card value = deck[k];
            deck[k] = deck[n];
            deck[n] = value;
        }
    }
}