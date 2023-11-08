using RestSharp;

namespace DeckOfCardsAPI.Models
{
    public class DeckDAL
    {
        public static DeckOfCards GetDeck()
        {
            string newDeck = @"https://deckofcardsapi.com/api/deck/new/shuffle/?deck_count=1";
            RestClient client = new RestClient(newDeck);
            RestRequest request = new RestRequest();
            DeckOfCards d = client.Get<DeckOfCards>(request);

            return d;
        }

        public static List<Card> DrawCard(string deck_id, int count)
        {
            string newCard = $@"https://deckofcardsapi.com/api/deck/{deck_id}/draw/?count={count}";
            RestClient client2 = new RestClient(newCard);
            RestRequest request2 = new RestRequest();
            Cards cards = client2.Get<Cards>(request2);
            return cards.cards.ToList();
     
        }

    }
}
