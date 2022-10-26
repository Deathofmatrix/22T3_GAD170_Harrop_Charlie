using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

namespace AngelaCharlie
{
    public class ColourChanger : MonoBehaviour
    {

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            if (transform.position.x < 0)
            {
                GetComponent<SpriteRenderer>().color = Color.red;
            }
            else if (transform.position.x > 0)
            {
                GetComponent<SpriteRenderer>().color = Color.green;
            }
            else
            {
                GetComponent<SpriteRenderer>().color = Color.white;
            }
        }
    }
}