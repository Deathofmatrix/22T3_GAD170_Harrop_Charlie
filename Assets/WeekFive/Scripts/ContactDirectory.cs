using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CharlieHarrop
{
    public class ContactDirectory : MonoBehaviour
    {
        //square braces makes it an array
        //[SerializeField] private Contact[] contacts;

        //lists are arrays that can change size
        [SerializeField] private List<Contact> contacts = new List<Contact>();

        private void Start()
        {
            //Loops through the collection
            //create integer called i and give the value of 0
            //if i < count then do things in loop
            //Then increase i by 1
            for (int i = 0; i < contacts.Count; i++)
            {
                contacts[i].Initialize();  
            }
        }
    }

}
