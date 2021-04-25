using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunShoot : MonoBehaviour
{
    [SerializeField] float wait;
    [SerializeField] Camera cam;
    RaycastHit HitInfo;
    float localTimer;

    void Start()
    {
        localTimer = wait;
    }

    void Update()
    {
        if (Physics.Raycast(cam.transform.position, cam.transform.forward, out HitInfo, 100.0f))
        {
            Debug.DrawRay(cam.transform.position, cam.transform.forward * 100.0f, Color.yellow);
            if (Input.GetKey(KeyCode.Mouse0))
            {
                localTimer += Time.deltaTime;
                if (localTimer >= wait)
                {
                    localTimer = 0;
                    Debug.Log(HitInfo);
                }
            }
            else if (Input.GetKeyUp(KeyCode.Mouse0))
                localTimer = wait;
        }
    }
}
