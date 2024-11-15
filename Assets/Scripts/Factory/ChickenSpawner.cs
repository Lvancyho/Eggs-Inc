using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChickenSpawner : MonoBehaviour
{
    public GameObject[] myObjects;

    public void Update()
    {
        if (Input.anyKeyDown)
        {
            int randomIndex = Random.Range(0, myObjects.Length);
            Vector3 randomSpawnPosition = new Vector3(Random.Range(-2, 2), 1, Random.Range(12, 16));

            Instantiate(myObjects[randomIndex], randomSpawnPosition, Quaternion.identity);
        }
    }
}