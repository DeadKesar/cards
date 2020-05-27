using Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Controller
{
    class CardController
    {
        private CardsArr cardsArr = new CardsArr();
        public int Count => cardsArr.cards.Count;
        public CardController()
        {
            cardsArr = new CardsArr();
        }
        public void Add(string question, string answer, int level = 0)
        {
            var card = new Card(question, answer, level);
            cardsArr.cards.Add(card);

        }
    }
}
