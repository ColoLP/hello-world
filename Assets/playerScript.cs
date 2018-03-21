using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerScript : MonoBehaviour {

    public Animator anim;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown("d"))
        {
            anim.SetBool("runPlayer", true);

        }else if (Input.GetKeyDown("a"))
        {
            anim.SetBool("runPlayer", false);
        }

    }
}
