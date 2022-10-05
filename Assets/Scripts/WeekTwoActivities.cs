using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace CharlieHarrop
{
    public class WeekTwoActivities : MonoBehaviour
    {
        private string favouriteGame = "Outer Wilds";
        private int timePlayed = 58;
        private float costOfGame = 23.36f;

        // TODO Write code

        // Start is called before the first frame update
        void Start()
        {
            Debug.Log("My favourite game is " + favouriteGame + " I have played it for " + timePlayed + " hours, and it cost me $" + costOfGame + ". Therefore, my value of dollars per hour is $" + costOfGame / timePlayed + ".");
        

        }

        // Update is called once per frame
        void Update()
        {
        
        }
    }


}

