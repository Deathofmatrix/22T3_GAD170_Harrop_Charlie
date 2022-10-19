using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CharlieHarrop
{
    public enum Seinfeld { Undefined, GeorgeCostanza, JerrySeinfeld, ElaineBenes }

    public class Contact : MonoBehaviour
    {
        [SerializeField] private Seinfeld character = Seinfeld.Undefined;
        [SerializeField] private string firstName;
        [SerializeField] private string lastName;
        [SerializeField] private string pronouns;
        [SerializeField] private string phoneNumber;
        [SerializeField] private string address;
        [SerializeField] private string email;

        public void Initialize()
        {

            //switch statement
            switch (character)
            {
                case Seinfeld.Undefined:
                    Debug.Log("Character Undefined. Set enum in editor");
                    break;
                case Seinfeld.GeorgeCostanza:
                    Setup("George", "Costanza", "He/Him", "99670714", "1344 Queens Boulevard", "Jason.Alexander@hotmail.com");
                    break;
                case Seinfeld.JerrySeinfeld:
                    Setup("Jerry", "Seinfeld", "He/Him", "0490158082", "18 Jerrys house", "Seinfeld@gamil.com");
                    break;
                case Seinfeld.ElaineBenes:
                    Setup("Elainse", "Benes", "She/Her", "0490274342", "18 Elaines house", "Benes@gamil.com");
                    break;
            }

            
          
          
        }
        private void Setup(string newFirstName,
                           string newLastName,
                           string newPronouns,
                           string newPhoneNumber,
                           string newAddress,
                           string newEmail)
        {
            firstName = newFirstName;
            lastName = newLastName;
            pronouns = newPronouns;
            phoneNumber = newPhoneNumber;
            address = newAddress;
            email = newEmail;
        }
    }
}
