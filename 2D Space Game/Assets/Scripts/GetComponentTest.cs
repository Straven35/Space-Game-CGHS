using UnityEngine;
using System.Collections;

public class GetComponentTest : MonoBehaviour {

	public Renderer rend;

	void OnTriggerEnter2D(Collider2D col) {
		if (col.gameObject.tag == "Player") {
			rend = GetComponent<Renderer> ();
			rend.enabled = false;
		}
			
	}
	void OnTriggerExit2D(Collider2D col) {
		if (col.gameObject.tag == "Player") {
			rend = GetComponent<Renderer> ();
			rend.enabled = true;
		}
	}
}
