using UnityEngine;
using System.Collections;

public class rotater : MonoBehaviour {
	
	// Update is called once per frame
	void Update () {
		transform.Rotate (new Vector3(15,30,25) * Time.deltaTime);
	}
}
