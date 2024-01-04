using System.Text.Json;
using ThoughtformTCG.GameModels;

namespace ThoughtformTCG.GameControllers
{
    public class LoadCard
    {
        private List<Card> cardList;

        public LoadCard()
        {
            cardList = new List<Card>();
            // Automatically load card information from JSON file
            LoadCards();
        }

        private void LoadCards()
        {
            // Assuming "cards.json" is in the same directory as the executable.
            string jsonFilePath = Path.Combine("..", "..", "..", "Data", "Cards", "JSON", "cards.json");
            Console.WriteLine($"Current Directory: {Environment.CurrentDirectory}");
            if (File.Exists(jsonFilePath) && jsonFilePath != null)
            {
                using (StreamReader reader = new StreamReader(jsonFilePath))
                {
                    string cardJson = reader.ReadToEnd();
                    cardList = JsonSerializer.Deserialize<List<Card>>(cardJson) ?? new List<Card>();
                }
            }
            else
            {
                // Handle the case where the file is not found.
                Console.WriteLine("Error: cards.json not found.");
                cardList = new List<Card>(); // Initialize an empty list or handle differently as needed.
            }
        }

        // Helper method to find a card by its ID using LINQ
        public Card? FindCardById(int id)
        {
            // Check if cardList is not null before using FirstOrDefault
            return cardList.FirstOrDefault(card => card.CardID == id);

        }


        // Expose the cardList if needed
        public List<Card> GetCardList()
        {
            return cardList;
        }
    }
}
