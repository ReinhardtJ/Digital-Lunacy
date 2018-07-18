using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraFollow : MonoBehaviour {
    GameObject player;
    GameObject camera;

	// Use this for initialization
	void Start () {
        player = GameObject.Find("Player");
        camera = GameObject.Find("Main Camera");
	}
	
	// Update is called once per frame
	void Update () {
        camera.transform.position= new Vector3(player.transform.position.x, 
            player.transform.position.y, camera.transform.position.z);

	}
}
