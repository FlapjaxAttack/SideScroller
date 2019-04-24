using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed;
    public float jumpForce;
    
    private Rigidbody2D Playerrigidbody;

    void Start()
    {
        Playerrigidbody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        Playerrigidbody.velocity = new Vector2(moveSpeed, Playerrigidbody.velocity.y);
	
	if(Input.GetKeyDown(KeyCode.Space))
	{
	     Playerrigidbody.velocity = new Vector2(Playerrigidbody.velocity.x, jumpForce);
	}
    }
}
