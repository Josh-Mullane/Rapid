using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{

    public GameObject enemyToSpawn;
    public float spawnRate;
    public int countToSpawn;

    private float time = 0;
    private int spawned = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if(time>spawnRate)
        {
            GameObject enemy = Instantiate(enemyToSpawn, transform.position, transform.rotation);
            enemy.GetComponent<ButterflyMover>().hSpeed = Random.Range(0.1f, 1.5f);
            enemy.GetComponent<ButterflyMover>().maxYOffset = Random.Range(0.1f, 2.5f);

            time = 0;
            ++spawned;
            if (spawned > countToSpawn)
            {
                Destroy(gameObject);
            }
        }
    }
}
