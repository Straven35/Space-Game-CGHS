using UnityEngine;
using System.Collections;

public class Dialogue : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void dialogue(bool clicked) {
		if (clicked == true) {
			GetComponent<Animator> ().Play ("anim_1");
			GetComponent<Animator> ().Play ("anim_1");
			GetComponent<Animator> ().Play ("anim_1");
			GetComponent<Animator> ().Play ("anim_1");
			if (clicked == true) {
				GetComponent<Animator> ().Play ("anim_2");
				GetComponent<Animator> ().Play ("anim_2");
				GetComponent<Animator> ().Play ("anim_2");
				GetComponent<Animator> ().Play ("anim_2");
			}
		}
	}
}
