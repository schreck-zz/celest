using UnityEngine;
using System.Collections;

public class AsteroidField : MonoBehaviour {

	public Transform asteroid_prefab;
	public Transform cam; // main camera

	// Use this for initialization
	void Start () {
		int i;
		int j;
		Transform astro;
		float astro_size;
		for(i=0;i<20;i++){
			for(j=0;j<20;j++){
				astro = GameObject.Instantiate(asteroid_prefab,30*new Vector3(i,j,0),Random.rotation) as Transform;
				astro.parent = GetComponent<Transform>();
				astro_size = 10*Random.value;
				astro.localScale = new Vector3(astro_size,astro_size,astro_size);
				astro.GetComponent<Rigidbody>().mass = astro_size;
			}
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
