using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private float spawnRangeX = 20;
    private float spawnPosZ = 20;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update() 
    {
        if (Input.GetkeyDown(KeyCode.S))
        {
            int animalIndex = Random.Range(0, animalPrefabs.Length)
                Vector3 spwnPos = new Vector3(Random.Range(-spawnRangeX, spwnRageX), 0, spawnPosZ);

            Instantiate(animalPerfabs[animalIndex],spawnPos, animalPerfabs[animalIndex].transform.rotation);
        }
    }
    
}