using ThoughtformTCG.GameControllers;
using ThoughtformTCG.GameModels;
namespace ThoughtformTCG
{
    class Program
    {
        static void Main(string[] args)
        {

            // Build a deck with more than 10 cards based on their IDs
            List<Card> deck = DeckBuilder.BuildDeck(1, 2, 1, 1);
            Player player1 = new Player();
            Console.WriteLine($"{deck[0].Affinity}");
            deck[0].ChangeAffinity("Penis");
            Console.WriteLine($"{deck[0].Affinity}");
            player1.MainDeck.Cards.AddRange(deck);
            foreach (Card card in player1.MainDeck.Cards)
            {
                Console.WriteLine($"{card.Name}");
            }
            CardTransfer.ClearPile(player1.MainDeck.Cards);
            foreach (Card card in player1.MainDeck.Cards)
            {
                Console.WriteLine($"{card.Name}");
            }
        }
    }
}
