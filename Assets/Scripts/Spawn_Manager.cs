using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class Spawn_Manager : MonoBehaviour


{
    public GameObject[] animalPrefabs;
    public Vector3 spawnPosition = new Vector3(0, 0, 25);
    private float XRange = 17f;
   
    
    void Start()
    {
        InvokeRepeating("SpawmAnimal", 3, 0.5f);
    }



    public Vector3 RandomSpawnPosition()
    {
        float randoX = Random.Range(-XRange,XRange);
        return new Vector3(randoX, 0, 25);
    }

   public void SpawmAnimal()
    {
        int animal = Random.Range(0, animalPrefabs.Length);
        spawnPosition = RandomSpawnPosition();
        Instantiate(animalPrefabs[animal], spawnPosition, animalPrefabs[animal].transform.rotation);
    }

}
