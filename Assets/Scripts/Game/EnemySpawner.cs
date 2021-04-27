using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] GameObject enemy;
    [SerializeField] int enemyLenght = 10;
    Vector3 spawnPosition;
    Vector3 spawnRotation;
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
        spawnPosition = new Vector3(Random.Range(405, 592), 1.60f, Random.Range(402, 597));
    }

    void SetSpawnRotation()
    {
        spawnRotation = new Vector3(0f, Random.Range(0, 360), 0f);
    }

    void Spawn()
    {
        for (int i = 0; i < enemyLenght; i++)
        {
            SetSpawnPosition();
            SetSpawnRotation();
            ts[i] = Instantiate(enemy, spawnPosition, Quaternion.Euler(spawnRotation), this.transform);
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
