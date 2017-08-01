using System.Collections.Generic;

namespace cards{
    public class Player {
        public string name;
        private List<Card> hand;
        public Player(string n){
            hand = new List<Card>();
            name = n;
        }
        public void DrawFrom(Deck currentDeck){
            hand.Add(currentDeck.Deal)();
        }
    }
}