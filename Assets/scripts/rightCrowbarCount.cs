using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class rightCrowbarCount : MonoBehaviour {

    int rightcount;
    Text rightcountref;
	// Use this for initialization
	void Start () {
        rightcountref = GameObject.Find("rightcrowbar").GetComponent<Text>();
        rightcount = 0;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "crowbar")
        {
            rightcount++;
            Debug.Log("Count is now: " + rightcount);
            rightcountref.text = "Right Hand Crowbars Hit: " + rightcount;
        }

    }
}
