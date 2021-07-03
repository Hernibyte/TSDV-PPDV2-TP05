using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunsManager : MonoBehaviour
{
    [SerializeField] GameObject primaryGun;
    [SerializeField] GameObject secundaryGun;


    void Start()
    {
        primaryGun.SetActive(false);
        secundaryGun.SetActive(true);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            primaryGun.SetActive(true);
            secundaryGun.SetActive(false);
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            primaryGun.SetActive(false);
            secundaryGun.SetActive(true);
        }
    }
}
