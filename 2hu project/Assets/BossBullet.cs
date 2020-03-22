using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossBullet : MonoBehaviour
{
    // public GameObject BBullet;
    // public Transform BulletSpawn;
    // public float fireRate;
    // private float nextFire;

    // Update is called once per frame
    void Update()
    {
		gameObject.transform.position += new Vector3(0,-0.1f,0);
    }
}
