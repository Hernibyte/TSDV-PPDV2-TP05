using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectableBox : MonoBehaviour
{
    [SerializeField] int points = 200;
    Player player;

    private void OnTriggerEnter(Collider other)
    {
        player = other.transform.GetComponent<Player>();
        if (player != null)
        {
            player.TakePoints(points);
            Die();
        }
    }

    void Die()
    {
        Destroy(gameObject);
    }
}
