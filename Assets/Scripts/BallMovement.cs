using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour {
    private Rigidbody2D body2D;
    private float forceX, forceY;
    public int speed;
    public Transform Player;
    private bool TowardPlayer;
    // Use this for initialization
    void Start() {
        body2D = GetComponent<Rigidbody2D>();
        int Roll = Random.Range(0, 2);
        if (Roll == 0)
        {
            TowardPlayer = false;
        }
        else
        {
            TowardPlayer = true;
        }

    }

    // Update is called once per frame
    void FixedUpdate() {
       
            forceX = 5.0f;
            forceY = Random.Range(-2.0f, 2.0f);
            MoveBall();
    }

    void MoveBall()
    {
        //throw ball toward player
        if (TowardPlayer == true)
        {
            body2D.velocity = new Vector2(forceX, forceY).normalized * speed;
        }
        else
        //throw ball toward cpu
        {
            body2D.velocity = new Vector2(-forceX,forceY).normalized * speed;
        }
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.name == "Top")
        {
            body2D.velocity += new Vector2(forceX, 1).normalized;

        }
        if (col.gameObject.name == "Bottom")
        {
            body2D.velocity += new Vector2(forceX, -1).normalized;

        }
        if (col.gameObject.name == "CpuTop")
        {

            body2D.velocity += new Vector2(forceX, 1).normalized;
        }
        if (col.gameObject.name == "CpuBottom")
        { 
            body2D.velocity += new Vector2(forceX, -1).normalized;
        }
        if (col.gameObject.name == "CpuLeftSpace")
        {
            TowardPlayer = true;
        }
        if (col.gameObject.name == "PlayerRightSpace")
        {
            TowardPlayer = false;
        }

     
        
    }
}
