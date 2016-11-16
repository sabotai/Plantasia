using UnityEngine;
using System.Collections;

public class move : MonoBehaviour {

	public bool auto = false;
	public float speed = 5f;
	public Vector3 direction;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown (KeyCode.W)) {
			GetComponent<Rigidbody> ().AddRelativeForce (direction * speed);
		}
		
		if (auto){
			GetComponent<Rigidbody> ().AddForce (direction * speed);
			auto = false;
		}
	}
}
