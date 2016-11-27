using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {
	public Transform mainMenu;

	public void StartGame (string name) {

		SceneManager.LoadScene (name, LoadSceneMode.Single);
	
	}
	public void QuitGame () {

		Application.Quit();
	
	}
	//public void OptionsMenu(bool clicked) {
		//if (clicked == true) {
		//	optionsMenu.gameObject.SetActive (clicked);
		//	mainMenu.gameObject.SetActive (false);
	//	} else {
		//	optionsMenu.gameObject.SetActive (clicked);
	//		mainMenu.gameObject.SetActive (true);
	//	}
//	}
}
