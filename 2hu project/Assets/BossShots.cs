using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossShots: MonoBehaviour
{
    public GameObject BossBullet;
    public Transform BulletSpawn;
    public float fireRate;
    private float nextFire;

    // Update is called once per frame
    void Update()
    {
        if (Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            Instantiate(BossBullet, BulletSpawn.position, BulletSpawn.rotation);
			// Instantiate(BossBullet, gameObject.transform.rotation);
        }
    }
}
