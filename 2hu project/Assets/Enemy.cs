using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.position += new Vector3(0, -0.01f, 0);
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Bullet" || col.tag == "Player")
        {
            Destroy(col.gameObject);
            Destroy(gameObject);
        }
    }

}
