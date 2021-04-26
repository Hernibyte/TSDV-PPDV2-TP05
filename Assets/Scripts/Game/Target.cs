using UnityEngine;

public class Target : MonoBehaviour
{
    float health = 100f;

    public void TakeDamage(float amount)
    {
        Debug.Log("I take damage");
        health -= amount;
        if (health <= 0f)
        {
            Die();
        }
    }

    void Die()
    {
        Destroy(gameObject);
    }
}
