using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour {

    GameObject player;

	// Use this for initialization
	void Start () {
		player = GameObject.Find("Player");
    }
	
	// Update is called once per frame
	void Update () {
        if(Input.GetKey(KeyCode.A)) {
            player.transform.position= new Vector3(player.transform.position.x - 0.3f, player.transform.position.y, 0);
        }
		if(Input.GetKey(KeyCode.D))
        {
            player.transform.position = new Vector3(player.transform.position.x + 0.3f, player.transform.position.y, 0);

        }
    }
}
