using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public float moveSpeed;
	public float jumpForce;

	private Rigidbody2D playerRb;

	public bool grounded;
	//public LayerMask whatIsGround;
	//private Collider2D playerCollider;
	private Animator playerAnim;


	// Use this for initialization
	void Start () {

		playerRb = GetComponent<Rigidbody2D> ();
		//playerCollider = GetComponent<Collider2D> ();
		playerAnim = GetComponent<Animator> ();

	}
	
	// Update is called once per frame
	void Update () {

		//grounded = Physics2D.IsTouchingLayers (playerCollider, whatIsGround);
		//Debug.Log (grounded);

		playerRb.velocity = new Vector2 (moveSpeed, playerRb.velocity.y);

		//player jumping
		if(Input.touchCount > 0 || Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
		{
			if (grounded) 
			{
				playerRb.velocity = new Vector2 (playerRb.velocity.x, jumpForce);
			}
		}

		playerAnim.SetFloat ("Speed", playerRb.velocity.x);
		playerAnim.SetBool ("Grounded", grounded);
			
	}


	void OnCollisionEnter2D(Collision2D other) {
		if(other.gameObject.name == "Ground")
		{
			//Debug.Log ("Enter");
			grounded = true;
		}
	}
		

	void OnCollisionExit2D()
	{
		grounded = false;

	}

}
