using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{

    public GameObject enemyToSpawn, enemyToSpawn2;
    public float spawnRate, spawnRate2;
    public int countToSpawn;

    private float time, time2 = 0;
    private int spawned = 0;
    
    void Start()
    {
        
    }

   
    void Update()
    {
        time += Time.deltaTime;
        time2 += Time.deltaTime;
        if(time>spawnRate && spawned < countToSpawn)
        {
            GameObject enemy = Instantiate(enemyToSpawn, transform.position, transform.rotation);
            enemy.GetComponent<ButterflyMover>().hSpeed = Random.Range(0.1f, 1.5f);
            enemy.GetComponent<ButterflyMover>().maxYOffset = Random.Range(0.1f, 2.5f);

           

            time = 0;
            ++spawned;
            
        }
        if(time2>spawnRate2 && spawned < countToSpawn)
        {
            GameObject enemy2 = Instantiate(enemyToSpawn2, transform.position, transform.rotation);
            enemy2.GetComponent<MushroomMover>().hSpeed = Random.Range(0.1f, 1.5f);
            enemy2.GetComponent<MushroomMover>().maxYOffset = -7.0f;

            time2 = 0;
            ++spawned;
        }
    }
}
