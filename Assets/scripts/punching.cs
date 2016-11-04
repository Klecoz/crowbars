using UnityEngine;
using System.Collections;

public class punching : MonoBehaviour {

	public Animator leftPunch;
	public Animator rightPunch;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonUp (0)) {
			leftPunch.SetTrigger ("leftClickPunch");
	}
		if (Input.GetMouseButtonUp (1)) {
			rightPunch.SetTrigger ("rightClickPunch");
		}
}

}
