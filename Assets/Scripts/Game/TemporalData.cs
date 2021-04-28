using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TemporalData : MonoBehaviour
{
    private static TemporalData instance;
    public static int Score { set; get; }

    private void Awake()
    {
        if (instance != null)
        {
            Destroy(gameObject);
            return;
        }
        instance = this;
        DontDestroyOnLoad(instance);
    }
}
