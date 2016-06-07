using UnityEngine;
using System.Collections;

public class ItemActivator : MonoBehaviour {

	//public GameObject theItem;
	public Transform activationPoint;
	public float distanceBetween;

	//private float itemWidth;

	//public GameObject[] theItems;
	private int itemSelector;

	public ObjectPooler[] theObjectPools;


	// Use this for initialization
	void Start () {
		//itemWidth = theItem.GetComponent<BoxCollider2D> ().size.x;

	}
	
	// Update is called once per frame
	void Update () {
	
		if (transform.position.x < activationPoint.position.x) 
		{
			transform.position = new Vector3 (transform.position.x + distanceBetween, transform.position.y, transform.position.z);

			itemSelector = Random.Range (0, theObjectPools.Length);

			//Instantiate(/*theItem*/ theItems[itemSelector], transform.position, transform.rotation);

			GameObject newItem = theObjectPools[itemSelector].GetPooledObject();

			newItem.transform.position = transform.position;
			newItem.transform.rotation = transform.rotation;
			newItem.SetActive (true);

		}

	}
}
