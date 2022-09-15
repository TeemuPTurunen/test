﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace korttipeli
{
    class Deck
    {
        // properties
        public List<Card> Cards = new List<Card>();

        // methods
        public void fillDeck() // generate all cards
        {
            // 13 is the number of different values in a default
            // playcard deck
            const int numberOfValuesInDeck = 13;
            // luodaan yksi kappale jokaista korttia
            // arvot 1-13
            // jokaisesta maasta kortit - 4
            // tallennetaan Cards listaan
            // 1-13
            for (int i = 1; i <= numberOfValuesInDeck; i++)
            {
                // 4 kpl maata
                foreach (Card.Suites suite in Enum.GetValues(typeof(Card.Suites))) // käydään läpi kaikki maat
                {
                    Card temp = new Card(i, suite);
                    Cards.Add(temp);
                }
            }

            int helper = 5; // stop debugger
        } // fillDeck() päättyy

        public Card drawCard()
        {
            // exception, jos pakka on tyhjä
            const int indexOfThefirstCardOfDeck = 0;
            // kopioidaan
            Card temp = Cards[indexOfThefirstCardOfDeck]; 
            // poistetaan
            Cards.RemoveAt(indexOfThefirstCardOfDeck);

            return temp;
        }

    }
}