using UnityEngine;
using System.Collections;

public class ShipControl : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		Vector2 ff = new Vector2(Input.GetAxis ("Horizontal"),0f);
		GetComponent<Rigidbody>().AddForceAtPosition(
			0.1f*(GetComponent<Transform>().rotation*ff),
		    GetComponent<Transform>().rotation*(new Vector2(0f,1f)),
		    ForceMode.Impulse);
		Debug.Log (ff);
	}
}
