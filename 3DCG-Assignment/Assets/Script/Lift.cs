using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lift : MonoBehaviour {

	public bool isEvevatorUp = false;
	private Animator anim;

    public void Start() {
        anim = GetComponent<Animator>();
    }

	public void Update()
	{
		if (isEvevatorUp)
		{
			anim.SetBool ("isRunningUp", true);
		} 
		else
		{
			anim.SetBool ("isRunningUp", false);
		}
	}

	void OnTriggerEnter(Collider col)
	{
		if (col.tag == "Player")
		{
			isEvevatorUp = !isEvevatorUp;
		}
	}
}
