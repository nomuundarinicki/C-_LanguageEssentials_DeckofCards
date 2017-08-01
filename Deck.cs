using System.Collections.Generic;

namespace cards
{
    public class Deck{
        public List<Card> cards;
        
        public Deck()
        {
            reset();
            shuffle();

        }
        public Deck reset()
        {   
            cards =  new List<Card>();
            string [] suits = {"heats", "diamonds", "spades", "clubs"};
            string [] strVals = {"Ace","two","three","four","five","six","seven","eight","nine","ten","jack","queen", "king",};

            foreach(string Suit in suits)
            {
                // build out set of individual cards 
                for ( int  i = 0; i <strVals.Length; i++ )
                {
                    Card noob = new Card(strVals[i], Suit, i+1);
                    cards.Add(noob);
                }
            
            }
            return this;
        }   
        public Card deal()
        {
            if (cards.Count > 0)
            {
                //grab top card
            Card res = cards[0];
            //remove card
            cards.RemoveAt(0);
            //return card 
            return res;
            }
            else{
                reset();
                return deal();
            }
        }

    }
}