using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate : MonoBehaviour {

	private float vel = 40;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () 

	{
		transform.Rotate (Vector3.right * Time.deltaTime * vel);
	}
}
