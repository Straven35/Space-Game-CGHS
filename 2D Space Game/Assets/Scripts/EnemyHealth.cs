using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class EnemyHealth : MonoBehaviour {

	public float maxHealth = 100;
	public float curHealth = 100;
	//public Text Health;

	void Update () {
		if (curHealth == 0) {
			Destroy (gameObject);
		}

		//Health.text = "Health: " + curHealth;

	}

	void OnTriggerEnter2D(Collider2D col) {

		if (col.gameObject.tag == "Hit") {
			AdjustCurrentHealth (-10);
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
	}
}