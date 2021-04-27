using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    [SerializeField] float damageAmount = 50f;
    [SerializeField] GameObject parent;
    Player player;

    private void OnTriggerEnter(Collider other)
    {
        player = other.transform.GetComponent<Player>();
        if (player != null)
        {
            player.TakeDamage(damageAmount);
            Die();
        }
    }

    void Die()
    {
        Destroy(parent);
    }
}
