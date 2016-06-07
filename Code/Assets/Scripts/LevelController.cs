using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LevelController : MonoBehaviour {

	private int correct;
	private int wrong;
	private int totalAttempts;

	private GameObject levelAlphabetObj;
	public string levelAlphabet="";

	private GameObject playerObj;
	private GameObject[] itemObjs;


	public AudioClip alphabetAudio;
	public AudioClip wrongAudio;
	public AudioClip[] correctAudio;

	private AudioSource audioo;

	public string dataUploadScreen;

	// Use this for initialization
	void Start () 
	{
		correct = 0;
		wrong = 0;
		levelAlphabetObj = GameObject.FindGameObjectWithTag ("Alphabet");
		levelAlphabet = levelAlphabetObj.name; 

		audioo = GetComponent<AudioSource>();

		playerObj = GameObject.FindGameObjectWithTag("Player");
		itemObjs = GameObject.FindGameObjectsWithTag ("Item");

		PlayAlphabetSound ();
	}

	public void Score(int arg)
	{
		if( arg == 1)
		{
			correct++;
			totalAttempts++;

			if (totalAttempts == 10)
			{
				LevelEnd ();
			}
			else
			{
				PlayCorrectSound ();
			}
		}
		else
		{
			wrong++;
			totalAttempts++;

			if (totalAttempts == 10)
			{
				LevelEnd ();
			}
			else
			{
				PlayWrongSound ();
			}

			/*if (wrong == 3)
			{
				Debug.Log ("correct: "+ correct);
				Debug.Log ("Wrong: "+ wrong );
				Destroy (playerObj);
				for(int i=0; i<itemObjs.Length; i++)
				{
					Destroy (itemObjs[i]);
				}

				Application.LoadLevel (gameOverScreen);
			}
			if(wrong!=3)
			{
				PlayWrongSound ();
			}*/
		}	
	}

	void PlayAlphabetSound(){
		if (!audioo.isPlaying) {
			audioo.clip = alphabetAudio;
			audioo.Play ();
		}
	}

	void PlayCorrectSound(){
		int clip = Random.Range (0, 2);
		if (!audioo.isPlaying) {
			audioo.clip = correctAudio [clip];
			audioo.Play ();
		}
	}

	void PlayWrongSound(){
		if (!audioo.isPlaying) {
			audioo.clip = wrongAudio;
			audioo.Play ();
		}
	}

	void LevelEnd()
	{
		Destroy (playerObj);
		for(int i=0; i<itemObjs.Length; i++)
		{
			Destroy (itemObjs[i]);
		}

		Globals.quizNo = levelAlphabet;
		Globals.attempts = totalAttempts;
		Globals.correct = correct;

		SceneManager.LoadScene (dataUploadScreen);
	}

		
}
