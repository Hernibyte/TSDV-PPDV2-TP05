using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] float health = 100f;
    [SerializeField] float damageAmount = 50f;
    [SerializeField] int pointsAmount = 100;
    Player player;

    public void TakeDamage(float amount, Player pj)
    {
        health -= amount;
        if (health <= 0f)
        {
            IfDie(pj);
            Die();
        }
    }

    void IfDie(Player pj)
    {
        pj.TakePoints(pointsAmount);
    }

    void Die()
    {
        Destroy(gameObject);
    }

    private void OnTriggerEnter(Collider other)
    {
        player = other.transform.GetComponent<Player>();
        if (player != null)
        {
            player.TakeDamage(damageAmount);
            Die();
        }
    }
}
