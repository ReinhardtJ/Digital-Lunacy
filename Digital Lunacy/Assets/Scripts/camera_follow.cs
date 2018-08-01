using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera_follow : MonoBehaviour {
    public GameObject player;
    public GameObject camera;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
        camera.transform.position= new Vector3(player.transform.position.x, 
            player.transform.position.y, camera.transform.position.z);

	}
}
