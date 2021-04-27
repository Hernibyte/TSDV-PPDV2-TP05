using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectableSpawner : MonoBehaviour
{
    [SerializeField] GameObject collectable;
    [SerializeField] int collectableLenght = 10;
    Vector3 spawnPosition;
    GameObject[] ts;
    float timer = 0f;

    void Start()
    {
        ts = new GameObject[collectableLenght];
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

    void Spawn()
    {
        for (int i = 0; i < collectableLenght; i++)
        {
            SetSpawnPosition();
            ts[i] = Instantiate(collectable, spawnPosition, Quaternion.identity, this.transform);
        }
    }

    void DestroySpawn()
    {
        for (int i = 0; i < collectableLenght; i++)
        {
            Destroy(ts[i]);
        }
    }
}
