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
        anim.SetBool("isRunningUp", isEvevatorUp);
	}

	void OnTriggerEnter(Collider col)
	{
		if (col.tag == "Player")
		{
			isEvevatorUp = !isEvevatorUp;
		}
	}
}
