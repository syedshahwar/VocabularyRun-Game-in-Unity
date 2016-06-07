using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

	public PlayerController thePlayer;

	private Vector3 lastPlayerPosition;
	private float distanceToMove;


	// Use this for initialization
	void Start () {

		thePlayer = FindObjectOfType<PlayerController> ();
		lastPlayerPosition = thePlayer.transform.position;

	}
	
	// Update is called once per frame
	void Update () {

		if(thePlayer!=null)
		{
			
			distanceToMove = thePlayer.transform.position.x - lastPlayerPosition.x;

		//transforming the position of camera
			transform.position = new Vector3(transform.position.x + distanceToMove, transform.position.y, transform.position.z);

			lastPlayerPosition = thePlayer.transform.position;

		}
	}
}
