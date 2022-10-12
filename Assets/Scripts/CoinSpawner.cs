using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CharlieHarrop
{
    public class CoinSpawner : MonoBehaviour
    {
        [SerializeField] private GameObject coinPrefab;

        // Start is called before the first frame update
        private void Start()
        {
            SpawnCoin();
            SpawnCoin();
        }

        private void SpawnCoin() //spawns the coin in a random position
        {
            int xPosition = Random.Range(1, 100);
            int yPosition = Random.Range(1, 100);
            int zPosition = Random.Range(1, 100);

            Instantiate(coinPrefab, new Vector3(xPosition, yPosition, zPosition), Quaternion.identity);
        }
    }

}
