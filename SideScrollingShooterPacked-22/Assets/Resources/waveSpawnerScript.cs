using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]

public class Wave
{
    public string testWave;
    public int numEnemies;
    public GameObject[] enemyType;
    public float spawnTimer;
}

public class waveSpawnerScript : MonoBehaviour
{
    [SerializeField] Wave[] Waves;
    [SerializeField] Transform[] spawnPoints;
}
