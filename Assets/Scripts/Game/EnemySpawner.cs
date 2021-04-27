using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] GameObject enemy;
    [SerializeField] int enemyLenght = 10;
    Vector3 spawnPosition;
    GameObject[] ts;
    float timer = 0f;

    private void Start()
    {
        ts = new GameObject[enemyLenght];
    }

    void Update()
    {
        Generate();
    }

    void Generate()
    {
        Timer();
        if (timer >= 10f)
        {
            timer = 0f;
            DestroySpawn();
            Spawn();
        }
    }

    void Timer()
    {
        timer += Time.deltaTime;
    }

    void SetSpawnPosition()
    {
        spawnPosition = new Vector3(Random.Range(312, 693), 1.60f, Random.Range(303, 696));
    }

    void Spawn()
    {
        for (int i = 0; i < enemyLenght; i++)
        {
            SetSpawnPosition();
            ts[i] = Instantiate(enemy, spawnPosition, Quaternion.identity, this.transform);
        }
    }

    void DestroySpawn()
    {
        for (int i = 0; i < enemyLenght; i++)
        {
            Destroy(ts[i]);
        }
    }
}
