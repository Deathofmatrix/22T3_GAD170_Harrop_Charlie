// Created by Owen
// Adapted by Aaron & GAD170 class

using System.Collections.Generic;
using System;
using UnityEngine;

namespace CharlieHarrop
{
    enum CardSuit { Clubs, Spades, Hearts, Diamonds }

    public class Deck : MonoBehaviour
    {
        //A reference to the prefab of the class card
        [Header("References")]
        [SerializeField] private Card cardPrefab;

        [Header("Collections")]
        //Creates a list of Cards with the name deck
        [SerializeField] private List<Card> deck;
        //Creates a string of the card values 
        private string[] values = new string[13] { "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King" };

        void Start()
        {
            //The suit variable is whatever loop the foreach is up to, for example the first loop would be then Clubs then Spades then Hearts then Diamonds
            //Enum.GetValues(typeof(CardSuit)??
            //foreach loop goes through each value per suit, this is the point of having the loops inside of each other
            foreach (CardSuit suit in Enum.GetValues(typeof(CardSuit)))
            {
                foreach (string value in values)
                {
                    //Instantiate creates a new copy of the game object 
                    Card _newCard = Instantiate(cardPrefab, transform);

                    _newCard.value = value;
                    _newCard.suit = suit.ToString();
                    _newCard.name = value + " of " + suit;

                    deck.Add(_newCard);
                }
            }
        }
    }
}