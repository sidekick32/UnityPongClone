using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComputerPaddleMovement : MonoBehaviour {
    public Transform ball;
    public float Speed = 2;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (ball.transform.position.x < 0) {
            
            if (transform.position.y < ball.transform.position.y)
            {
                MoveComputerPaddleUp();
            }
            else if (transform.position.y > ball.transform.position.y) {
                MoveComputerPaddleDown();
            }
            //Catch a copy transform position to use with clamping
            Vector3 Clamp = transform.position;
            // Send the y to the clamp
            Clamp.y = Mathf.Clamp(transform.position.y, -3.49f, 3.52f);
            // Update new transform position
            transform.position = Clamp;
        }

	}

    void MoveComputerPaddleUp()
    {
        transform.position += Vector3.up * Speed * Time.deltaTime;
    }

    void MoveComputerPaddleDown() {
        transform.position += Vector3.down * Speed * Time.deltaTime;
    }
}
