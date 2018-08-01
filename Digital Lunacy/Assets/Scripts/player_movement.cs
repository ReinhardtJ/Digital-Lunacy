using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_movement : MonoBehaviour {

    public GameObject player;
    public float verticalMovementFactor;

	void Start () {
		
	}
	

	void Update () {
        Vector3 currentPos = player.transform.position;
        if (Input.GetKey("left")){
            player.transform.Translate(-verticalMovementFactor, 0, 0);
        } else if (Input.GetKey("right"))
        {
            player.transform.Translate(verticalMovementFactor, 0, 0);

        }

    }
}
