using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class leftCrowbarCount : MonoBehaviour {

    int leftcount;
    Text leftcountref;
    // Use this for initialization
    void Start () {
        leftcountref = GameObject.Find("leftcrowbar").GetComponent<Text>();
        leftcount = 0;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "crowbar")
        {
            leftcount++;
            Debug.Log("Count is now: " + leftcount);
            leftcountref.text = "Left Hand Crowbars Hit: " + leftcount;
        }

    }
}
