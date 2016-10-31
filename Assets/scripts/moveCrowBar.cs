using UnityEngine;
using System.Collections;

public class moveCrowBar : MonoBehaviour {

    Vector3 movement = new Vector3 (0,0,-2);
	// Use this for initialization
	void Start () {
	   
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(movement * Time.deltaTime, Space.World);
        transform.Rotate(Vector3.right * 1, Space.Self);
	}
}
