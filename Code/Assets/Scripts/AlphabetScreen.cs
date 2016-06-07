using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class AlphabetScreen : MonoBehaviour {

	public string[] level;
	public string mainMenu;

	public void StartLevel(int arg)
	{
		SceneManager.LoadScene (level[arg]);
	}

	public void MainMenu()
	{
		SceneManager.LoadScene (mainMenu);
	}
}
