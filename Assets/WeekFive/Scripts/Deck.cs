using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CharlieHarrop
{
    public class Deck : MonoBehaviour
    {
        [SerializeField] private List<Card> cards = new List<Card>();

        private void Start()
        {
            /*for (int i = 0; i < cards.Count; i++)
            {
                cards[i]
            }
            */
        }
    }

}