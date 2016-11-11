using UnityEngine;
using System.Collections;

public class Sun : MonoBehaviour {

	public float speedMult = 1f;
	private Vector3 defaultRot;
	public bool setDefRot = false;
	public GameObject sunObj;

	// Use this for initialization
	void Start () {
		defaultRot = new Vector3 (-23, -99, -48);
		if (setDefRot)
			transform.rotation = Quaternion.Euler (defaultRot);

	}
	
	// Update is called once per frame
	void Update () {
	
		transform.Rotate (0, 0, Time.deltaTime * speedMult, Space.World);
		//transform.LookAt(sunObj.transform);
	}
}
