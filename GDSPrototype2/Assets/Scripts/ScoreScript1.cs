using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;




public class ScoreScript1 : MonoBehaviour
{
    

    //this scripts sets up the score counter for player 1
    public static int scoreValue = 0;
    Text score;

    void Start()
    {
        score = GetComponent<Text>();
    }

    //this is updated from the FinishL script on the player which adds +1
    void Update()
    {
        score.text = "Score: " + scoreValue;

        if (scoreValue == 2)
        {
            Win();
        }
    }
    

    //restes trhe players scores and sends them back to the Menu
    public void Win()
    {
        scoreValue = 0;
        ScoreScript2.scoreValue = 0;
        Application.LoadLevel("Main Menu");
    }
}


