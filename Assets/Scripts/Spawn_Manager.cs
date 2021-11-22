using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn_Manager : MonoBehaviour


{
    public GameObject animalPrefab;
    public Vector3 spawnPosition = new Vector3(0, 0, 25);
    private float XRange = 17f;

    // Start is called before the first frame update
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
        spawnPosition = RandomSpawnPosition();
        Instantiate(animalPrefab, spawnPosition, animalPrefab.transform.rotation);
    }

}
