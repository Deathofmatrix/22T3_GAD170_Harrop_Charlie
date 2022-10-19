using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CharlieHarrop
{
    public enum CardSuit { Clubs, Spades, Hearts, Diamonds }
    public class Card : MonoBehaviour
    {
        [SerializeField] private CardSuit suit;
        [SerializeField] private string[] cardValue = { "A", "2", "3","4"," 5", "6", "7", "8", "9", "J", "Q", "K"};

        private void Start()
        {
            
        }

    }
}
