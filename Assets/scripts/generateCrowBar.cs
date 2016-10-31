using UnityEngine;
using System.Collections;

public class generateCrowBar : MonoBehaviour {

    public GameObject crowbar;

    public float spawnTime = 3f;
	// Use this for initialization
	void Start () {
        InvokeRepeating("spawnCrowbar", spawnTime, spawnTime);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void spawnCrowbar()
    {
        var newCrowbar = GameObject.Instantiate(crowbar, new Vector3(Random.Range(-2, 2), 2, 8), Quaternion.identity);
    }
}
