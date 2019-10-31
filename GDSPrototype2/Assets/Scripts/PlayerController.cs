using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    private Rigidbody2D rb2d;


    public enum Player { One, Two };
    public Player player;

    private float ScreenWidth;
    private float ScreenHeight;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //int i = 0;

        float moveVertical = Input.GetAxis("Vertical");
        if (player == Player.One)
        {
            Vector2 movement = new Vector2(0, moveVertical);
            if (Input.GetKey(KeyCode.W))
            {
                rb2d.AddForce(movement * speed);
            }
            else
            {
                rb2d.velocity = Vector2.zero;
                //speed = 0f;
            }

            if (Input.GetKey(KeyCode.S))
            {
                rb2d.AddForce(movement * speed);
            }
            else
            {
                rb2d.velocity = Vector2.zero;
                //speed = 0f;
            }
        }

        if (player == Player.Two)
        {
            Vector2 movement = new Vector2(0, moveVertical);
            if (Input.GetKey(KeyCode.UpArrow))
            {
                rb2d.AddForce(movement * speed);
            }
            else
            {
                rb2d.velocity = Vector2.zero;
                //speed = 0f;
            }

            if (Input.GetKey(KeyCode.DownArrow))
            {
                rb2d.AddForce(movement * speed);
            }
            else
            {
                rb2d.velocity = Vector2.zero;
                //speed = 0f;
            }
        }
    }
}
