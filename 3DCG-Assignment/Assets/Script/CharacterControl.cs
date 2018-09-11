﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterControl : MonoBehaviour {

	public float speed = 10f;

	void Start()
	{
		Cursor.lockState = CursorLockMode.Locked;
	}

	void Update()
	{
		float translation = Input.GetAxis ("Vertical") * speed;
		float straffe = Input.GetAxis ("Horizontal") * speed;
		translation *= Time.deltaTime;
		straffe *= Time.deltaTime;

		transform.Translate (straffe, 0, translation);

		if (Input.GetKeyDown ("escape"))
		{
			Cursor.lockState = CursorLockMode.None;
		}

		Touch ();
	}

	void Touch()
	{
		Ray ray = new Ray (transform.position + new Vector3(50,0), transform.forward);
		Debug.DrawRay (ray.origin, ray.direction, Color.blue);
	}

	//-----------------------------------------------------------------------------------------------------------
//	public float inputDelay = 0.1f;
//	public float forwardVelocity = 12;
//	public float rotateVelocity = 100;
//
//	Quaternion targetRotation;
//	Rigidbody rBody;
//	float forwardInput, turnInput;
//
//	public Quaternion TargetRotation
//	{
//		get { return targetRotation; }
//	}
//
//	void Start()
//	{
//		targetRotation = transform.rotation;
//		rBody = GetComponent<Rigidbody> ();
//
//		forwardInput = turnInput = 0;
//	}
//
//	void GetInput()
//	{
//		forwardInput = Input.GetAxis ("Vertical");
//		turnInput = Input.GetAxis ("Horizontal");
//	}
//
//	void Update()
//	{
//		GetInput ();
//		Turn ();
//	}
//
//	void FixedUpdate()
//	{
//		Run ();
//	}
//
//	void Run()
//	{
//		if (Mathf.Abs (forwardInput) > inputDelay)
//		{
//			// Move
//			rBody.velocity = transform.forward * forwardInput * forwardVelocity;
//		}
//		else
//		{
//			//Zero Velocity
//			rBody.velocity = Vector3.zero;
//		}
//	}
//
//	void Turn()
//	{
//		if (Mathf.Abs (turnInput) > inputDelay)
//		{
//			targetRotation *= Quaternion.AngleAxis (rotateVelocity * turnInput * Time.deltaTime, Vector3.up);
//		}
//		transform.rotation = targetRotation;
//	}
}
