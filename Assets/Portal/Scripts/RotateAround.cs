using UnityEngine;
using System.Collections;

[ExecuteInEditMode]
public class RotateAround : MonoBehaviour
{

  public float Speed = 1;
  
  private Transform t;
	// Use this for initialization
	void Start ()
	{
	  t = transform;
	}

  	private void Update()
	{
		transform.Rotate (Vector3.forward * Time.deltaTime * Speed);
	}
}
