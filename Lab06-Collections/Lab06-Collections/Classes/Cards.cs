using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Lab06_Collections.Classes
{
    public enum CardSuits
    {
        [DisplayName("&hearts")]
        Hearts,
        [DisplayName("&spades")]
        Spades,
        [DisplayName("&diamonds")]
        Diamonds,
        [DisplayName("&clubs")]
        Clubs
    };
    public enum CardValues { A, One, Two, Three, Four, Five, Six, Seven, Eight, Nine, Ten, Jack, Queen, King };

    public class Cards
    {
        public CardValues Value { get; set; }
        public CardSuits Suit { get; set; }

        public Cards(CardValues cardValue, CardSuits cardSuit)
        {
            Value = cardValue;
            Suit = cardSuit;
        }
    }
}
