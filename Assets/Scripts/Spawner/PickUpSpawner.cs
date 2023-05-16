using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpSpawner : MonoBehaviour
{
    public Pickup[] picks;
    public float spawnDelay;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnPickUps", spawnDelay, spawnDelay);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void SpawnPickUps()
    {
       // Vector2 randomPosition = new Vector2(Random.RandomRange);

        int randomIndex = Random.Range(0, picks.Length);
       // Instantiate(picks[randomIndex], randomPosition, transform.rotation);
    }
}
