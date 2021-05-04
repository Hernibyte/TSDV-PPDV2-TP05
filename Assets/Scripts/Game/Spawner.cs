using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class Spawner : MonoBehaviour
{
    [SerializeField] GameObject enemy;
    [SerializeField] GameObject collectable;
    [SerializeField] int enemyLenght = 10;
    [SerializeField] int collectableLenght = 10;

    Vector3 spawnPosition;
    Vector3 spawnRotation;

    GameObject[] e;
    GameObject[] c;
    float timer = 0f;

    private void Start()
    {
        e = new GameObject[enemyLenght];
        c = new GameObject[collectableLenght];
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
        spawnPosition = new Vector3(Random.Range(405, 592), Terrain.activeTerrain.SampleHeight(transform.position) + transform.localScale.x / 2, Random.Range(402, 597));
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
            e[i] = Instantiate(enemy, spawnPosition, Quaternion.Euler(spawnRotation), this.transform);
        }
        for (int i = 0; i < collectableLenght; i++)
        {
            SetSpawnPosition();
            SetSpawnRotation();
            c[i] = Instantiate(collectable, spawnPosition, Quaternion.Euler(spawnRotation), this.transform);
        }
    }

    void DestroySpawn()
    {
        for (int i = 0; i < enemyLenght; i++)
        {
            Destroy(e[i]);
        }
        for (int i = 0; i < collectableLenght; i++)
        {
            Destroy(c[i]);
        }
    }
}
