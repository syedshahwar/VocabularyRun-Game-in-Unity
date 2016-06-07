using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

	public string alphabetScreen;

	public void PlayGame()
	{
		SceneManager.LoadScene (alphabetScreen);
	}

	public void QuitGame()
	{
		Application.Quit ();
	}
}
