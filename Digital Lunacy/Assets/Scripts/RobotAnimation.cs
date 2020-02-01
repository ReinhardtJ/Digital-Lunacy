using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotAnimation : MonoBehaviour {

    public Animator animator;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey("x"))
        {
            this.animator.SetTrigger("robotMinimize");

        }
        if (Input.GetKey("c"))
        {
            this.animator.SetTrigger("robotMaximize");
        }
        //this.animator.ResetTrigger("robotMinimize");
        //this.animator.ResetTrigger("robotMaximize");

    }

}
