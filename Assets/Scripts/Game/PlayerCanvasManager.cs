using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerCanvasManager : MonoBehaviour
{
    Player player;
    [SerializeField] Text points;
    [SerializeField] Text health;

    private void Start()
    {
        player = transform.GetComponent<Player>();
        UpdatePoints();
        UpdateHealth();
    }

    public void UpdatePoints()
    {
        points.text = "Points:" + player.GetPoints();
    }

    public void UpdateHealth()
    {
        health.text = "Health: " + player.GetHealth();
    }
}
