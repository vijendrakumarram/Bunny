using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour {

	public float speed=5f;

	private Transform cactusTransform;
	// Use this for initialization
	void Start ()
	{
		cactusTransform = transform;	
	}
	
	// Update is called once per frame
	void Update () 
	{
		cactusTransform.position+= Vector3.left * speed * Time.deltaTime;
	}




}
