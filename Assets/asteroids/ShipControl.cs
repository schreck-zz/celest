using UnityEngine;
using System.Collections;

public class ShipControl : MonoBehaviour {

	public float translate_power = 100f; // max translate force (N)
	public float mass = 1000f; // mass (kg)
	public float rudder_power = 10f; // max rudder force (N)

	// short hand for this things components
	private Rigidbody rb; // this rigidbody
	private Transform tx; // ....

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody>();
		tx = GetComponent<Transform>();
		rb.mass = mass;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		// Translation
		Vector2 translate = new Vector2(Input.GetAxis ("Horizontal"),Input.GetAxis ("Vertical"));
		rb.AddForce(
			translate_power*(tx.rotation*translate),
		    ForceMode.Impulse);
		// Rotation
		Vector2 bow = tx.position+tx.rotation*new Vector2(0f,1f); // bow of the ship
		Vector2 stern = tx.position+tx.rotation*new Vector2(0f,-1f); // stern of the ship
		Vector2 rudder = rudder_power*(tx.rotation*new Vector2(Input.GetAxis ("Rudder")/2,0f)); // rudder input
		Vector2 rev_rudder = rudder_power*(tx.rotation*new Vector2(-Input.GetAxis ("Rudder")/2,0f)); // rudder input
		rb.AddForceAtPosition(rudder,bow,ForceMode.Impulse);		                        
		rb.AddForceAtPosition(rev_rudder,stern,ForceMode.Impulse);		                        
	}

	void Update(){
		// show engine output?
	}
}
