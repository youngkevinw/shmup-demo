using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class BossMovement : MonoBehaviour
{
    public Transform[] Waypoints;
    public float Speed;
    public int curWaypoint;
    public bool Patrol = true;
    public Vector3 Target;
    public Vector3 MoveDirection;
    public Vector3 Velocity;
	private int BossHealth = 950;

	
	void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Bullet")
        {
			BossHealth -= 1;
            Destroy(col.gameObject);
			
			if (BossHealth <= 0)
			{
            Destroy(gameObject);
			}
        }
    }
	
    void Update()
    {

	
        if (curWaypoint < Waypoints.Length)
        {
            Target = Waypoints[curWaypoint].position;
            MoveDirection = Target - transform.position;
            Velocity = GetComponent<Rigidbody2D>().velocity * 1;
            if(MoveDirection.magnitude < 1)
            {
                curWaypoint ++;
            }
            else
            {
                Velocity = MoveDirection.normalized * Speed;
            }
        }
        else
        {
            if(Patrol)
            {
                curWaypoint=0;
            }
            else
            {
                Velocity = Vector3.zero;
            }
        }
        GetComponent<Rigidbody2D>().velocity = Velocity;
        {
            transform.Rotate (new Vector3 (0,0,0) * Time.deltaTime);
        }
    }
}
