using UnityEngine;
using System.Collections;

public class ItemDeactivator : MonoBehaviour {

	public GameObject itemDeactivatePoint;

	// Use this for initialization
	void Start () {
		itemDeactivatePoint = GameObject.Find ("ItemDeactivatePoint");
	}

	// Update is called once per frame
	void Update () {

		if (transform.position.x < itemDeactivatePoint.transform.position.x)
		{
			//Destroy (gameObject);
			gameObject.SetActive(false);
		}
	}
}
