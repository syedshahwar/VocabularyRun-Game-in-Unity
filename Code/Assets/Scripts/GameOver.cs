using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour {

	public string mainMenu;

	public void MainMenu()
	{
		SceneManager.LoadScene (mainMenu);
	}
		
}
