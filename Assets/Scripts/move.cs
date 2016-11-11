using UnityEngine;
using System.Collections;

public class move : MonoBehaviour {

	public float speed = 5f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown (KeyCode.W)) {
			GetComponent<Rigidbody> ().AddForce (-Vector3.forward * speed);
		}
	
	}
}
