using UnityEngine;
using System.Collections;

public class MapSpeedYScale : MonoBehaviour {

	public Rigidbody speedGuide;
	private Vector3 defScale; 
	public float openThresh = 2f;

	public float openY = 1f;
	public float closeY = 0f;
	private bool open = true;


	// Use this for initialization
	void Start () {
		defScale = transform.localScale;
		openY *= defScale.y;
	
	}
	
	// Update is called once per frame
	void Update () {


		float veloScale = Mathf.Abs(speedGuide.velocity.z);//Mathf.Clamp( Mathf.Abs(speedGuide.velocity.z), -1f, 1f);
		if (veloScale > openThresh){ //if it is moving faster than ... 
			open = false; //close the eyes

		} else {
			open = true;
		}

		Vector3 newScale;
		if (open){
			newScale = new Vector3(defScale.x, openY, defScale.z);

		} else {
			newScale = new Vector3(0f, closeY, defScale.z);
		}

		Debug.Log("open= " + open);
		transform.localScale = Vector3.Lerp(transform.localScale, newScale, 0.1f);

/*
		Debug.Log("CURRENT AMT = " +  veloScale);
		Vector3 newScale = new Vector3(defScale.x, defScale.y - (veloScale * defScale.y), defScale.z);
		transform.localScale = newScale; 
		*/
	}
}
