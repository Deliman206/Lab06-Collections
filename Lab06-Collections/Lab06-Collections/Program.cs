using System;
using Lab06_Collections.Classes;
namespace Lab06_Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        static Decks<Cards> CreateDeck (Decks<Cards> dealerDeck)
        {
            foreach (CardSuits cardSuits in Enum.GetValues(typeof (CardSuits)))
            {
                foreach(CardValues cardValues in Enum.GetValues(typeof(CardValues)))
                {
                    Cards card = new Cards(cardValues, cardSuits);
                    dealerDeck.Add(card);
                }
            }
            return dealerDeck;
        }
        static void Deal(Decks<Cards> p1, Decks<Cards> p2, Decks<Cards> dealer)
        {

        }
    }
}
