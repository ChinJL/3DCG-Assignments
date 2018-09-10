using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterControl : MonoBehaviour {

	public float inputDelay = 0.1f;
	public float forwardVelocity = 12;
	public float rotateVelocity = 100;

	Quaternion targetRotation;
	Rigidbody rBody;
	float forwardInput, turnInput;

	public Quaternion TargetRotation
	{
		get { return targetRotation; }
	}

	void Start()
	{
		targetRotation = transform.rotation;
		rBody = GetComponent<Rigidbody> ();

		forwardInput = turnInput = 0;
	}

	void GetInput()
	{
		forwardInput = Input.GetAxis ("Vertical");
		turnInput = Input.GetAxis ("Horizontal");
	}

	void Update()
	{
		GetInput ();
		Turn ();
	}

	void FixedUpdate()
	{
		Run ();
	}

	void Run()
	{
		if (Mathf.Abs (forwardInput) > inputDelay)
		{
			// Move
			rBody.velocity = transform.forward * forwardInput * forwardVelocity;
		}
		else
		{
			//Zero Velocity
			rBody.velocity = Vector3.zero;
		}
	}

	void Turn()
	{
		if (Mathf.Abs (turnInput) > inputDelay)
		{
			targetRotation *= Quaternion.AngleAxis (rotateVelocity * turnInput * Time.deltaTime, Vector3.up);
		}
		transform.rotation = targetRotation;
	}
}
