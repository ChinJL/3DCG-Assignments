using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour {

//	Vector2 mouseLook;
//	Vector2 smoothVelocity;
//	public float sensitivity = 5f;
//	public float smoothing = 2f;
//
//	GameObject character;
//
//	void Start()
//	{
//		character = this.transform.parent.gameObject;
//	}
//
//	void Update()
//	{
//		var md = new Vector2 (Input.GetAxisRaw ("Mouse X"), Input.GetAxisRaw ("Mouse Y"));
//
//		md = Vector2.Scale (md, new Vector2 (sensitivity * smoothing, sensitivity * smoothing));
//		smoothVelocity.x = Mathf.Lerp (smoothVelocity.x, md.x, 1f / smoothing);
//		smoothVelocity.y = Mathf.Lerp (smoothVelocity.y, md.y, 1f / smoothing);
//		mouseLook += smoothVelocity;

//		transform.localPosition = Quaternion.AngleAxis (-mouseLook.y, Vector3.right);
//		character.transform.localPosition = Quaternion.AngleAxis (mouseLook.x, character.transform.up);
//	}

	//-------------------------------------------------------------------------------------------------
//	public Transform target;
//	public float lookSmooth = 0.09f;
//	public Vector3 offSetFromTarget = new Vector3 (0, 6, -8);
//	public float xTilt = 10;
//
//	Vector3 destination = Vector3.zero;
//	CharacterControl charControl;
//	float rotateVelocity = 0;
//
//	void Start()
//	{
//		SetCameraTarget (target);
//	}
//
//	void SetCameraTarget( Transform t)
//	{
//		target = t;
//
//		charControl = target.GetComponent<CharacterControl> ();
//	}
//
//	void LateUpdate()
//	{
//		//Moving
//		MoveToTarget();
//		//Rotating 
//		LookAtTarget();
//	}
//
//	void MoveToTarget()
//	{
//		destination = charControl.TargetRotation * offSetFromTarget;
//		destination += target.position;
//		transform.position = destination;
//	}
//
//	void LookAtTarget()
//	{
//		float eulerYAngle = Mathf.SmoothDampAngle (transform.eulerAngles.y, target.eulerAngles.y, ref rotateVelocity, lookSmooth);
//		transform.rotation = Quaternion.Euler (transform.eulerAngles.x, eulerYAngle, 0);
//	}
}
