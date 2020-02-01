using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    // the player object this script is attached to 
    public GameObject player;
    // as far the player can move per frame
    public float verticalMovementFactor;
    // as much force the player recieves with each jump
    public float jumpFactor;
    //as many seconds have to pass until the player can jump again
    public int maxJumpThreshold;

    // counter variable from maxJumpThreshold to 0
    private int jumpThreshold;

	void Start () {
        jumpThreshold = 0;

    }

    private void Update()
    {
        
    }


    void FixedUpdate () {

        Vector3 currentPos = player.transform.position;
        if (Input.GetAxisRaw("Horizontal") < 0)
        {
            moveLeft();
        } else if (Input.GetAxisRaw("Horizontal") > 0)
        {
            moveRight();
        } else { // when the player doesn't move left or right 
        }

        if((Input.GetKey("up") || Input.GetKey("w")) && jumpThreshold == 0)
        {
            if (player.GetComponent<PolygonCollider2D>().IsTouchingLayers())
            {
                jump();
                jumpThreshold = maxJumpThreshold;
            }
        }
        jumpThreshold = jumpThreshold == 0 ? 0 : jumpThreshold - 1; 
    }

    private void jump()
    {
        player.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, jumpFactor));
    }

    private void moveLeft()
    {
        player.transform.Translate(-verticalMovementFactor, 0, 0);
    }

    private void moveRight()
    {
        player.transform.Translate(verticalMovementFactor, 0, 0);

    }
}
