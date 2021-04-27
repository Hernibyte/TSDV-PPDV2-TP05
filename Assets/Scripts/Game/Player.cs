using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] float health = 100f;
    PlayerCanvasManager canvasManager;
    int points = 0;

    private void Start()
    {
        canvasManager = transform.GetComponent<PlayerCanvasManager>();
    }

    public int GetPoints()
    {
        return points;
    }

    public float GetHealth()
    {
        return health;
    }

    public void TakePoints(int amount)
    {
        points += amount;
        canvasManager.UpdatePoints();
    }

    public void TakeDamage(float amount)
    {
        health -= amount;
        if (health <= 0f)
        {
            Die();
        }
        canvasManager.UpdateHealth();
    }

    void Die()
    {
        Cursor.lockState = CursorLockMode.None;
        SceneController.FinalScene();
    }
}
