using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunShoot : MonoBehaviour
{
    [SerializeField] float wait;
    [SerializeField] Camera cam;
    [SerializeField] GameObject initialRay;
    RaycastHit hit;
    Target target;
    [SerializeField] float damageAmount;
    float range = 100f;

    void Start()
    {
        
    }

    void Update()
    {
        Debug.DrawRay(initialRay.transform.position, cam.transform.forward * range, Color.red);
        if (Input.GetButton("Fire1"))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        if (Physics.Raycast(initialRay.transform.position, cam.transform.forward, out hit, range))
        {
            target = hit.transform.GetComponent<Target>();
            if (target != null)
            {
                target.TakeDamage(damageAmount);
            }
        }
    }
}
