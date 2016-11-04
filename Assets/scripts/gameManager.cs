using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class gameManager : MonoBehaviour {

    public int health;
    Text healthtextref;
    public GameObject gameov;

	// Use this for initialization
	void Start () {
        healthtextref = GameObject.Find("healthtext").GetComponent<Text>();
    }
	
	// Update is called once per frame
	void Update () {
         if (health == 0)
        {
            gameov.SetActive(true);
        }

        }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "crowbar")
        {
            Debug.Log("I hit the health wall.");
            health--;
            Debug.Log("Health is now: " + health);
            healthtextref.text = "Health: " + health;
            Destroy(other.gameObject);


        }

    }
}
