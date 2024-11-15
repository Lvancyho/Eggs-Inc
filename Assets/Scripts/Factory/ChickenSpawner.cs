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
            Vector3 randomSpawnPosition = new Vector3(Random.Range(0, 12), 5, Random.Range(0, 14));

            Instantiate(myObjects[randomIndex], randomSpawnPosition, Quaternion.identity);
        }    
    }
}