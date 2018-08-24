using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lift : MonoBehaviour {

	private bool isEvevatorUp = false;
	private Animator anim;

	public void Start()
	{
		anim = GetComponent<Animator> ();
	}

	public void Update()
	{
		if (!isEvevatorUp)
		{
			anim.SetBool ("isRunningUp", true);
			isEvevatorUp = true;
		} 
//		else
//		{
//			anim.SetBool ("isRunningUp", false);
//			isEvevatorUp = false;
//		}
	}
}
