using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour {

	public int maxHealth = 100;
	public int curHealth = 100;
	//public Text FriendlyHealth;

	public Texture2D bgImage;
	public Texture2D fgImage;

	public float healthBarLength;

	// Use this for initialization
	void Start() {

		healthBarLength = Screen.width / 4;

	}
	
	// Update is called once per frame
	void Update () {

		if (curHealth == 0) {
			SceneManager.LoadScene ("dead_test", LoadSceneMode.Single);
		}

		//FriendlyHealth.text = "Your health: " + curHealth;

	}

	void OnGUI(){

		GUI.BeginGroup (new Rect (0, 0, healthBarLength, 32));

		GUI.Box (new Rect (0, 0, healthBarLength, 32), bgImage);

		GUI.BeginGroup (new Rect (0, 0, curHealth / maxHealth * healthBarLength, 32));

		GUI.Box (new Rect (0, 0, healthBarLength, 32), fgImage);

		GUI.EndGroup ();

		GUI.EndGroup ();

	}

	void OnTriggerEnter2D(Collider2D col) {

		if (col.gameObject.tag == "Enemy")
		{
			AdjustCurrentHealth (-10);
		}
		if (col.gameObject.tag == "Pickup") {
			AdjustCurrentHealth (+10);
		}
	}

	public void AdjustCurrentHealth(int adj){

		curHealth += adj;

		if (curHealth < 0)
			curHealth = 0;

		if (curHealth > maxHealth)
			curHealth = maxHealth;

		if (maxHealth < 1)
			maxHealth = 1;


		healthBarLength = (Screen.width / 4) * (curHealth / (float)maxHealth);

	}
}