using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public AudioSource playerdeath;

    public int[] collision = {0,0,0,0}; //LRTB

    public Sprite player_original;
    public Sprite player_hitbox;

    public GameObject Bullet;



    // Start is called before the first frame update
    void Start()
    {
    }

	void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "BossBullet")
        {
            Destroy(col.gameObject);			
            Destroy(gameObject);
            playerdeath = GetComponent<AudioSource>();
            playerdeath.Play();

        }
		if (col.tag == "Enemy")
        {
            Destroy(gameObject);
        }
        if (col.tag == "LeftBorder")
        {
            collision [0] = 1;
        }
        if (col.tag == "RightBorder")
        {
            collision [1] = 1;
        }

        if (col.tag == "TopBorder")
        {
            collision [2] = 1;
        }

        if (col.tag == "BottomBorder")
        {
            collision [3] = 1;
        }

    }
    void OnTriggerExit2D(Collider2D col)
    {
        if (col.tag == "LeftBorder")
        {
            collision [0] = 0;
        }
        if (col.tag == "RightBorder")
        {
            collision [1] = 0;
        }

        if (col.tag == "TopBorder")
        {
            collision [2] = 0;
        }

        if (col.tag == "BottomBorder")
        {
            collision [3] = 0;
        }

    }
	
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift) || Input.GetKeyDown(KeyCode.RightShift) )
        {
            gameObject.GetComponent<SpriteRenderer> ().sprite = player_hitbox;
        }
        if (Input.GetKeyUp(KeyCode.LeftShift) || Input.GetKeyDown(KeyCode.RightShift) )
        {
            gameObject.GetComponent<SpriteRenderer> ().sprite = player_original;
        }

        if(collision[1]!=1 && Input.GetKey(KeyCode.LeftShift) && Input.GetKey(KeyCode.RightArrow))
        {
            gameObject.transform.position += new Vector3(0.05f, 0, 0);
            
        }
        else if (collision[1]!=1 && Input.GetKey(KeyCode.RightArrow))
        {
            gameObject.transform.position += new Vector3(0.1f, 0, 0);
        }
        if (collision[0]!=1 && Input.GetKey(KeyCode.LeftShift) && Input.GetKey(KeyCode.LeftArrow))
        {
            gameObject.transform.position += new Vector3(-0.05f, 0, 0);
        }
        else if (collision[0]!=1 && Input.GetKey(KeyCode.LeftArrow))
        {
            gameObject.transform.position += new Vector3(-0.1f, 0, 0);
        }
        if(collision[2]!=1 && Input.GetKey(KeyCode.LeftShift) && Input.GetKey(KeyCode.UpArrow))
        {
            gameObject.transform.position += new Vector3(0, 0.05f, 0);
        }
        else if (collision[2]!=1 && Input.GetKey(KeyCode.UpArrow))
        {
            gameObject.transform.position += new Vector3(0, 0.1f, 0);
        }
        if(collision[3]!=1 && Input.GetKey(KeyCode.LeftShift) && Input.GetKey(KeyCode.DownArrow))
        {
            gameObject.transform.position += new Vector3(0, -0.05f, 0);            
        }
        else if (collision[3]!=1 && Input.GetKey(KeyCode.DownArrow))
        {
            gameObject.transform.position += new Vector3(0, -0.1f, 0);
        }
        if (Input.GetKey(KeyCode.Z))
        {
            Vector3 pos = gameObject.transform.position + new Vector3(0, 0.3f, 0);
            Instantiate(Bullet, pos, gameObject.transform.rotation);
        }

    }
}
