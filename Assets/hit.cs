using UnityEngine;
using System.Collections;

public class hit : MonoBehaviour {
	public GameObject explosion;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

	}

	private void OnCollisionEnter(Collision other)
	{
		if (other.gameObject.tag == "fist" )
		{
			Debug.Log ("I hit a fist");

			Instantiate(explosion, transform.position, transform.rotation);
			Destroy(this.gameObject);



		}
	}
}
