using UnityEngine;
using System.Collections;

public class PlayerMoveMent : MonoBehaviour {

	public float speed = 5.0f;
	public float runspeed = 10.0f;

	void Update() {

		if (Input.GetMouseButton (0)) {
			GetComponent<Animator> ().SetTrigger ("hit");
		}

		{
			if (Input.GetKey (KeyCode.A)) {
				transform.position -= new Vector3 ((speed * Time.deltaTime), 0.0f, 0.0f);
				GetComponent<Animator> ().SetTrigger ("Walk");
				if (Input.GetKey (KeyCode.LeftShift)) {
					transform.position -= new Vector3 ((runspeed * Time.deltaTime), 0.0f, 0.0f);
					GetComponent<Animator> ().SetTrigger ("sprint");
				}
			}
			if (Input.GetKey (KeyCode.D)) {
				transform.position += new Vector3 ((speed * Time.deltaTime), 0.0f, 0.0f);
				GetComponent<Animator> ().SetTrigger ("Walk");
				if (Input.GetKey (KeyCode.LeftShift)) {
					transform.position += new Vector3 ((runspeed * Time.deltaTime), 0.0f, 0.0f);
					GetComponent<Animator> ().SetTrigger ("sprint");
				}
			}
			if (Input.GetKey (KeyCode.W)) {
				transform.position += new Vector3 (0.0f, (speed * Time.deltaTime), 0.0f);
				GetComponent<Animator> ().SetTrigger ("Walk");
				if (Input.GetKey (KeyCode.LeftShift)) {
					transform.position += new Vector3 (0.0f, (runspeed * Time.deltaTime), 0.0f);
					GetComponent<Animator> ().SetTrigger ("sprint");
				}
			}
			if (Input.GetKey (KeyCode.S)) {
				transform.position -= new Vector3 (0.0f, (speed * Time.deltaTime), 0.0f);
				GetComponent<Animator> ().SetTrigger ("Walk");
				if (Input.GetKey (KeyCode.LeftShift)) {
					transform.position -= new Vector3 (0.0f, (runspeed * Time.deltaTime), 0.0f);
					GetComponent<Animator> ().SetTrigger ("sprint");
				}
			}
		}
	}
			

	void FixedUpdate () {

			var mousePosition = Camera.main.ScreenToWorldPoint (Input.mousePosition);
			Quaternion rot = Quaternion.LookRotation (transform.position - mousePosition, Vector3.forward);
		{
			transform.rotation = rot;
			transform.eulerAngles = new Vector3 (0, 0, transform.eulerAngles.z);
			GetComponent<Rigidbody2D> ().angularVelocity = 0;
		}
	}
}