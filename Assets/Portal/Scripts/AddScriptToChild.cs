using UnityEngine;
using System.Collections;

public class AddScriptToChild : MonoBehaviour {

	// Use this for initialization
	void Start () {
		var childs = GetComponentsInChildren<Transform>();
		foreach (var go in childs)
		{
			if (go.name == gameObject.name)
				continue;
			go.gameObject.AddComponent<RandomMoves> ();
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
