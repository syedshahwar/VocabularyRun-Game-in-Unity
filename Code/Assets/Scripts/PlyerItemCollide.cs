using UnityEngine;
using System.Collections;

public class PlyerItemCollide : MonoBehaviour {

	private string itemName="";
	private LevelController levelControllerObj;
	private string alphabet="";
	private string firstAlphabet="";
	// Use this for initialization
	void Start () {
		levelControllerObj = GameObject.Find ("LevelController").GetComponent<LevelController> ();
		alphabet =  levelControllerObj.levelAlphabet;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.name == "Player") 
		{
			gameObject.SetActive(false);
			itemName = gameObject.name;
			firstAlphabet = itemName.Substring (0, 1);
			if(firstAlphabet==alphabet)
			{
				levelControllerObj.Score (1);
			}
			else
			{
				levelControllerObj.Score (0);
			}
		}

	}
}
