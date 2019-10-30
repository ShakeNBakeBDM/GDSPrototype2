using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    //the players start position stored as a V3
    private Vector3 startPos;

    private void Awake()
    {
        //setting the startPos as the transform of the player when the game starts
        startPos = transform.position;
    }

    void OnTriggerEnter2D(Collider2D colliderI)
    {
        //if the players collider hits objects with the tag Obstacle
        //it will then send the player back to the startPos
        if (colliderI.tag == "Obstacle")
            transform.position = startPos;   
            Debug.Log("Reset");
    }
    
}
