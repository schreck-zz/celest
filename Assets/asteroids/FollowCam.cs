using UnityEngine;
using System.Collections;

public class FollowCam : MonoBehaviour {

	public Transform to_follow;

	private Camera cam;
	private Transform tx;
	private float target_size;
	private Vector3 target_position; // dampped ??

	// Use this for initialization
	void Start () {
		cam = GetComponent<Camera>();
		tx = GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void Update () {
		target_position = to_follow.position;
		target_position.z = -10; // dont think it matters
		target_size = 5+to_follow.GetComponent<Rigidbody>().velocity.magnitude;
		//tx.position = (target_position-tx.position)
	}
}
