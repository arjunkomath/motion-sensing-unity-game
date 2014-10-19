using UnityEngine;
using System.Collections;

public class player : MonoBehaviour {

	public float speed;
	public GUIText countText, winText;
	private int count;

	void Start() {
		count = 0;
		gameCount ();
		winText.text = "";
	}

	void FixedUpdate() {
		//float moveHorizontal = Input.GetAxis ("Horizontal");
		//float moveVertical = Input.GetAxis ("Vertical");

		float moveHorizontal = Input.acceleration.x;
		float moveVertical = Input.acceleration.y;

		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);

		rigidbody.AddForce (movement * speed * Time.deltaTime);
	}

	void OnTriggerEnter(Collider other) {
		if(other.gameObject.tag == "PickUp") {
			other.gameObject.SetActive (false);
			count++;
			gameCount();
		}
	}

	void gameCount() {
		countText.text = "Score : " + count.ToString ();
		if (count >= 4) {
			winText.text="You win!";
		}
	}
}
