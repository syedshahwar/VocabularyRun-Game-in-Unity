using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UploadData : MonoBehaviour {

	public InputField studentIDInputField;
	public string gameOverScreen;

	// Use this for initialization
	public void Upload() {
		string url = "http://localhost/UploadDataScript.php";

		WWWForm form = new WWWForm();

		form.AddField("studentID", studentIDInputField.text);
		form.AddField("quizNo", Globals.quizNo);
		form.AddField("attempts", Globals.attempts);
		form.AddField("correct", Globals.correct);
		WWW www = new WWW(url, form);

		StartCoroutine(WaitForRequest(www));
	}

	IEnumerator WaitForRequest(WWW www)
	{
		yield return www;

		// check for errors
		if (www.error == null)
		{
			Debug.Log("WWW Ok!: " + www.text);
			SceneManager.LoadScene (gameOverScreen);
		}
		else
		{
			Debug.Log("WWW Error: " + www.error);
			SceneManager.LoadScene (gameOverScreen);
		}
	}

}