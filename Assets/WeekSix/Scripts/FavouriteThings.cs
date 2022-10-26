using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CharlieHarrop
{
    public class FavouriteThings : MonoBehaviour
    {
        [SerializeField] private string[] favouriteThings = new string[3] { "Mango", "Video Games", "Purple" };
        

        private void Start()
        {
            OutputFavouriteThings();
            InvokeRepeating("OutputFavouriteThings2", 5.0f, 2.0f);
        }


        private void Update()
        {
            
        }


        private void OutputFavouriteThings()
        {
            foreach(string things in favouriteThings)
            {
                Debug.Log(things);
            }
        }

        private void OutputFavouriteThings2()
        {
            string[] favouriteThings = new string[4] { "Mango", "Video Games", "Purple", "Noodles" };

            foreach (string things in favouriteThings)
            {
                Debug.Log(things);
            }
        }
    }
}

