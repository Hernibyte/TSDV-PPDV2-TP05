using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class finalScreenCanvas : MonoBehaviour
{
    [SerializeField] Text Score;
    
    void Start()
    {
        Score.text = "YOU SCORE: " + TemporalData.Score;
    }

}
