using UnityEngine;
using System.Collections;

public class connectLines : MonoBehaviour {

	public Transform[] points;
	[SerializeField] private  Vector3[] positions;

	// Use this for initialization
	void Start () {
		positions = new Vector3[points.Length];
		GetComponent<LineRenderer> ().SetVertexCount (points.Length);
	
	}
	
	// Update is called once per frame
	void Update () {

		for (int i = 0; i < points.Length; i++) {
			positions [i] = points [i].position;

		}

		GetComponent<LineRenderer>().SetPositions(positions);
	
	}
}
