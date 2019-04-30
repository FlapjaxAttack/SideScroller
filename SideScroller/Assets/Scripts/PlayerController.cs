using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed;
    public float jumpForce;
    
    private Rigidbody2D Playerrigidbody;


    public bool grounded;
    public LayerMask groundIdentifier;

    private Collider2D playerCollider;

    private Animator playerAnimator;

    public GameManagement theGameBoss;

    void Start()
    {
        Playerrigidbody = GetComponent<Rigidbody2D>();

        playerCollider = GetComponent<Collider2D>();

        playerAnimator = GetComponent<Animator>();
    }

    void Update()
    {
	    grounded = Physics2D.IsTouchingLayers(playerCollider, groundIdentifier);
        
	    Playerrigidbody.velocity = new Vector2(moveSpeed, Playerrigidbody.velocity.y);
	
	if(Input.GetKeyDown(KeyCode.Space))
	{
		if(grounded)
		{
			Playerrigidbody.velocity = new Vector2(Playerrigidbody.velocity.x, jumpForce);
		}
	}
	
	playerAnimator.SetFloat("Speed", Playerrigidbody.velocity.x);
	playerAnimator.SetBool("Grounded", grounded);
    }
}
