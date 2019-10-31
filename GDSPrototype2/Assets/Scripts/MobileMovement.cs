using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobileMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed;
    private Rigidbody2D rb2d;

    public enum Player { One, Two };
    public Player player;

    float moveVertical;

    //public Vector2 touchAreaDivision;

    public void Update()
    {
        //if player == Player.One

        //Add or remove from speed
        Vector2 touchPos;

        if (Input.touchCount > 0)
        {
            if (Input.GetTouch(0).phase == TouchPhase.Stationary || Input.GetTouch(0).phase == TouchPhase.Moved)
            {
                touchPos = Input.GetTouch(0).position;
                float widthQuarter = Screen.width / 4;
                float heightQuarter = Screen.height / 4;

                if (player == Player.One)
                {
                    //fractions, compared to touch pos
                    //Check if along left side
                    //Detect if in the upper or lower bottom two quarters of the screen.

                    if (touchPos.x < widthQuarter)
                    {
                        if (touchPos.y < Screen.height / 2 && touchPos.y > heightQuarter)
                        {
                            //UP
                            Vector2 movement = new Vector2(0, moveVertical);
                            rb2d.AddForce(movement * speed);
                        }
                        else
                        {
                            rb2d.velocity = Vector2.zero;
                        }
                        if (touchPos.y < heightQuarter)
                        {
                            //DOWN
                            Vector2 movement = new Vector2(0, moveVertical);
                            rb2d.AddForce(movement * speed);
                        }
                        else
                        {
                            rb2d.velocity = Vector2.zero;
                        }
                    }
                }
                if (player == Player.Two)
                {
                    if (touchPos.x > Screen.width - widthQuarter)
                    {
                        if (touchPos.y < Screen.height / 2 && touchPos.y > heightQuarter)
                        {
                            //UP
                            Vector2 movement = new Vector2(0, moveVertical);
                            rb2d.AddForce(movement * speed);
                        }
                        else
                        {
                            rb2d.velocity = Vector2.zero;
                        }
                        if (touchPos.y < heightQuarter)
                        {
                            //DOWN
                            Vector2 movement = new Vector2(0, moveVertical);
                            rb2d.AddForce(movement * speed);
                        }
                        else
                        {
                            rb2d.velocity = Vector2.zero;
                        }
                    }
                }
            }
        }
    }
    public void FixedUpdate()
    {
        //Update velocity (add force, might want a cap?)
    }
}

