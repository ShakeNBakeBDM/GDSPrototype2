using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishL : MonoBehaviour
{
    //position for the start position
    private Vector3 startPos;

    private void Awake()
    {
        //setting the startPos as the transform of the player when the game starts
        startPos = transform.position;
    }

    //collider that checks if the player hits the Finish line
    void OnTriggerEnter2D(Collider2D finishL)
    {
        if (finishL.tag == "Finish")

            //when player 1 collides with the finish line this adds +1 to player 1's score
            ScoreScript1.scoreValue += 1;

            //when player 1 collides with the finish line this resets their position to te start
            transform.position = startPos;
        
    }
}
