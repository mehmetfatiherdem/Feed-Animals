using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private float spawnPosX = 20;
    private float spawnPosZ = 20;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.S))
        {
            int randomIndex = Random.Range(0, animalPrefabs.Length);
            GameObject randomAnimal = animalPrefabs[randomIndex];
            Vector3 randomPos = new(Random.Range(-spawnPosX, spawnPosX), 0, spawnPosZ);
            Instantiate(randomAnimal, randomPos, randomAnimal.transform.rotation);
        }
    }

}
