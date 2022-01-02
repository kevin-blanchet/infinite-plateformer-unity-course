using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    public GameObject coinPrefab;

    public float spawnChance = 50;

    // Start is called before the first frame update
    void Start()
    {
        if(Random.Range(0, 100) < spawnChance)
        {
            Instantiate(coinPrefab, transform);
        }
    }
}
