using UnityEngine;
using System.Collections;

public class FollowCam : MonoBehaviour {

	public Transform to_follow;
	public float jerk_mag = 1f; // magnitude of jerk (m/sss)

	private Camera cam;
	private Transform tx;
	private float target_size;
	private Vector3 target_pos; 
	private Vector3 target_vel; 

	// motion state
	private Vector3 vel; // velocity (m/s)
	private Vector3 acc; // acceleration (m/ss)

	// Use this for initialization
	void Start () {
		cam = GetComponent<Camera>();
		tx = GetComponent<Transform>();
		vel = Vector3.zero;
		acc = Vector3.zero;
	}
	
	// Update is called once per frame
	void Update () {
		target_pos = to_follow.position;
		target_pos.z = -10; // dont think it matters
		//target_vel = to_follow.GetComponent<Rigidbody>().velocity;
 		// punt on the cam intercept stuff
		tx.position = target_pos;
		target_size = 10+to_follow.GetComponent<Rigidbody>().velocity.magnitude;
		cam.orthographicSize+=(target_size-cam.orthographicSize)/2;

	}
}
