using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour {

	public Transform target;
	public float lookSmooth = 0.09f;
	public Vector3 offSetFromTarget = new Vector3 (0, 6, -8);
	public float xTilt = 10;

	Vector3 destination = Vector3.zero;
	CharacterControl charControl;
	float rotateVelocity = 0;

	void Start()
	{
		SetCameraTarget (target);
	}

	void SetCameraTarget( Transform t)
	{
		target = t;

		charControl = target.GetComponent<CharacterControl> ();
	}

	void LateUpdate()
	{
		//Moving
		MoveToTarget();
		//Rotating 
		LookAtTarget();
	}

	void MoveToTarget()
	{
		destination = charControl.TargetRotation * offSetFromTarget;
		destination += target.position;
		transform.position = destination;
	}

	void LookAtTarget()
	{
		float eulerYAngle = Mathf.SmoothDampAngle (transform.eulerAngles.y, target.eulerAngles.y, ref rotateVelocity, lookSmooth);
		transform.rotation = Quaternion.Euler (transform.eulerAngles.x, eulerYAngle, 0);
	}
}
