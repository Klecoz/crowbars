using UnityEngine;
using System.Collections;

public class generateCrowBar : MonoBehaviour {

    public GameObject crowbar;

    public float spawnTime = 3f;

	private float spawny = 1.5f;

	// Use this for initialization
	void Start () {
        InvokeRepeating("spawnCrowbar", spawnTime, spawnTime);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void spawnCrowbar()
    {
        GameObject.Instantiate(crowbar, new Vector3(Random.Range(-2, 2), spawny, 8), Quaternion.identity);
    }
}
