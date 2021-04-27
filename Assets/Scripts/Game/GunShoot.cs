using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunShoot : MonoBehaviour
{
    [SerializeField] Camera cam;
    [SerializeField] Player player;
    [SerializeField] GameObject initialRay;
    [SerializeField] float damageAmount;
    [SerializeField] float range = 100f;
    RaycastHit hit;
    Enemy enemy;

    void Update()
    {
        Debug.DrawRay(initialRay.transform.position, cam.transform.forward * range, Color.red);
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        if (Physics.Raycast(initialRay.transform.position, cam.transform.forward, out hit, range))
        {
            enemy = hit.transform.GetComponent<Enemy>();
            if (enemy != null)
            {
                enemy.TakeDamage(damageAmount, player);
            }
        }
    }
}
