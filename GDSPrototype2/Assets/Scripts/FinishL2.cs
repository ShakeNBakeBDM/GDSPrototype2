using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishL2 : MonoBehaviour
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

            //when player 2 collides with the finish line this adds +1 to player 2's score
            ScoreScript2.scoreValue += 1;

            //when player 2 collides with the finish line this resets their position to te start
            transform.position = startPos;
        
    }
}
