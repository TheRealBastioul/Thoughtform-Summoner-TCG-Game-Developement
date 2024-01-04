namespace ThoughtformTCG.GameModels
{
    public static class CardTransfer
    {
        public static void AddFromExisting(List<Card> sourceDeck, List<Card> destinationPile, int cardIndex)
        {
            if (cardIndex >= 0 && cardIndex < sourceDeck.Count)
            {
                Card cardToAdd = sourceDeck[cardIndex];
                destinationPile.Add(cardToAdd);
                sourceDeck.RemoveAt(cardIndex);
            }
            else
            {
                // Handle an invalid index, for example, by throwing an exception or logging an error.
            }
        }

        public static void RemoveCard(List<Card> pile, Card card)
        {
            pile.Remove(card);
        }

        public static void ClearPile(List<Card> pile)
        {
            pile.Clear();
        }

        // Add any other methods or properties relevant to transferring cards
    }
}
