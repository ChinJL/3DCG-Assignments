using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour {

	Animator anim;

	void Start () {
		anim = GetComponent<Animator> ();
	}
	
	void OnTriggerEnter (Collider col)
	{
		if (col.tag == "Player")
		{
			anim.SetBool ("isOpenning", true);
		}
	}

	void OnTriggerExit(Collider col)
	{
		if (col.tag == "Player")
		{
			anim.SetBool ("isOpenning", false);
		}
	}

}
