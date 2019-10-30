using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishL : MonoBehaviour
{

    private Vector3 startPos;

    private void Awake()
    {
        //setting the startPos as the transform of the player when the game starts
        startPos = transform.position;
    }
    void OnTriggerEnter2D(Collider2D finishL)
    {
        
        if (finishL.tag == "Finish")
        transform.position = startPos;
        Debug.Log("Finish");
    }
}
